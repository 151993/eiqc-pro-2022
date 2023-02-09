
using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.ParameterTypeCodeCommand.Add
{
    /// <summary>
    /// Representation model for Add ParameterTypeCode operation
    /// </summary>
    public class AddParameterTypeCodeModel : BaseCommand, IRequest<ParameterTypeCodeModel>
    {
        /// <summary>
        /// Get or set ParameterManagementTypeId property
        /// </summary>        
        public int ParameterManagementTypeId { get; set; }

        /// <summary>
        /// Get or set AddedPcCodeIds property
        /// </summary>        
        public List<int> AddedPcCodeIds { get; set; }

        /// <summary>
        /// Get or set Name property
        /// </summary> 
        public string Name { get; set; }

        /// <summary>
        /// Get or set Description property
        /// </summary>        
        public string Description { get; set; }

    }
}
