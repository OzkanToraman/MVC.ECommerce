using System;
using MVC.ECommerce.DAL.Data;

namespace MVC.ECommerce.DAL.Mapping
{
    public class AccountMapping:_BaseMapping<Account>
    {
        public AccountMapping()
        {
            Property(x=>x.BankAccountId)
            .IsRequired()
                .HasColumnType("int");
            Property(x=>x.CardName)
            .IsRequired()
                .IsUnicode()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
            Property(x=>x.CardLastName)
            .IsRequired()
                .IsUnicode()
                .HasColumnType("nvarchar")
                .HasMaxLength(100);
            Property(x=>x.CVC)
            .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(3);
            Property(x=>x.BankAccountNumber)
            .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(25);
            Property(x => x.IBANNumber)
            .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(25);
            Property(x=>x.CardName)
            .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
            
        }
    }
}
