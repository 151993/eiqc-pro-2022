/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.GRSCommand.Update
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class UpdateGRSCommandValidator : AbstractValidator<UpdateGRSModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateGRSCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

                RuleFor(r => r.GRSNo).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.GRSNo).MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));

                RuleFor(r => r.PartNo).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

                RuleFor(r => r.PartNo).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.PartNo).MaximumLength(25).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(25));

                RuleFor(r => r.PartNo).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

                RuleFor(r => r.PartNo).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.PartNo).MaximumLength(25).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(25));


                RuleFor(r => r.MedialCode).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));


                RuleFor(r => r.MPN).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));


                RuleFor(r => r.MaterialName).MaximumLength(100).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(100));


                RuleFor(r => r.MFG).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));





                RuleFor(r => r.LotNo).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));








                RuleFor(r => r.InspectorName).MaximumLength(8000).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(8000));


                RuleFor(r => r.InspectionResult).MaximumLength(8000).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(8000));


                RuleFor(r => r.GRSNoType).MaximumLength(10).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(10));


                RuleFor(r => r.PO).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));


                RuleFor(r => r.VendorCode).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));


                RuleFor(r => r.MatlGroup).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));


                RuleFor(r => r.VendorName1).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));


                RuleFor(r => r.SkipIQC).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));




                RuleFor(r => r.StatusTypeId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
