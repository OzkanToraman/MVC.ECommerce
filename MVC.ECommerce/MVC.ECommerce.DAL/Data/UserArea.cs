using System;
using System.Collections.Generic;

namespace MVC.ECommerce.DAL.Data
{
    public class UserArea:_EntityBase
    {
        public UserArea()
        {
            IsDeleted = false;
            IsAccepted = false;
        }

        public string Name
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public string PasswordConfirm
        {
            get;
            set;
        }

        public string VerificationCode
        {
            get;
            set;
        }

        public bool IsDeleted
        {
            get;
            set;
        }

        public bool IsAccepted
        {
            get;
            set;
        }

        public string ProfilPic
        {
            get;
            set;
        }

        public int RoleId
        {
            get;
            set;
        }

        public virtual Role Role
        {
            get;
            set;
        }

        public virtual ICollection<BankAccount> BankAccounts
        {
            get;
            set;
        }

        public virtual ICollection<UserAddress> UserAddresses
        {
            get;
            set;
        }
        public virtual ICollection<Comment> Comments
        {
            get;
            set;
        }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
