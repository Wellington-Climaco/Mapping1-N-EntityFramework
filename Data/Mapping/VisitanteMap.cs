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
    public class VisitanteMap : IEntityTypeConfiguration<Visitante>
    {
        public void Configure(EntityTypeBuilder<Visitante> builder)
        {
            builder.ToTable("Visitante");
            
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Cpf)
                .IsRequired()
                .HasColumnName("Cpf")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);

            builder.HasIndex(x => x.Cpf, "IX_Visitante_Cpf")
                .IsUnique();

            builder.HasOne(x => x.Morador)
                .WithMany(x => x.Visitantes)
                .HasConstraintName("FK_Visitante_Morador")
                .OnDelete(DeleteBehavior.Cascade);
                

        }
    }
}
