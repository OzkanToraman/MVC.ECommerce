using System;
using MVC.ECommerce.DAL.Data;

namespace MVC.ECommerce.DAL.Mapping
{
    public class ProductPropertyMapping : _BaseMapping<ProductProperty>
    {
        public ProductPropertyMapping()
        {
            Property(x=>x.ProductColor)
                .IsOptional()
                .HasColumnType("nvarchar");
            Property(x=>x.Dimensions)
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(20);
            Property(x=>x.Weight)
                .IsOptional()
                .HasColumnType("decimal");
            Property(x=>x.ProductId)
                .IsRequired()
                .HasColumnType("int");
        }

    }
}
