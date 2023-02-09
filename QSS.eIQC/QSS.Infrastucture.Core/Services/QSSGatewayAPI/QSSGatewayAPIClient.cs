using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using QSS.Infrastructure.Core.QSSGatewayAPI.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using SAPHana.Model;
using Default;
using Microsoft.OData.Client;

namespace QSS.Infrastructure.Core.Services.QSSGatewayAPI
{
    public class QSSGatewayAPIClient : IQSSGatewayAPIClient
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<QSSGatewayAPIClient> _logger;

        /// <summary>
        /// Store IHttpClientFactory
        /// </summary>
        private IHttpClientFactory _httpClientFactory;

        /// <summary>
        /// Store QSSGatewayAPIOptions
        /// </summary>
        private readonly IOptionsSnapshot<QSSGatewayAPIOptions> _qssGatewayAPIOptions;

        private static readonly string QSS_API = "QSS API";
        private static readonly string ClientName = "QssGatewayAPIService";
        private static string _accessToken = "";
        private static DateTime _tokenExpiration = new DateTime();

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of QSSGatewayAPIClient at runtime</param>
        /// <param name="httpClientFactory">Injected instance of IHttpClientFactory</param>
        /// <param name="qssGatewayAPIOptions">Injected instance of IOptionsSnapshot of QSSGatewayAPIOptions</param>
        public QSSGatewayAPIClient(ILogger<QSSGatewayAPIClient> logger, IHttpClientFactory httpClientFactory, IOptionsSnapshot<QSSGatewayAPIOptions> qssGatewayAPIOptions)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _qssGatewayAPIOptions = qssGatewayAPIOptions;
        }

        /// <summary>
        /// Search Active Directory by SamAccount or Name
        /// </summary>
        /// <param name="input">SamAccount or Name</param>
        /// <returns>Returs response model</returns>
        public async Task<ADUserResponse> SearchBySamAccountOrName(string input)
        {
            try
            {
                // Get access token
                var accessToken = GetAccessToken();
                var client = _httpClientFactory.CreateClient(ClientName);
                client.BaseAddress = new Uri($"{client.BaseAddress}{_qssGatewayAPIOptions.Value.ActiveDirectoryUrl}{_qssGatewayAPIOptions.Value.SearchBySamAccountOrName}/{input}");
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(
                    "Bearer", accessToken);

                _logger.LogInformation(string.Format(CultureInfo.InvariantCulture,
                                $"Querying {QSS_API} @ {client.BaseAddress.AbsoluteUri}"));

                var response = await client.GetAsync(client.BaseAddress.AbsoluteUri);

                var result = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = JsonConvert.DeserializeObject<ADUserResponse>(result);
                    _logger.LogInformation($"Status {response.StatusCode} from {QSS_API} with Count : {res.Count}");
                    return res;
                }
                else
                {
                    _accessToken = "";
                    _logger.LogError($"Status {response.StatusCode} from {QSS_API} with Message : {result}");
                    throw new Exception($"Status {response.StatusCode} from {QSS_API} with Message : {result}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception at SearchBySamAccountOrName : {ex}");
                throw;
            }

        }

        /// <summary>
        /// Get Authentication token
        /// </summary>
        /// <returns></returns>
        private string GetAccessToken()
        {
            try
            {
                // Save the access token and return if still valid. Else regenerate the access token.
                var currDT = _tokenExpiration.AddMinutes(30);
                if (currDT < DateTime.Now)
                {
                    if (!string.IsNullOrWhiteSpace(_accessToken))
                    {
                        return _accessToken;
                    }
                }

                var client = _httpClientFactory.CreateClient(ClientName);
                client.BaseAddress = new Uri($"{client.BaseAddress}{_qssGatewayAPIOptions.Value.TokenUrl}");

                _logger.LogInformation(string.Format(CultureInfo.InvariantCulture,
                                $"Getting access token from {QSS_API} @ {client.BaseAddress.AbsoluteUri}"));

                var response = client.PostAsJsonAsync(client.BaseAddress, new
                {
                    clientId = _qssGatewayAPIOptions.Value.ClientID,
                    clientSecret = _qssGatewayAPIOptions.Value.ClientSecret
                }).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode)
                {
                    dynamic t = JsonConvert.DeserializeObject(result);
                    _logger.LogInformation($"Status {response.StatusCode} from {QSS_API} with Message : {result}");
                    _accessToken = t.token;
                    return t.token;
                }
                else
                {
                    _accessToken = "";
                    _logger.LogError($"Status {response.StatusCode} from {QSS_API} with Message : {result}");
                    throw new Exception($"Status {response.StatusCode} from {QSS_API} with Message : {result}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception at GetAccessToken : {ex}");
                throw;
            }

        }

        /// <summary>
        /// Send Email
        /// </summary>
        /// <param name="emailModel">Email Model</param>
        public void SendEmail(EmailModel emailModel)
        {
            try
            {
                // Get access token
                var accessToken = GetAccessToken();
                var client = _httpClientFactory.CreateClient(ClientName);
                client.BaseAddress = new Uri($"{client.BaseAddress}{_qssGatewayAPIOptions.Value.EmailUrl}{_qssGatewayAPIOptions.Value.SendEmail}");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                    "Bearer", accessToken);

                _logger.LogInformation(string.Format(CultureInfo.InvariantCulture,
                                $"Getting access token from {QSS_API} @ {client.BaseAddress.AbsoluteUri}"));

                var content = JsonConvert.SerializeObject(emailModel);
                var buffer = System.Text.Encoding.UTF8.GetBytes(content);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                client.PostAsync(client.BaseAddress.AbsoluteUri, byteContent);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception at SendEmail : {ex}");
                throw;
            }
        }

        /// <summary>
        /// GetParts from SAP service
        /// </summary>
        /// <returns>Returs response model</returns>
        public DataServiceQuery<SitePartModel> GetParts()
        {
            try
            {
                Uri baseAddress = new Uri($"{_qssGatewayAPIOptions.Value.BaseUrl}odata");
                var container = GetOdataClient(baseAddress);

                _logger.LogInformation(string.Format(CultureInfo.InvariantCulture, $"Querying {QSS_API} @ {baseAddress.AbsoluteUri}"));

                return container.SitePart;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception at GetParts : {ex}");
                throw;
            }
        }

        private Container GetOdataClient(Uri baseAddress)
        {
            var container = new Default.Container(baseAddress);
            container.BuildingRequest += (sender, e) => OnBuildingRequest(sender, e);

            return container;
        }
        private void OnBuildingRequest(object sender, BuildingRequestEventArgs e)
        {
            var accessToken = GetAccessToken();
            e.Headers.Add("Authorization", "Bearer " + accessToken);
        }

        /// <summary>
        /// Search Active Directory by Email
        /// </summary>
        /// <param name="email">Email</param>
        /// <returns>Returs response model</returns>
        public async Task<ADUserResponse> SearchByEmail(string email)
        {
            try
            {
                // Get access token
                var accessToken = GetAccessToken();
                var client = _httpClientFactory.CreateClient(ClientName);
                client.BaseAddress = new Uri($"{client.BaseAddress}{_qssGatewayAPIOptions.Value.ActiveDirectoryUrl}{_qssGatewayAPIOptions.Value.SearchByEmail}/{email}");
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(
                    "Bearer", accessToken);

                _logger.LogInformation(string.Format(CultureInfo.InvariantCulture,
                                $"Querying {QSS_API} @ {client.BaseAddress.AbsoluteUri}"));

                var response = await client.GetAsync(client.BaseAddress.AbsoluteUri);

                var result = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = JsonConvert.DeserializeObject<ADUserResponse>(result);
                    _logger.LogInformation($"Status {response.StatusCode} from {QSS_API} with Count : {res.Count}");
                    return res;
                }
                else
                {
                    _accessToken = "";
                    _logger.LogError($"Status {response.StatusCode} from {QSS_API} with Message : {result}");
                    throw new Exception($"Status {response.StatusCode} from {QSS_API} with Message : {result}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception at SearchByEmail : {ex}");
                throw;
            }

        }
        /// <summary>
        /// Get Division
        /// </summary>
        /// <param name="dateTime">Date time</param>
        public async Task<IList<TM1DivisionModel>> GetDivision(DateTimeOffset dateTime)
        {
            string lastTime = dateTime.UtcDateTime.ToString("o");
            return await GetTM1Data<TM1DivisionModel>(_qssGatewayAPIOptions.Value.DivisionUrl, lastTime);
        }
        private async Task<IList<T>> GetTM1Data<T>(string api, string dateTime) where T : class
        {
            try
            {
                // Get access token
                var accessToken = GetAccessToken();
                var client = _httpClientFactory.CreateClient(ClientName);
                var dateParam = string.IsNullOrEmpty(dateTime) ? string.Empty : $"&dateTime={dateTime}";
                client.BaseAddress = new Uri($"{client.BaseAddress}{api}{dateParam}");
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(
                    "Bearer", accessToken);

                _logger.LogInformation(string.Format(CultureInfo.InvariantCulture,
                                $"Querying {QSS_API} @ {client.BaseAddress.AbsoluteUri}"));

                var response = await client.GetAsync(client.BaseAddress.AbsoluteUri);

                var result = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = JsonConvert.DeserializeObject<IList<T>>(result);
                    _logger.LogInformation($"Status {response.StatusCode} from {QSS_API} with Count : {res.Count}");
                    return res;
                }
                else
                {
                    _accessToken = "";
                    _logger.LogError($"Status {response.StatusCode} from {QSS_API} with Message : {result}");
                    throw new Exception($"Status {response.StatusCode} from {QSS_API} with Message : {result}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception at SearchBySamAccountOrName : {ex}");
                throw;
            }

        }

        /// <summary>
        /// Get Site
        /// </summary>
        /// <param name="dateTime">Date time</param>
        public async Task<IList<TM1SiteModel>> GetSite(DateTimeOffset dateTime)
        {
            string lastTime = dateTime.UtcDateTime.ToString("o");
            return await GetTM1Data<TM1SiteModel>(_qssGatewayAPIOptions.Value.SiteUrl, lastTime);
        }
    }
}
