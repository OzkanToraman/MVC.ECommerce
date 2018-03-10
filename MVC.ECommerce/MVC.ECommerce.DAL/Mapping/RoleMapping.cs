using System;
using MVC.ECommerce.DAL.Data;

namespace MVC.ECommerce.DAL.Mapping
{
    public class RoleMapping:_BaseMapping<Role>
    {
        public RoleMapping()
        {
            Property(x=>x.Name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
        }
    }
}
