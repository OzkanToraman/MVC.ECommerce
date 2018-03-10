using MVC.ECommerce.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.ECommerce.DAL.Mapping
{
    public class MessageMapping:_BaseMapping<Message>
    {
        public MessageMapping()
        {
            Property(x => x.MessageTitle)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsUnicode()
                .IsRequired();
            Property(x => x.MessageBody)
                .HasColumnType("nvarchar")
                .HasMaxLength(300)
                .IsUnicode()
                .IsRequired();
            Property(x => x.MessageFrom)
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsUnicode()
                .IsRequired();
            Property(x => x.IsRead)
                .HasColumnType("bit")
                .IsRequired();
            Property(x => x.IsDeleted)
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}
