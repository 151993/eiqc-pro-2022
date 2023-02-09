using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Handlers.Commands.EmailTemplateCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers.EmailTemplate
{
	/// <summary>
	/// EmailTemplate Configurations OData controller
	/// </summary>
	
    [ODataRoutePrefix("EmailTemplate")]
    public class EmailTemplateODataController : ODataController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<EmailTemplateODataController> _logger;

        /// <summary>
        /// Store IApplicationConfigurationContext, <see cref="IQSSContext"/>
        /// </summary>
        private readonly IQSSContext _context;

        /// <summary>
        /// Store IMapper, <see cref="IMapper"/>
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Contructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of EmailTemplateODataController on runtime, <see cref="ILogger"/></param>
        /// <param name="context">Injected instance of IApplicationConfigurationContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public EmailTemplateODataController(ILogger<EmailTemplateODataController> logger,
            IQSSContext context,
            IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// OData api to retrieve a EmailTemplate list
        /// </summary>
        /// <returns>An queryable object of EmailTemplateModel, <see cref="EmailTemplateModel"/></returns>
        [HttpGet]
        [EnableQuery]
        [ODataRoute("")]
        public IQueryable<EmailTemplateModel> Get()
        {
            return _context.EmailTemplate.ProjectTo<EmailTemplateModel>(_mapper.ConfigurationProvider).AsQueryable();
        }


        /// <summary>
        /// OData api to return a Depertment matching key 
        /// </summary>
        /// <param name="id">Takes input EmailTemplate Id as a key</param>
        /// <returns>An queryable object of EmailTemplateModel,  <see cref="EmailTemplateModel"/></returns>
        [HttpGet]
        [EnableQuery]
        [ODataRoute("({id})")]
        public IQueryable<EmailTemplateModel> Get([FromODataUri]int id)
        {
            return _context.EmailTemplate.Where(d => d.Id == id).ProjectTo<EmailTemplateModel>(_mapper.ConfigurationProvider).AsQueryable();
        }
    }
}