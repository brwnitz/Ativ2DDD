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
    public class NoticesMap : IEntityTypeConfiguration<Notices>
    {
        public void Configure(EntityTypeBuilder<Notices> builder)
        {
            builder.ToTable("Notices"); // NOME DA TABELA

            builder.HasKey(prop => prop.Id); // CHAVE PRIMARIA 

            builder.Property(prop => prop.PublicationDate)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("PubDate")
                .HasColumnType("varchar(10)");

            builder.Property(prop => prop.Type)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Type")
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.EventDate)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("EventDate")
                .HasColumnType("varchar(10)");

            builder.Property(prop => prop.PubDescription)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("PubDesc")
                .HasColumnType("varchar(400)");

            builder.Property(prop => prop.Category)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Category")
                .HasColumnType("varchar(20)");
        }
    }
}
