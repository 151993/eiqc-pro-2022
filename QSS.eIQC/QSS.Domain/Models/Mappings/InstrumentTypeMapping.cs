/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map InstrumentType entity model with Database table and bootstrap
    /// </summary>
    public class InstrumentTypeMapping : EntityTypeConfigurationWithUpdateUserAudit<InstrumentType,int>
    {
		/// <summary>
        /// Binds Database column InstrumentTypeId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<InstrumentType> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("InstrumentTypeId");

            builder.HasIndex(p => p.Code)
                .HasName("UK_InstrumentType_Code")
                .IsUnique();
            builder.Property(p => p.Description)
				.HasMaxLength(255);

        }
    }
}
