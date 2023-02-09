/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map AdminCertification entity model with Database table and bootstrap
    /// </summary>
    public class AdminCertificationMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<AdminCertification,int>
    {
		/// <summary>
        /// Binds Database column AdminCertificationId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<AdminCertification> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("AdminCertificationId");

			builder.Property(p => p.Number)
				.IsRequired()
				.HasMaxLength(15);
			builder.Property(p => p.Name)
				.IsRequired()
				.HasMaxLength(50);
			builder.Property(p => p.Description)
				.IsRequired()
				.HasMaxLength(150);
			builder.Property(p => p.AssessmentBodyId)
				.IsRequired()
				.HasMaxLength(15);
			builder.Property(p => p.AssessmentBodyName)
				.IsRequired()
				.HasMaxLength(50);
			builder.Property(p => p.CertificateStartDate)
				.IsRequired();
			builder.Property(p => p.CertificateStartDate).HasDefaultValueSql("((CURRENT_TIMESTAMP))");

			builder.Property(p => p.CertificateEndDate)
				.IsRequired();
			builder.Property(p => p.CertificateEndDate).HasDefaultValueSql("((CURRENT_TIMESTAMP))");



        }
    }
}
