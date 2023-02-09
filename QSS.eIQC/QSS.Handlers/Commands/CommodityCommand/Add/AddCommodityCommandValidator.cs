using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.CommodityCommand.Add
{
    public class AddCommodityCommandValidator : AbstractValidator<AddCommodityModel>
    {
        /// <summary>
        /// Contains validation logic
        /// </summary>
        public AddCommodityCommandValidator()
        {
          
            RuleFor(r => r.SAPCommodityId).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty);

            RuleFor(r => r.Name).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
                .MaximumLength(50).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.CommodityValidFrom).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
             .WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.CommodityValidTo).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
               .WithMessage(ValidationErrors.PropertyCannotExceedCharacters(50));

            RuleFor(r => r.Description).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
              .MaximumLength(150).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(150));

            RuleFor(r => r.ChangeReason).NotEmpty().WithMessage(ValidationErrors.PropertyCannotBeEmpty)
            .MaximumLength(256).WithMessage(ValidationErrors.PropertyCannotExceedCharacters(256));
        }
    }
}
