using System;
using System.Collections.Generic;

namespace MVC.ECommerce.DAL.Data
{
    public class UpCategory:_EntityBase
    {
        public UpCategory()
        {
        }

        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public virtual ICollection<Category> Categories
        {
            get;
            set;
        }


    }
}
