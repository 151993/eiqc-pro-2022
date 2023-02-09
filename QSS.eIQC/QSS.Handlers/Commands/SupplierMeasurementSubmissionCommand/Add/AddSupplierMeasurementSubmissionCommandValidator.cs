/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddSupplierMeasurementSubmissionCommandValidator : AbstractValidator<AddSupplierMeasurementSubmissionModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddSupplierMeasurementSubmissionCommandValidator()
        {

            RuleFor(r => r.IP).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
            RuleFor(r => r.IP).MaximumLength(100).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(100));

            RuleFor(r => r.PurchaseOrderId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);


            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
