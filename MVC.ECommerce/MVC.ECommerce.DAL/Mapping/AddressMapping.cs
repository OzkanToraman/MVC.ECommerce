using System;
using MVC.ECommerce.DAL.Data;

namespace MVC.ECommerce.DAL.Mapping
{
    public class AddressMapping:_BaseMapping<Address>
    {
        public AddressMapping()
        {
            Property(x=>x.Country)
                .IsRequired()
                .HasColumnType("nvarchar")
                .IsUnicode()
                .HasMaxLength(50);
            Property(x=>x.Location)
                .IsRequired()
                .HasColumnType("nvarchar")
                .IsUnicode()
                .HasMaxLength(50);
            Property(x=>x.StreetName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .IsUnicode()
                .HasMaxLength(200);
            Property(x=>x.ZipCode)
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(10);
        }
    }
}
