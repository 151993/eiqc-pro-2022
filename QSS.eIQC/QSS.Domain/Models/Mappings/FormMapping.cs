/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map Form entity model with Database table and bootstrap
    /// </summary>
    public class FormMapping : EntityTypeConfigurationWithUpdateUserAudit<Form,int>
    {
		/// <summary>
        /// Binds Database column FormId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<Form> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormId");

			builder.Property(p => p.DPID)
				.HasMaxLength(20);
			builder.Property(p => p.SampleQTY)
				.IsRequired();
			builder.Property(p => p.DateCode)
				.HasMaxLength(200);
			builder.Property(p => p.Remark)
				.HasMaxLength(1000);
			builder.Property(p => p.UserName)
				.HasMaxLength(20);
			builder.Property(p => p.QN)
				.HasMaxLength(20);
			builder.Property(p => p.IPVersion)
				.HasMaxLength(100);
			builder.Property(p => p.RefDoc)
				.HasMaxLength(50);
			builder.Property(p => p.QNSoftcopy)
				.HasMaxLength(100);
			builder.Property(p => p.BatchDC)
				.HasMaxLength(255);
			builder.Property(p => p.StorageLoc)
				.HasMaxLength(255);
			builder.Property(p => p.OddQtyPerBox)
				.HasMaxLength(100);
			builder.Property(p => p.ReceivingInfo)
				.HasMaxLength(4000);
			builder.Property(p => p.DANo)
				.HasMaxLength(200);
			builder.Property(p => p.LockUser)
				.HasMaxLength(255);
			builder.Property(p => p.DCRequirement)
				.HasMaxLength(4000);


        }
    }
}
