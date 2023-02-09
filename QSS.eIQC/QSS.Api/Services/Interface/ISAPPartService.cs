using QSS.eIQC.Handlers.Commands.PartCommand;
using Microsoft.AspNet.OData.Query;
using System.Linq;
using Microsoft.AspNet.OData;
using System;

namespace QSS.eIQC.Api.Services.Interface
{
    public interface ISAPPartService
    {
        PageResult<PartModel> Get(ODataQueryOptions queryOptions, Uri uri);
    }
}
