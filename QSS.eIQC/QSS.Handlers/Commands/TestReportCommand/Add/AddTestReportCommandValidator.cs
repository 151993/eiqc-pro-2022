/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.TestReportCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddTestReportCommandValidator : AbstractValidator<AddTestReportModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddTestReportCommandValidator()
        {

            RuleFor(r => r.Name).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
            RuleFor(r => r.Name).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));


            RuleFor(r => r.Description).MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));


            RuleFor(r => r.ChangeReason)
            .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
            .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
