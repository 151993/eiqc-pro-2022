using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Handlers.Commands.DispositionTypeCommand.Add
{
   public class AddDispositionTypeModel : BaseCommand, IRequest<DispositionTypeModel>
    {
        public string Description { get; set; }

    }
}
