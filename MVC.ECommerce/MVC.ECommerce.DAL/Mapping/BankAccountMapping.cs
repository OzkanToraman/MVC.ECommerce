using System;
using System.Linq;
using MVC.ECommerce.DAL.Data;

namespace MVC.ECommerce.DAL.Mapping
{
    public class BankAccountMapping:_BaseMapping<BankAccount>
    {
        public BankAccountMapping()
        {
            Property(x=>x.UserAreaId)
            .IsRequired()
                .HasColumnType("int");
            Property(x=>x.BankInfoName)
            .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(100);
            Property(x => x.Account)
            .IsOptional()
                .HasColumnType("nvarchar(max)");
        }
    }
}
