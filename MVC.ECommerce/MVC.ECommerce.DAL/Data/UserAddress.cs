using System;
namespace MVC.ECommerce.DAL.Data
{
    public class UserAddress:_EntityBase
    {
        public UserAddress()
        {
        }
        public string AddressName
        {
            get;
            set;
        }
        public int UserAreaId
        {
            get;
            set;
        }
        public int AddressId
        {
            get;
            set;
        }
        public virtual UserArea UserArea
        {
            get;
            set;
        }
        public virtual Address Address
        {
            get;
            set;
        }
    }
}
