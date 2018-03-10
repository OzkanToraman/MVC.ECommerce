using System;
using System.Collections.Generic;

namespace MVC.ECommerce.DAL.Data
{
    public class Product: _EntityBase
    {
        public Product()
        {
            IsDeleted = false;
            UnitsInStock = 0;
        }

        public string Name
        {
            get;
            set;
        }

        public int CategoryId
        {
            get;
            set;
        }

        public string ProductCode
        {
            get;
            set;
        }

        public int UnitsInStock
        {
            get;
            set;
        }

        public decimal Price
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public bool IsDeleted
        {
            get;
            set;
        }

        public DateTime StockUpDate
        {
            get;
            set;
        }

        public virtual Category Category
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public virtual ICollection<ProductProperty> ProductProperties
        {
            get;
            set;
        }

        public virtual ICollection<ProductPics> ProductPics
        {
            get;
            set;
        }
        public virtual ICollection<Comment> Comments
        {
            get;
            set;
        }
    }

}
