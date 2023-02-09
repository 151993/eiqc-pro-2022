/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.UOMCommand.Update
{
    /// <summary>
    /// Representation model for Update UOM operation
    /// </summary>
    public class UpdateUOMModel : BaseUpdateCommand<int>, IRequest<UOMModel>
    {
        public string Name { get; set; }

        /// <summary>
        /// Get or set Description property
        /// </summary>        
        public string Description { get; set; }


    }
}
