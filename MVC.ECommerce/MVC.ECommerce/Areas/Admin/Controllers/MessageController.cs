using MVC.ECommerce.DAL.Data;
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
    public class MessageController : _BaseController
    {

        int pageSize=20;

        public MessageController(IUnitOfWork uow, IFactory f, ICollect collect) : base(uow, f, collect)
        {
        }

        public ActionResult Inbox(int? page)
        {

            int sayfaNo = page ?? 1;

            var model =
                _uow.GetRepo<Message>()
                .Where(x => x.IsDeleted == false)
                .Skip((sayfaNo-1)*pageSize)
                .Take(pageSize);

            return View(model);
        }

        [HttpPost]
        public JsonResult Inbox(string Secilenler)
        {
            string[] model = Secilenler.Split(' ');
            foreach (string item in model)
            {
                _uow.GetRepo<Message>()
                    .GetById(Convert.ToInt32(item))
                    .IsRead = true;
            }
            //_uow.Commit();
            return Json(model);
        }

        public ActionResult TrashBox()
        {
            IEnumerable<Message> model = _uow
                .GetRepo<Message>()
                .Where(x => x.IsDeleted == true);
            return View(model);
        }

        public JsonResult DeleteInbox(string Secilenler)
        {
            if (Secilenler != "")
            {
                string[] model = Secilenler.Split(' ');
                Message msg = new Message();

                foreach (var item in model)
                {
                    msg = _uow.GetRepo<Message>()
                        .GetById(Convert.ToInt32(item));
                    msg.IsDeleted = true;
                    msg.IsRead = true;
                }

                _uow.Commit();
                return Json(model, JsonRequestBehavior.AllowGet);
            }
            else
                return Json("Silinecek öge bulunamadı!", JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteTrash(string Secilenler)
        {
            string[] model = Secilenler.Split(' ');
            foreach (string item in model)
            {
                _uow.GetRepo<Message>()
                    .Delete(Convert.ToInt32(item));
            }
            _uow.Commit();
            return Json(model, JsonRequestBehavior.AllowGet);
        }

    }
}