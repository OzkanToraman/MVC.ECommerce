using System;
using System.Collections.Generic;

namespace MVC.ECommerce.DAL.Data
{
    public class BankAccount : _EntityBase
    {
        public BankAccount()
        {
        }

        public int UserAreaId
        {
            get;
            set;
        }

        public string BankInfoName
        {
            get;
            set;
        }

        public string Account
        {
            get;
            set;
        }

        public virtual UserArea UserArea
        {
            get;
            set;
        }
        public virtual ICollection<Account> Accounts
        {
            get;
            set;
        }
    }
}
