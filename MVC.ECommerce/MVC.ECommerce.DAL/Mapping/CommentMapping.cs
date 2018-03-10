using System;
using MVC.ECommerce.DAL.Data;

namespace MVC.ECommerce.DAL.Mapping
{
    public class CommentMapping:_BaseMapping<Comment>
    {
        public CommentMapping()
        {
            Property(x=>x.CommentBody)
                .IsRequired()
                .IsUnicode()
                .HasColumnType("nvarchar")
                .HasMaxLength(300);
            Property(x=>x.CommentDate)
                .HasColumnType("datetime")
                .IsRequired();
            Property(x=>x.ProductId)
                .HasColumnType("int")
                .IsRequired();
            Property(x=>x.UserAreaId)
                .HasColumnType("int")
                .IsRequired();
        }
    }
}
