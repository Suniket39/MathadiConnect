using MathadiConnect.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathadiConnect.Infrastructure.EntityConfigurations
{
    public class CommonEntityConfiguration
    {
        public static void Configure<T>(EntityTypeBuilder<T> builder) where T : CommonEntity
        {
            builder.Property(x => x.CreatedBy).IsRequired(false).HasMaxLength(30);
            builder.Property(x => x.CreatedDate).IsRequired(true).HasColumnType("date");
            builder.Property(x => x.ModifiedBy).IsRequired(false).HasMaxLength(30);
            builder.Property(x => x.ModifiedDate).IsRequired(false).HasColumnType("date");
        }
    }
}
