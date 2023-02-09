/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using FluentValidation;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.GoodsReceiveUserCommand.Update
{
    /// <summary>
    /// Validator for Update Role operation
    /// </summary>
    public class UpdateGoodsReceiveUserCommandValidator : AbstractValidator<UpdateGoodsReceiveUserModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public UpdateGoodsReceiveUserCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

            RuleFor(r => r.WareHouse)
                .MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

            RuleFor(r => r.SAPUser)
                .MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

            RuleFor(r => r.UserName)
                .MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

            RuleFor(r => r.SupervisorMail)
                .MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

            RuleFor(r => r.LeaderMail)
                .MaximumLength(250).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(250));

           // TODO : any additional validations

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
