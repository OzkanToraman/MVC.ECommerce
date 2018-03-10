using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.ECommerce.DAL.Data
{
    public class Message : _EntityBase
    {
        public Message()
        {
            IsRead = false;
            IsDeleted = false;
        }
        public string MessageTitle { get; set; }
        public string MessageBody { get; set; }
        public int? UserAreaId { get; set; }
        public string MessageFrom { get; set; }
        public DateTime MessageDate { get; set; }
        public bool IsRead { get; set; }
        public bool IsDeleted { get; set; }

        public virtual UserArea User { get; set; }
    }
    
}
