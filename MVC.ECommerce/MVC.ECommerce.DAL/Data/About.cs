using System;
using System.Collections.Generic;

namespace MVC.ECommerce.DAL.Data
{
    public class About:_EntityBase
    {
        public About()
        {
        }

        public string AboutBody
        {
            get;
            set;
        }
        public string AboutTitle
        {
            get;
            set;
        }
        public string EmailAddress
        {
            get;
            set;
        }
        public string AboutPhotoPath
        {
            get;
            set;
        }
    }
}
