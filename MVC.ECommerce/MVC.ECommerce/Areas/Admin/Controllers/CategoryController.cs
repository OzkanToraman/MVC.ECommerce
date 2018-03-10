using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.ECommerce.Repository._UnitOfWork.Abstract;
using MVC.ECommerce.DAL.Data;
using MVC.ECommerce.BLL.Validations.CategoryValidator;
using FluentValidation.Results;
using MVC.ECommerce.BLL.Services.Concrete;
using MVC.ECommerce.BLL.Services.Abstract;
using MVC.ECommerce.PublicServices.Concrete;
using MVC.ECommerce.PublicServices.Abstract;
using MVC.ECommerce.BLL.Validations.UpCategoryValidation;

namespace MVC.ECommerce.Areas.Admin.Controllers
{
    public class CategoryController : _BaseController
    {
        //listelemek istediğiniz sayıyı giriniz//
        int pageSize = 20;

        public CategoryController(IUnitOfWork uow, IFactory f, ICollect collect) : base(uow, f, collect)
        {
        }

        #region Listeleme Alanı
        public ActionResult List(int? page)
        {
            int currentPage = page ?? 1;
            int totalPage;
            List<Category> model = _uow.GetRepo<Category>().GetList();
            totalPage = (int)Math.Ceiling((decimal)(model.Count() / pageSize));
            var listModel = model.Skip((currentPage - 1) * pageSize).Take(pageSize);

            if (pageSize <= model.Count())
                TempData["ListCount"] = totalPage;
            return View(listModel);
        }

        [HttpPost]
        public ActionResult List(int page)
        {
            var model =
                _uow
                .GetRepo<Category>()
                .GetList()
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            return PartialView("_CategoryList", model);
        } 
        #endregion

        #region Ekleme Alanı
        public ActionResult Add()
        {
            ViewBag.UpCategories = UpCategoryFill();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Category model)
        {

            if (ModelValidate(model).IsValid)
            {
                _uow.GetRepo<Category>().Add(model);
                if (_uow.Commit() > 0)
                    TempData["Msg"] = "Başarıyla eklendi";
                ModelState.Clear();
            }
            else
                _collect.CollectError<CategoryValidator, Category>(model);

            ViewBag.UpCategories = UpCategoryFill();
            return View();
        }
        #endregion

        #region ÜstKategoriCombo Doldur
        private List<SelectListItem> UpCategoryFill()
        {
            List<SelectListItem> cat = new List<SelectListItem>();

            _uow
                .GetRepo<UpCategory>()
                .GetList()
                .ForEach(x => cat
                .Add(new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()

                }));

            return cat;
        }
        #endregion

        #region Silme Alanı

        public ActionResult Delete(int id)
        {
            _uow.GetRepo<Category>().Delete(id);
            _uow.Commit();
            return RedirectToAction("List", "Category");
        }
        #endregion

        #region Güncelleme Alanı

        public ActionResult Update(int id)
        {
            Category model =
                _uow
                .GetRepo<Category>()
                .Where(x => x.Id == id)
                .FirstOrDefault();

            ViewBag.UpCategories = UpCategoryFill();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Category model)
        {
            if (ModelValidate(model).IsValid)
            {
                _uow.GetRepo<Category>().Add(model);
                if (_uow.Commit() > 0)
                    TempData["Msg"] = "Ekleme işlemi başarıyla gerçekleşmiştir.";
                ModelState.Clear();
            }
            else
                _collect.CollectError<CategoryValidator, Category>(model);

            ViewBag.UpCategories = UpCategoryFill();
            return View();
        }
        #endregion

        private ValidationResult ModelValidate(Category model)
        {
            return _f.Create<CategoryValidator, Category>(model);
        }



        [HttpPost]
        public ActionResult Search(string search)
        {

            var model =
                _uow
                .GetRepo<Category>()
                .Where(x => x.Name.Contains(search));


            return PartialView("_CategoryList", model);
        }
    }
}