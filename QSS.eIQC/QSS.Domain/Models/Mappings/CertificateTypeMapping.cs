/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map CertificateType entity model with Database table and bootstrap
    /// </summary>
    public class CertificateTypeMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<CertificateType,int>
    {
		/// <summary>
        /// Binds Database column CertificateTypeId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<CertificateType> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("CertificateTypeId");

			builder.HasIndex(p => p.Name)
				.HasName("UK_CertificateType_Name")
				.IsUnique();

			builder.Property(p => p.Name)
				.IsRequired()
				.HasMaxLength(50);


        }
    }
}
