/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.FormLPositionActualCommand.Add
{
    /// <summary>
    /// Validator for Add Role operation
    /// </summary>
    public class AddFormLPositionActualCommandValidator : AbstractValidator<AddFormLPositionActualModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddFormLPositionActualCommandValidator()
        {
           



                RuleFor(r => r.FormId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

                RuleFor(r => r.LineNo).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);
                RuleFor(r => r.LineNo).MaximumLength(200).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(200));

                RuleFor(r => r.No).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);











                RuleFor(r => r.Result).MaximumLength(200).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(200));


                RuleFor(r => r.InstrumentID).MaximumLength(200).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(200));


                RuleFor(r => r.InstrumentID2).MaximumLength(200).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(200));











                RuleFor(r => r.InstrumentID1).MaximumLength(200).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(200));


                RuleFor(r => r.InstrumentID2).MaximumLength(200).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(200));


                RuleFor(r => r.InstrumentID3).MaximumLength(200).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(200));




            // TODO : any additional validations

            RuleFor(r => r.ChangeReason)
                .NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
