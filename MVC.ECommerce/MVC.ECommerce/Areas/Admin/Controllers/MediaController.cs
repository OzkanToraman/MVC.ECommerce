using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.ECommerce.BLL.Services.Abstract;
using MVC.ECommerce.PublicServices.Abstract;
using MVC.ECommerce.Repository._UnitOfWork.Abstract;
using MVC.ECommerce.DAL.Data;
using System.IO;

namespace MVC.ECommerce.Areas.Admin.Controllers
{
    public class MediaController : _BaseController
    {
        int pageSize = 5;
        protected ILogging _log;

        public MediaController(IUnitOfWork uow, IFactory f, ICollect collect,ILogging log) : base(uow, f, collect)
        {
            _log = log;
        }

        IEnumerable<MediaUpload> model = new List<MediaUpload>();
        // GET: Admin/Media
        public ActionResult FileManager(int? Page)
        {
            int _sayfaNo = Page ?? 1;
            ViewBag.currentPage = _sayfaNo;
            model = _uow.GetRepo<MediaUpload>()
                .GetList()
                .OrderByDescending(x => x.Id)
                .Skip((_sayfaNo - 1) * pageSize)
                .Take(pageSize);
            return View(model);
        }

        [HttpPost]
        public ActionResult FileManager(int Page)
        {
            var model = _uow.GetRepo<MediaUpload>()
                .GetList()
                .OrderByDescending(x => x.Id)
                .Skip((Page - 1) * 5)
                .Take(5);

            return PartialView("_FileManagerTable", model);
        }


        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload(IEnumerable<HttpPostedFileBase> items)
        {
            MediaUpload media = new MediaUpload();

            foreach (HttpPostedFileBase item in items)
            {
                string uniqueFileName = Guid.NewGuid().ToString();
                string extention = Path.GetExtension(item.FileName);
                string fullFileName = HttpContext.Server.MapPath("/Media/Images/" + uniqueFileName + extention);
                item.SaveAs(fullFileName);
                media.Name = uniqueFileName + extention;
                media.Path = "/Media/Images/" + uniqueFileName + extention;

                _uow.GetRepo<MediaUpload>()
                    .Add(media);
            }
            try
            {
                if (_uow.Commit() > 0)
                    return RedirectToAction("FileManager");
                else
                {
                    TempData["Msg"] = "Bir hata oluştu!";
                    return View();
                }
            }
            catch(Exception ex)
            {
                _log.ProgramLogging(ex.Message);
                
                _uow.Commit();
                TempData["Msg"] = "Bir hata oluştu!";
                return View();
            }
        }

        public JsonResult DeleteUpload(string Secilenler)
        {
            string[] model = Secilenler.Split(' ');

            foreach (string item in model)
            {
                _uow.GetRepo<MediaUpload>()
                    .Delete(Convert.ToInt32(item));
            }
            _uow.Commit();

            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}