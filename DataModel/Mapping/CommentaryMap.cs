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
    public class CommentaryMap : IEntityTypeConfiguration<Commentary>
    {
        public void Configure(EntityTypeBuilder<Commentary> builder)
        {
            builder.ToTable("Commentary"); // NOME DA TABELA

            builder.HasKey(prop => prop.UserId); // CHAVE PRIMARIA
            

            builder.Property(prop => prop.CommentDate)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("CommentDate")
                .HasColumnType("varchar(10)");

            builder.Property(prop => prop.CommentDesc)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("CommentDesc")
                .HasColumnType("varchar(400)");

        }
    }
}
