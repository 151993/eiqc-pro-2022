/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormType entity model with Database table and bootstrap
    /// </summary>
    public class FormTypeMapping : EntityTypeConfigurationWithUpdateUserAudit<FormType,int>
    {
		/// <summary>
        /// Binds Database column FormTypeId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormType> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormTypeId");

        }
    }
}
