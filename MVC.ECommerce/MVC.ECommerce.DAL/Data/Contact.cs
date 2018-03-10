using System;
using System.Collections.Generic;

namespace MVC.ECommerce.DAL.Data
{
    public class Contact:_EntityBase
    {
        public Contact()
        {
        }

        public string ContactBody
        {
            get;
            set;
        }

        public string ContactTitle
        {
            get;
            set;
        }

        public string ContactPhotoPath
        {
            get;
            set;
        }
    }

}
