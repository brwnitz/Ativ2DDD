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
    public class LikeMap : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.ToTable("Like"); // NOME DA TABELA

            builder.HasKey(prop => prop.UserId); // CHAVE PRIMARIA
                                                 

            builder.Property(prop => prop.LikeDate)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("LikeDate")
                .HasColumnType("varchar(10)");
            
        }
    }
}
