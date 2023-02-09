using MediatR;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.DepartmentCommand.Update
{
    public class UpdateDepartmentModel : BaseUpdateCommand<int>, IRequest<DepartmentModel>
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

       
    }
}
