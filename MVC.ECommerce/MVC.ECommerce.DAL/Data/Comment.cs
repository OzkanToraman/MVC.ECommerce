using System;
namespace MVC.ECommerce.DAL.Data
{
    public class Comment:_EntityBase
    {
        public Comment()
        {
            CommentDate = DateTime.Now;
            IsDeleted = false;
        }
        public string CommentBody
        {
            get;
            set;
        }
        public DateTime CommentDate
        {
            get;
            set;
        }
        public bool IsDeleted
        {
            get;
            set;
        }
        public int UserAreaId
        {
            get;
            set;
        }
        public int ProductId
        {
            get;
            set;
        }
        public virtual UserArea UserArea
        {
            get;
            set;
        }
        public virtual Product Product
        {
            get;
            set;
        }
    }
}
