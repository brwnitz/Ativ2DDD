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
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Post"); // NOME DA TABELA

            builder.HasKey(prop => prop.UserId); // CHAVE PRIMARIA 

            builder.Property(prop => prop.PostDate)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired() 
                .HasColumnName("PostDate") 
                .HasColumnType("varchar(10)");           

            builder.Property(prop => prop.Commentaries)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Commentaries")
                .HasColumnType("varchar(200)");

            builder.Property(prop => prop.Description)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Description")
                .HasColumnType("varchar(300)");
        }
    }
}
