using production.pu.XS_PU_COMMODITY_CLASSIFICATION;
using production.pu.XS_PU_EIQC_SUPPLIER;
using QSS.eIQC.SAPHana.Services.Interface;
using QSS.eIQC.SAPHana.Services.Models;
using QSS.eIQC.SAPHana.Services.SAPModels;
using Reference;
using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Text;
using System.Threading.Tasks;
using production.pu.XS_PU_EIQC_PO;
using production.pu.XS_PU_SAMPLESIZECALC;

namespace QSS.eIQC.SAPHana.Services.Implementation
{
    public class SAPHanaClient : ISAPeHanaClient
    {
        private const string _authHeader = "Authorization";
        private const string _authType = "Basic ";
        private const string IP_SITE = "<IP_SITE>";
        private const string IP_PARTNO = "<IP_PARTNO>";
        private const string IP_PARTNO_SINGLE = "~<IP_PARTNO>~";
        private const string IP_PARTNO_QUOTE = "'~<IP_PARTNO>~'";
        private const string IP_VENDOR = "<IP_VENDOR>";
        private const string IP_CommodityRemovalField = ",IP_VENDOR=<IP_VENDOR>";
        private const string VALUATION_AREA = "<IP_VALUATIONAREA>";
        //VALUATION_AREA
        private static SAPHanaConfiguration _config;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="SAPHanaConfiguration">Injected instance of IOptionsSnapshot of SAPHanaConfiguration</param>
        public SAPHanaClient(SAPHanaConfiguration config)
        {
            _config = config;
        }

        private void OnBuildingRequest(object sender, BuildingRequestEventArgs e)
        {
            string authorization = $"{_config.UserName}:{_config.Password}";
            string base64 = Convert.ToBase64String(Encoding.Default.GetBytes(authorization));

            e.Headers.Add(_authHeader, _authType + base64);
        }

        public DataServiceQuery<COMMODITY_CLASSType> GetCommodityClassfication()
        {
            Uri baseAddress = new Uri($"{_config.BaseUrl}{_config.CommodityClassificationUrl}");
            var container = new XS_PU_COMMODITY_CLASSIFICATION(baseAddress);
            container.BuildingRequest += (sender, e) => OnBuildingRequest(sender, e);

            return container.COMMODITY_CLASS;
        }


        public DataServiceQuery<COMMODITY_CLASSType> GetCommodityClassficationForAllEnv(string filterValue)
        {
            string replacedFilterValue = _config.InputParameters;
            string[] arrayData = filterValue.Replace("(", "").Replace(")", "").Split(new string[] { "and" }, StringSplitOptions.None);
            foreach (var item in arrayData)
            {
                if (!string.IsNullOrEmpty(replacedFilterValue))
                {
                    if (item.Contains("SITE_NO"))
                    {
                        string separator = item.Contains(" eq ") ? "eq" : ",";
                        string[] resultData = item.Split(new string[] { separator }, StringSplitOptions.None);
                        replacedFilterValue = replacedFilterValue.Replace(IP_SITE, (resultData != null && resultData.Length > 1) ? resultData[1].Trim() : "''");
                    }
                    else if (item.Contains("PART_NO"))
                    {
                        string separator = item.Contains(" eq ") ? "eq" : ",";
                        string[] resultData = item.Split(new string[] { separator }, StringSplitOptions.None);
                        replacedFilterValue = replacedFilterValue.Replace(IP_PARTNO_SINGLE, (resultData != null && resultData.Length > 1) ? resultData[1].Replace("'", "").Trim() : "''");
                    }
                    else if (item.Contains("VENDOR_CODE"))
                    {
                        string separator = item.Contains(" eq ") ? "eq" : ",";
                        string[] resultData = item.Split(new string[] { separator }, StringSplitOptions.None);
                        replacedFilterValue = replacedFilterValue.Replace(IP_VENDOR, (resultData != null && resultData.Length > 1) ? resultData[1].Trim() : "''");
                    }
                }
            }

            if (replacedFilterValue.Contains(IP_SITE))
            {
                replacedFilterValue = replacedFilterValue.Replace(IP_SITE, "''");
            }
            if (replacedFilterValue.Contains(IP_PARTNO_SINGLE))
            {
                replacedFilterValue = replacedFilterValue.Replace(IP_PARTNO_SINGLE, "");
            }
            if (replacedFilterValue.Contains(IP_CommodityRemovalField))
            {
                replacedFilterValue = replacedFilterValue.Replace(IP_CommodityRemovalField, "");
            }
            Uri baseAddress = new Uri($"{_config.BaseUrl}{_config.CommodityClassificationUrl}/{replacedFilterValue}");
            var container = new XS_PU_COMMODITY_CLASSIFICATION(baseAddress);
            container.BuildingRequest += (sender, e) => OnBuildingRequest(sender, e);

            return container.COMMODITY_CLASS;
        }


