﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using OpenAuth.Domain;

namespace OpenAuth.Repository.Models.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CascadeId)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.RootKey)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.RootName)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Category");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CascadeId).HasColumnName("CascadeId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.SortNo).HasColumnName("SortNo");
            this.Property(t => t.RootKey).HasColumnName("RootKey");
            this.Property(t => t.RootName).HasColumnName("RootName");
        }
    }
}
