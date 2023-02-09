/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.SupplierCommand.Update
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class UpdateSupplierCommandValidator : AbstractValidator<UpdateSupplierModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateSupplierCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

                RuleFor(r => r.SAPSupplierModel_ID).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.SAPSupplierModel_ID).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

                RuleFor(r => r.ValuationArea).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.ValuationArea).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(10));

                RuleFor(r => r.Email).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.Email).MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));


                RuleFor(r => r.PhoneNo).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));


                RuleFor(r => r.FaxNo).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

                RuleFor(r => r.VendorCode).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.VendorCode).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

                RuleFor(r => r.VendorName).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.VendorName).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));


                RuleFor(r => r.Address).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));


                RuleFor(r => r.StreetNo).MaximumLength(100).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(100));


                RuleFor(r => r.City).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));


                RuleFor(r => r.PostalCode).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));


                RuleFor(r => r.Country).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));


                RuleFor(r => r.SupplierStatus).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));


                RuleFor(r => r.SearchTerm).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));




            // TODO : any additional validations

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
