using MVC.ECommerce.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.ECommerce.BLL.Services.Abstract
{
    public interface ILogging
    {
        /// <summary>
        /// Program hataları loglanır.Kaydedilmek üzere eklenir.
        /// </summary>
        /// <param name="ProgramLogging"></param>
        void ProgramLogging(string errorMessage);
    }
}
