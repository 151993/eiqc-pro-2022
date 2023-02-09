/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormPartSAPFailedQty entity model with Database table and bootstrap
    /// </summary>
    public class FormPartSAPFailedQtyMapping : EntityTypeConfigurationWithUpdateUserAudit<FormPartSAPFailedQty,int>
    {
		/// <summary>
        /// Binds Database column FormPartSAPFailedQtyId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormPartSAPFailedQty> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormPartSAPFailedQtyId");

			builder.Property(p => p.GRSNo)
				.HasMaxLength(20);
			builder.Property(p => p.PCCode)
				.HasMaxLength(255);
        }
    }
}
