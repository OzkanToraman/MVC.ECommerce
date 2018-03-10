using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.ECommerce.BLL.Services.Abstract;
using MVC.ECommerce.PublicServices.Abstract;
using MVC.ECommerce.Repository._UnitOfWork.Abstract;

namespace MVC.ECommerce.Areas.Admin.Controllers
{
    public class HesapController : _BaseController
    {
        public HesapController(IUnitOfWork uow, IFactory f, ICollect collect) : base(uow, f, collect)
        {
        }


        // GET: Admin/Hesap
        public ActionResult Index()
        {
            return View();
        }
    }
}