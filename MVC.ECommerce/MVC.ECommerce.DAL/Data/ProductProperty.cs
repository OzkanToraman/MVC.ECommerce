using System;
namespace MVC.ECommerce.DAL.Data
{
    public class ProductProperty: _EntityBase 
    {

        public ProductProperty()
        {
        }

        public int ProductId
        {
            get;
            set;
        }

        public string ProductColor
        {
            get;
            set;
        }

        public decimal Weight
        {
            get;
            set;
        }

        public string Dimensions
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
