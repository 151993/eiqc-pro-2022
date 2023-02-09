using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using QSS.eIQC.DataAccess.DataContext;

namespace QSS.eIQC.Api.Helpers.Http
{
    //[Authorize]
    public class BaseODataController : ODataController
    {
        private readonly IQSSContext _context;

        private readonly IMapper _mapper;

        /// <summary>
        /// Get the context instance
        /// </summary>
        protected IQSSContext Context => _context;

        /// <summary>
        /// Get the mapper instance
        /// </summary>
        protected IMapper Mapper => _mapper;

        public BaseODataController(
            IQSSContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

            // Set the tracking behavior to NoTracking for optimized results
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
    }
}