/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.FormCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddFormCommandValidator : AbstractValidator<AddFormModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddFormCommandValidator()
        {
           



                RuleFor(r => r.FormTypeId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);




                RuleFor(r => r.GRSId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);


                RuleFor(r => r.DPID).MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));

                RuleFor(r => r.SampleQTY).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);


                RuleFor(r => r.DateCode).MaximumLength(200).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(200));








                RuleFor(r => r.Remark).MaximumLength(1000).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(1000));


                RuleFor(r => r.UserName).MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));


                RuleFor(r => r.QN).MaximumLength(20).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(20));


                RuleFor(r => r.IPVersion).MaximumLength(100).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(100));


                RuleFor(r => r.RefDoc).MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));


                RuleFor(r => r.QNSoftcopy).MaximumLength(100).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(100));


                RuleFor(r => r.GRSNoType).MaximumLength(10).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(10));


                RuleFor(r => r.BatchDC).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));


                RuleFor(r => r.StorageLoc).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));











                RuleFor(r => r.OddQtyPerBox).MaximumLength(100).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(100));


                RuleFor(r => r.ReceivingInfo).MaximumLength(4000).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(4000));


                RuleFor(r => r.DANo).MaximumLength(200).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(200));















































                RuleFor(r => r.SpecDefectType).MaximumLength(2550).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(2550));








                RuleFor(r => r.LockUser).MaximumLength(255).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(255));


                RuleFor(r => r.DCRequirement).MaximumLength(4000).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(4000));

            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
