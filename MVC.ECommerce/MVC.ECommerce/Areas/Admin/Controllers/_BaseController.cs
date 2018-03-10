using MVC.ECommerce.BLL.Services.Abstract;
using MVC.ECommerce.PublicServices.Abstract;
using MVC.ECommerce.Repository._UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.ECommerce.Areas.Admin.Controllers
{
    public class _BaseController : Controller
    {
        protected IUnitOfWork _uow;
        protected IFactory _f;
        protected ICollect _collect;

        public _BaseController(IUnitOfWork uow, IFactory f, ICollect collect)
        {
            _uow = uow;
            _f = f;
            _collect = collect;
        }
    }
}