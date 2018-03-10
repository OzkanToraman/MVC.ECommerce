using MVC.ECommerce.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.ECommerce.DAL.Mapping
{
    public class LogMapping : _BaseMapping<Log>
    {
        public LogMapping()
        {
            Property(x => x.Message)
                .HasColumnType("nvarchar(max)")
                .IsRequired();
        }
    }
}
