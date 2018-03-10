using System;
using System.Linq;
using MVC.ECommerce.DAL.Data;

namespace MVC.ECommerce.DAL.Mapping
{
    public class ProductPicMapping:_BaseMapping<ProductPics>
    {
        public ProductPicMapping()
        {
            Property(x=>x.Path)
                     .IsOptional()
                .HasColumnType("nvarchar(max)");
        }
    }
}
