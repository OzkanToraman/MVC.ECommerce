using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.ECommerce.Repository._UnitOfWork.Abstract;
using MVC.ECommerce.DAL.Data;
using MVC.ECommerce.BLL.Validations.UpCategoryValidation;
using MVC.ECommerce.BLL.Services.Abstract;
using MVC.ECommerce.PublicServices.Abstract;
using FluentValidation.Results;

namespace MVC.ECommerce.Areas.Admin.Controllers
{
    public class UpCategoryController : _BaseController
    {
        public UpCategoryController(IUnitOfWork uow, IFactory f, ICollect collect) : base(uow, f, collect)
        {
        }

        public ActionResult List()
        {
            IEnumerable<UpCategory> model =
                _uow
                .GetRepo<UpCategory>()
                .GetList();

            return View(model);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(UpCategory model)
        {
            if (ModelValidate(model).IsValid)
            {
                _uow.GetRepo<UpCategory>().Add(model);
                if (_uow.Commit() > 0)
                    TempData["Msg"] = "İşlem başarıyla gerçekleşmiştir.";
                ModelState.Clear();
            }
            else
                _collect.CollectError<UpCategoryValidator, UpCategory>(model);

            return View();
        }

        public ActionResult Update(int id)
        {
            UpCategory model =
                _uow
                .GetRepo<UpCategory>()
                .Where(x => x.Id == id)
                .FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(UpCategory model)
        {

            if (ModelValidate(model).IsValid)
            {
                _uow
                    .GetRepo<UpCategory>()
                    .Update(model);
                if (_uow.Commit() > 0)
                    TempData["Msg"] = "Başarıyla güncellenmiştir.";
            }
            else
                _collect.CollectError<UpCategoryValidator, UpCategory>(model);

            return View();
        }

        public ActionResult Delete(int id)
        {
            _uow
                .GetRepo<UpCategory>()
                .Delete(id);
            _uow.Commit();

            return RedirectToAction("List");
        }

        private ValidationResult ModelValidate(UpCategory model)
        {
            return _f.Create<UpCategoryValidator, UpCategory>(model);
        }

    }
}