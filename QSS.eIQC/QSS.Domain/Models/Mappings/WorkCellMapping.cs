using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class WorkCellMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<WorkCell, int>
    {        public override void Configure(EntityTypeBuilder<WorkCell> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("WorkCellId");

            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();

            builder.Property(p => p.Description).HasMaxLength(250);
           
        }
    }
}
