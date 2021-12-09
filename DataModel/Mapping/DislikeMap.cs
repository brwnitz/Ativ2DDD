using DomainModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Mapping
{
    public class DislikeMap : IEntityTypeConfiguration<Dislike>
    {
        public void Configure(EntityTypeBuilder<Dislike> builder)
        {
            builder.ToTable("Dislike"); // NOME DA TABELA

            builder.HasKey(prop => prop.UserId); // CHAVE PRIMARIA
            

            builder.Property(prop => prop.DislikeDate)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("DislikeDate")
                .HasColumnType("varchar(10)");

        }
    }
}
