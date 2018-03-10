using System;
using System.Collections.Generic;

namespace MVC.ECommerce.DAL.Data
{
    public class Category:_EntityBase
    {
        public Category()
        {
        }

        public string Name
        {
            get;
            set;
        }

        public int UpCategoryId
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public virtual UpCategory UpCategory
        {
            get;
            set;
        }

        public virtual ICollection<Product> Products
        {
            get;
            set;
        }
    }

}
