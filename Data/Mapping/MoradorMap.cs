using DbWithEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbWithEntityFramework.Data.Mapping
{
    public class MoradorMap : IEntityTypeConfiguration<Morador>
    {
        public void Configure(EntityTypeBuilder<Morador> builder)
        {
            builder.ToTable("Morador");

            builder.HasKey(x=>x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasColumnName("Name").HasColumnType("VARCHAR").HasMaxLength(80);

            builder.Property(x => x.Cpf).IsRequired().HasColumnName("CPF").HasColumnType("VARCHAR").HasMaxLength(100);

            builder.Property(x => x.DataNascimento).IsRequired().HasColumnName("Datanasc").HasColumnType("SMALLDATETIME").HasMaxLength(60);

            builder.HasIndex(x => x.Cpf,"IX_Morador_Cpf")
                .IsUnique();

        }
    }
}
