using System;
using System.Data.Entity;
using System.Linq;
using MVC.ECommerce.DAL.Data;

namespace MVC.ECommerce.DAL.Mapping
{
    public class ContactMapping:_BaseMapping<Contact>
    {
        public ContactMapping()
        {
            Property(x=>x.ContactBody)
            .IsRequired()
                .IsUnicode()
                .HasColumnType("nvarchar(max)");
            Property(x=>x.ContactTitle)
            .IsOptional()
                .IsUnicode()
                .HasColumnType("nvarchar")
                .HasMaxLength(100);
            Property(x=>x.ContactPhotoPath)
            .IsOptional()
                .HasColumnType("nvarchar(max)");
        }
    }
}
