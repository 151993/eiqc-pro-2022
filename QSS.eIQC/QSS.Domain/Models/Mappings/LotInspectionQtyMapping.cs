/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map LotInspectionQty entity model with Database table and bootstrap
    /// </summary>
    public class LotInspectionQtyMapping : EntityTypeConfigurationWithUpdateUserAudit<LotInspectionQty,int>
    {
		/// <summary>
        /// Binds Database column LotInspectionQtyId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<LotInspectionQty> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("LotInspectionQtyId");

			builder.Property(p => p.LotNo)
				.HasMaxLength(250);
			builder.Property(p => p.Material)
				.HasMaxLength(250);
			builder.Property(p => p.MstrChar)
				.HasMaxLength(250);
			builder.Property(p => p.InspStg)
				.HasMaxLength(250);


        }
    }
}
