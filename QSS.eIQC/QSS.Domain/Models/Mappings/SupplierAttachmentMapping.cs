/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierAttachment entity model with Database table and bootstrap
    /// </summary>
    public class SupplierAttachmentMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierAttachment,int>
    {
		/// <summary>
        /// Binds Database column SupplierAttachmentId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierAttachment> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierAttachmentId");

			builder.Property(p => p.Path)
				.IsRequired()
				.HasMaxLength(20);


        }
    }
}
