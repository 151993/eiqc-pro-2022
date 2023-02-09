using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Handlers.Commands.DispositionTypeCommand.Update
{
   public  class UpdateDispositionTypeModel : BaseUpdateCommand<int>, IRequest<DispositionTypeModel>
    {
        public string Description { get; set; }

    }
}
