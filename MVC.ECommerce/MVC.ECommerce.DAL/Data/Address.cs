using System;
using System.Collections.Generic;

namespace MVC.ECommerce.DAL.Data
{
    public class Address:_EntityBase
    {
        public Address()
        {
        }
        public string StreetName
        {
            get;
            set;
        }
        public string Country
        {
            get;
            set;
        }
        public string Location
        {
            get;
            set;
        }
        public string ZipCode
        {
            get;
            set;
        }
        public virtual ICollection<UserAddress> UserAddress
        {
            get;
            set;
        }
    }
}
