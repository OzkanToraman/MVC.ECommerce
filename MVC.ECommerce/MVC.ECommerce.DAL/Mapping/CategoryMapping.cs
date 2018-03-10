using System;
using MVC.ECommerce.DAL.Data;

namespace MVC.ECommerce.DAL.Mapping
{
    public class CategoryMapping:_BaseMapping<Category>
    {
        public CategoryMapping()
        {
            Property(x=>x.Name)
                .IsRequired()
                .IsUnicode()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
            Property(x=>x.Description)
                .IsOptional()
                .IsUnicode()
                .HasColumnType("nvarchar")
                .HasMaxLength(200);
            Property(x=>x.UpCategoryId)
                .HasColumnType("int")
                .IsRequired();

        }
    }
}
