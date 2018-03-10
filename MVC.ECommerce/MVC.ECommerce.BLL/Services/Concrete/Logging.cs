using MVC.ECommerce.BLL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.ECommerce.DAL.Data;
using MVC.ECommerce.Repository._UnitOfWork.Abstract;

namespace MVC.ECommerce.BLL.Services.Concrete
{
    public class Logging : ILogging
    {
        protected IUnitOfWork _uow;

        public Logging(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void ProgramLogging(string errorMessage)
        {
            Log log = new Log();

            log.Date = DateTime.Now;
            log.Message = errorMessage;
            

            _uow.GetRepo<Log>().Add(log);

        }
    }
}
