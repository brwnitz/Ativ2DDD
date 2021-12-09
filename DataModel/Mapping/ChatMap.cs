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
    public class ChatMap : IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder.ToTable("Chat"); // NOME DA TABELA

            builder.HasKey(prop => prop.ChatId); // CHAVE PRIMARIA            
            

            builder.Property(prop => prop.Message)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("CommentDate")
                .HasColumnType("varchar(600)");

        }
    }
}
