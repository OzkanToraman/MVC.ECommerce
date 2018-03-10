using System;
using System.Collections.Generic;

namespace MVC.ECommerce.DAL.Data
{
    public class ProductPics : _EntityBase
    {
        public ProductPics()
        {
        }

        public int ProductId
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Path
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
