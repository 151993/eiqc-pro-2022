using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.CommodityCommand.Delete
{
    public class DeleteCommodityCommandValidator :  AbstractValidator<DeleteCommodityModel>
    {

        /// <summary>
        /// Contains validation logic
        /// </summary>
        public DeleteCommodityCommandValidator()
        {
            // Property validations
            RuleFor(r => r.Id).NotEmpty().WithMessage(ValidationErrors.PropertyMustBeProvided);

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
