using System;
using MVC.ECommerce.DAL.Data;

namespace MVC.ECommerce.DAL.Mapping
{
    public class UpCategoryMapping:_BaseMapping<UpCategory>
    {
        public UpCategoryMapping()
        {
            Property(x=>x.Name)
                .IsRequired()
                .IsUnicode()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
            Property(x=>x.Description)
                .IsRequired()
                .IsUnicode()
                .HasColumnType("nvarchar")
                .HasMaxLength(200);
        }
    }
}