        public DataServiceQuery<POType> GetPurchaseOrder()
        {
            Uri baseAddress = new Uri($"{_config.BaseUrl}{_config.PurchaseOrderUrl}");
            var container = new XS_PU_EIQC_PO(baseAddress);
            container.BuildingRequest += (sender, e) => OnBuildingRequest(sender, e);

            return container.PO;
        }

        public DataServiceQuery<POType> GetPurchaseOrderForAllEnv(string filterValue)
        {
            string replacedFilterValue = _config.InputParameters;
            string[] arrayData = filterValue.Replace("(", "").Replace(")", "").Split(new string[] { "and" }, StringSplitOptions.None);
            foreach (var item in arrayData)
            {
                if (!string.IsNullOrEmpty(replacedFilterValue))
                {
                    if (item.Contains("SITE"))
                    {
                        string separator = item.Contains(" eq ") ? "eq" : ",";
                        string[] resultData = item.Split(new string[] { separator }, StringSplitOptions.None);
                        replacedFilterValue = replacedFilterValue.Replace(IP_SITE, (resultData != null && resultData.Length > 1) ? resultData[1].Trim() : "''");
                    }
                    else if (item.Contains("PART_NO"))
                    {
                        string separator = item.Contains(" eq ") ? "eq" : ",";
                        string[] resultData = item.Split(new string[] { separator }, StringSplitOptions.None);
                        replacedFilterValue = replacedFilterValue.Replace(IP_PARTNO_SINGLE, (resultData != null && resultData.Length > 1) ? resultData[1].Replace("'", "").Trim() : "''");
                    }
                    else if (item.Contains("VENDOR_CODE"))
                    {
                        string separator = item.Contains(" eq ") ? "eq" : ",";
                        string[] resultData = item.Split(new string[] { separator }, StringSplitOptions.None);
                        replacedFilterValue = replacedFilterValue.Replace(IP_VENDOR, (resultData != null && resultData.Length > 1) ? resultData[1].Trim() : "''");
                    }
                }
            }

            if (replacedFilterValue.Contains(IP_SITE))
            {
                replacedFilterValue = replacedFilterValue.Replace(IP_SITE, "''");
            }
            if (replacedFilterValue.Contains(IP_PARTNO_SINGLE))
            {
                replacedFilterValue = replacedFilterValue.Replace(IP_PARTNO_SINGLE, "");
            }
            if (replacedFilterValue.Contains(IP_VENDOR))
            {
                replacedFilterValue = replacedFilterValue.Replace(IP_VENDOR, "''");
            }

            Uri baseAddress = new Uri($"{_config.BaseUrl}{_config.PurchaseOrderUrl}/{replacedFilterValue}");
            var container = new XS_PU_EIQC_PO(baseAddress);
            container.BuildingRequest += (sender, e) => OnBuildingRequest(sender, e);

            return container.PO;
        }

        public DataServiceQuery<PARTNUMBER_BY_SITEType> GetPartNumber()
        {
            Uri baseAddress = new Uri($"{_config.BaseUrl}{_config.PartNumberUrl}");
            var container = new XS_PU_PARTNUMBER_SITE_MANUF(baseAddress);
            container.BuildingRequest += (sender, e) => OnBuildingRequest(sender, e);

            return container.PARTNUMBER_BY_SITE;
        }

        public DataServiceQuery<SUPPLIERType> GetSuppliers()
        {
            Uri baseAddress = new Uri($"{_config.BaseUrl}{_config.SupplierAddressUrl}");
            var container = new XS_PU_EIQC_SUPPLIER(baseAddress);
            container.BuildingRequest += (sender, e) => OnBuildingRequest(sender, e);

            return container.SUPPLIER;
        }


