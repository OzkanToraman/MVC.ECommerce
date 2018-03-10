using System;
using System.Linq;
using MVC.ECommerce.DAL.Data;

namespace MVC.ECommerce.DAL.Mapping
{
    public class AboutMapping:_BaseMapping<About>
    {
        public AboutMapping()
        {
            Property(x=>x.AboutBody)
                .IsRequired()
                .IsUnicode()
                .HasColumnType("nvarchar(max)");
            Property(x=>x.AboutTitle)
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
            Property(x=>x.AboutPhotoPath)
            .IsOptional()
                .HasColumnType("nvarchar(max)");
        }
    }
}
