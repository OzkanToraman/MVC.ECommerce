using System;
using System.ComponentModel.DataAnnotations.Schema;
using MVC.ECommerce.DAL.Data;

namespace MVC.ECommerce.DAL.Mapping
{
    public class UserAreaMapping : _BaseMapping<UserArea>
    {
        public UserAreaMapping()
        {
            Property(x=>x.Name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .IsUnicode()
                .HasColumnOrder(1)
                .HasMaxLength(50);
            Property(x=>x.LastName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .IsUnicode()
                .HasColumnOrder(2)
                .HasMaxLength(50);
            Property(x=>x.Email)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasColumnOrder(3)
                .IsUnicode()
                .HasMaxLength(100);
            Property(x => x.Password)
                .IsRequired()
                .HasColumnOrder(4)
                .HasColumnType("nvarchar(max)");
            Property(x=>x.PasswordConfirm)
                .IsRequired()
                .HasColumnOrder(5)
                .HasColumnType("nvarchar(max)");
            Property(x=>x.IsAccepted)
                .IsRequired()
                .HasColumnType("bit");
            Property(x => x.IsDeleted)
                .IsRequired()
                .HasColumnType("bit");
            Property(x=>x.VerificationCode)
                .IsOptional()
                .HasColumnOrder(6)
                .HasColumnType("nvarchar(max)");
            Property(x=>x.ProfilPic)
                .IsOptional()
                .HasColumnOrder(7)
                .HasColumnType("nvarchar(max)");
            Property(x=>x.RoleId)
                .IsRequired();

        }
    }
}
