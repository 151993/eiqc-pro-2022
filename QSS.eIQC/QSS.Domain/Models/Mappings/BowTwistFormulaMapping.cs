/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map BowTwistFormula entity model with Database table and bootstrap
    /// </summary>
    public class BowTwistFormulaMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<BowTwistFormula,int>
    {
		/// <summary>
        /// Binds Database column BowTwistFormulaId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<BowTwistFormula> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("BowTwistFormulaId");

			builder.Property(p => p.Name)
				.HasMaxLength(50);
			builder.Property(p => p.Equation)
				.HasMaxLength(255);


        }
    }
}
