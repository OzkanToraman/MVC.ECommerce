using System;
using MVC.ECommerce.DAL.Data;

namespace MVC.ECommerce.DAL.Mapping
{
    public class ProductMapping:_BaseMapping<Product>
    {
        public ProductMapping()
        {
            Property(x=>x.Name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(200)
                .IsUnicode();
            Property(x=>x.ProductCode)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
            Property(x=>x.Title)
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
            Property(x=>x.UnitsInStock)
                .IsRequired()
                .HasColumnType("int");
            Property(x=>x.Price)
                .IsRequired()
                .HasColumnType("decimal");
            Property(x=>x.IsDeleted)
                .HasColumnType("bit");
            Property(x=>x.Description)
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(250);
        }


    }
}
