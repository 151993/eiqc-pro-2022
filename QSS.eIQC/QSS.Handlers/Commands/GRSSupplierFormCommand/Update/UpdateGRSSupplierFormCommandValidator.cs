/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.GRSSupplierFormCommand.Update
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class UpdateGRSSupplierFormCommandValidator : AbstractValidator<UpdateGRSSupplierFormModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateGRSSupplierFormCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);




                RuleFor(r => r.SupplierFormId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);





                RuleFor(r => r.GRSNo).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));





                RuleFor(r => r.GRSNo).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));


                RuleFor(r => r.SubmitUser).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));








            // TODO : any additional validations

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
