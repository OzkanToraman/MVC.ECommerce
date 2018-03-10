using MVC.ECommerce.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.ECommerce.DAL.Data
{
    public class Log : _EntityBase
    {
        public Log()
        {
            if (Date == null)
                Date = DateTime.Now;
        }

        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
}
