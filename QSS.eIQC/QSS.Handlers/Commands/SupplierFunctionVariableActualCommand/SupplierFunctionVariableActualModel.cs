/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Handlers.Commands.InstrumentCommand;
using QSS.eIQC.Handlers.Commands.InstrumentTypeCommand;
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand;
using QSS.eIQC.Handlers.Commands.UOMCommand;

namespace QSS.eIQC.Handlers.Commands.SupplierFunctionVariableActualCommand
{
    public class SupplierFunctionVariableActualModel : BaseStausModel<int>
    {
        public int SupplierFunctionVariableId { get; set; }

        public string ActualTextName { get; set; }

        public string ActualTextValue { get; set; }

    }
}
