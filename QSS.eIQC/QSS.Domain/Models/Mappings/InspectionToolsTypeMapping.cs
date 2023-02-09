/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map InspectionToolsType entity model with Database table and bootstrap
    /// </summary>
    public class InspectionToolsTypeMapping : EntityTypeConfigurationWithUpdateUserAudit<InspectionToolsType,int>
    {
		/// <summary>
        /// Binds Database column InspectionToolsTypeId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<InspectionToolsType> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("InspectionToolsTypeId");

            builder.HasIndex(p => p.Type)
                .HasName("UK_InspectionToolsType_Type")
                .IsUnique();

            builder.Property(p => p.Description)
				.HasMaxLength(255);


        }
    }
}