        public DataServiceQuery<SUPPLIERType> GetSuppliersForAllEnv(string filterValue, out string valuationArea)
        {
            string replacedFilterValue = _config.SupplierInputParameters;
            string[] arrayData = filterValue.Replace("(", "").Replace(")", "").Split(new string[] { "and" }, StringSplitOptions.None);
            valuationArea = String.Empty;
            foreach (var item in arrayData)
            {
                if (!string.IsNullOrEmpty(replacedFilterValue))
                {
                    if (item.Contains("VALUATION_AREA"))
                    {
                        string separator = item.Contains(" eq ") ? "eq" : ",";
                        string[] resultData = item.Split(new string[] { separator }, StringSplitOptions.None);

                        replacedFilterValue = replacedFilterValue.Replace(VALUATION_AREA, (resultData != null && resultData.Length > 1) ? valuationArea = resultData[1].Trim() : "''");
                    }
                }
            }
            if (replacedFilterValue.Contains(VALUATION_AREA))
            {
                replacedFilterValue = replacedFilterValue.Replace(VALUATION_AREA, "''");
            }

            Uri baseAddress = new Uri($"{_config.BaseUrl}{_config.SupplierAddressUrl}/{replacedFilterValue}");
            var container = new XS_PU_EIQC_SUPPLIER(baseAddress);
            container.BuildingRequest += (sender, e) => OnBuildingRequest(sender, e);

            return container.SUPPLIER;
        }

        public DataServiceQuery<SAMPLESIZECALCType> GetSampleSizeForHAD(string filterValue)
        {
            string replacedFilterValue = _config.InputParameters;
            string[] arrayData = filterValue.Replace("(", "").Replace(")", "").Split(new string[] { "and" }, StringSplitOptions.None);
            foreach (var item in arrayData)
            {
                if (!string.IsNullOrEmpty(replacedFilterValue))
                {
                    if (item.Contains("SITE"))
                    {
                        string separator = item.Contains(" eq ") ? "eq" : ",";
                        string[] resultData = item.Split(new string[] { separator }, StringSplitOptions.None);
                        replacedFilterValue = replacedFilterValue.Replace(IP_SITE, (resultData != null && resultData.Length > 1) ? resultData[1].Trim() : "''");
                    }
                    else if (item.Contains("PART_NO"))
                    {
                        string separator = item.Contains(" eq ") ? "eq" : ",";
                        string[] resultData = item.Split(new string[] { separator }, StringSplitOptions.None);
                        replacedFilterValue = replacedFilterValue.Replace(IP_PARTNO, (resultData != null && resultData.Length > 1) ? resultData[1].Replace("'", "").Trim() : "''");
                    }
                    else if (item.Contains("VENDOR_CODE"))
                    {
                        string separator = item.Contains(" eq ") ? "eq" : ",";
                        string[] resultData = item.Split(new string[] { separator }, StringSplitOptions.None);
                        replacedFilterValue = replacedFilterValue.Replace(IP_VENDOR, (resultData != null && resultData.Length > 1) ? resultData[1].Trim() : "''");
                    }
                }
            }

            if (replacedFilterValue.Contains(IP_SITE))
            {
                replacedFilterValue = replacedFilterValue.Replace(IP_SITE, "''");
            }
            if (replacedFilterValue.Contains(IP_PARTNO))
            {
                replacedFilterValue = replacedFilterValue.Replace(IP_PARTNO, "");
            }
            if (replacedFilterValue.Contains(IP_VENDOR))
            {
                replacedFilterValue = replacedFilterValue.Replace(IP_VENDOR, "''");
            }

            Uri baseAddress = new Uri($"{_config.BaseUrl}{_config.SampleSizeUrl}/{replacedFilterValue}");
            var container = new XS_PU_SAMPLESIZECALC(baseAddress);
            container.BuildingRequest += (sender, e) => OnBuildingRequest(sender, e);
            return container.SAMPLESIZECALC;
        }


        public DataServiceQuery<SAMPLESIZECALCType> GetSampleSize()
        {
            Uri baseAddress = new Uri($"{_config.BaseUrl}{_config.SampleSizeUrl}");
            var container = new XS_PU_SAMPLESIZECALC(baseAddress);
            container.BuildingRequest += (sender, e) => OnBuildingRequest(sender, e);
            return container.SAMPLESIZECALC;
        }

        public DataServiceQuery<SAMPLINGPLANType> GetSamplingPlans()
        {
            Uri baseAddress = new Uri($"{_config.BaseUrl}{_config.SamplingPlanUrl}");
            var container = new XS_PU_SAMPLINGPLAN(baseAddress);
            container.BuildingRequest += (sender, e) => OnBuildingRequest(sender, e);

            return container.SAMPLINGPLAN;
        }
    }
}
