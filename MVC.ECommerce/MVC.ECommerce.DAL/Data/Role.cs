using System;
using System.Collections.Generic;

namespace MVC.ECommerce.DAL.Data
{
    public class Role : _EntityBase
    {
        public Role()
        {
        }

        public string Name
        {
            get;
            set;
        }

        public virtual ICollection<UserArea> Users
        {
            get;
            set;
        }
    }
}
