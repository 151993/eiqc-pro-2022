/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map PartCountParameter entity model with Database table and bootstrap
    /// </summary>
    public class PartInspectionDrawingMapping : EntityTypeConfigurationWithUpdateUserAudit<PartInspectionDrawing, int>
    {
		/// <summary>
        /// Binds Database column PartCountParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<PartInspectionDrawing> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("PartInspectionDrawingId");
        }
    }
}
