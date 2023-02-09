/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.SupplierFormCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddSupplierFormCommandValidator : AbstractValidator<AddSupplierFormModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddSupplierFormCommandValidator()
        {
           
            //RuleFor(r => r.PONo)
            //    .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
            //    .MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));

            //RuleFor(r => r.PartNo)
            //    .MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));


            //RuleFor(r => r.FileName)
            //    .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
            //    .MaximumLength(4000).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(4000));

            //RuleFor(r => r.DateCode)
            //    .MaximumLength(200).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(200));



            //RuleFor(r => r.ApproveUser)
            //    .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
            //    .MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));

            //RuleFor(r => r.TotalQty)
            //    .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)

            //    .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            //RuleFor(r => r.Inspector)
            //    .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
            //    .MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));

            //RuleFor(r => r.Verify)
            //    .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
            //    .MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));

            //RuleFor(r => r.ImportStatus)
            //    .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            //RuleFor(r => r.ImportError)
            //    .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
            //    .MaximumLength(4000).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(4000));

            //RuleFor(r => r.MO)
            //    .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
            //    .MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));

            //RuleFor(r => r.MovedPath)
            //    .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
            //    .MaximumLength(4000).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(4000));

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
