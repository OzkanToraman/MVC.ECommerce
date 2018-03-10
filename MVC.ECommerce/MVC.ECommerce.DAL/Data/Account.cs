using System;
namespace MVC.ECommerce.DAL.Data
{
    public class Account:_EntityBase
    {
        public Account()
        {
        }
        public string CardName
        {
            get;
            set;
        }
        public string CardLastName
        {
            get;
            set;
        }
        public string CVC
        {
            get;
            set;
        }
        public string BankAccountNumber
        {
            get;
            set;
        }
        public string IBANNumber
        {
            get;
            set;
        }
        public string BankName
        {
            get;
            set;
        }
        public int BankAccountId
        {
            get;
            set;
        }
        public virtual BankAccount BankAccount
        {
            get;
            set;
        }
    }
}
