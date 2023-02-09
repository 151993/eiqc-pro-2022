using MediatR;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.DepartmentCommand.Add
{
    public class AddDepartmentModel : BaseCommand, IRequest<DepartmentModel>
    {
       

        public string Name { get; set; }

        public string Description { get; set; }
        
    }
}
