using System;
using MVC.ECommerce.DAL.Data;

namespace MVC.ECommerce.DAL.Mapping
{
    public class UserAddressMapping:_BaseMapping<UserAddress>
    {
        public UserAddressMapping()
        {
            Property(x=>x.UserAreaId)
            .IsRequired()
                .HasColumnType("int");
            Property(x => x.AddressId)
            .IsRequired()
                .HasColumnType("int");
            Property(x=>x.AddressName)
            .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
        }
    }
}
