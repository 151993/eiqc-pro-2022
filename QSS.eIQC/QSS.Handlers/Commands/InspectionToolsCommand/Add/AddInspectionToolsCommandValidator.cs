/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.InspectionToolsCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddInspectionToolsCommandValidator : AbstractValidator<AddInspectionToolsModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddInspectionToolsCommandValidator()
        {
            RuleFor(r => r.InspectionToolsTypeId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.Name).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.InspectionToolsTypeId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
