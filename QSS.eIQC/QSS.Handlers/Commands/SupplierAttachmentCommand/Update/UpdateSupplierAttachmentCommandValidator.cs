/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.SupplierAttachmentCommand.Update
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class UpdateSupplierAttachmentCommandValidator : AbstractValidator<UpdateSupplierAttachmentModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateSupplierAttachmentCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);




                RuleFor(r => r.SupplierFormId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

                RuleFor(r => r.ATType).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.ATType).MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));

                RuleFor(r => r.Path).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.Path).MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));

           // TODO : any additional validations

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
