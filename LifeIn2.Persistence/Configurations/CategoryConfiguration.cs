using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CancuNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CancuNetCore.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.Property(e => e.CategoryId).HasColumnName("CategoryID");

            builder.Property(e => e.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(e => e.Description).HasColumnType("ntext");

            builder.Property(e => e.Picture).HasColumnType("image");
        }
    }
}
