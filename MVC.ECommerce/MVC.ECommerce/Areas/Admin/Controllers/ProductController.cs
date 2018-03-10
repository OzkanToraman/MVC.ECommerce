using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.ECommerce.BLL.Services.Abstract;
using MVC.ECommerce.PublicServices.Abstract;
using MVC.ECommerce.Repository._UnitOfWork.Abstract;
using MVC.ECommerce.DAL.Data;
using MVC.ECommerce.BLL.Validations.ProductValidator;
using FluentValidation.Results;
using MVC.ECommerce.DAL.Model;
using System.IO;

namespace MVC.ECommerce.Areas.Admin.Controllers
{
    public class ProductController : _BaseController
    {

        int productId;
        int pageSize = 20;
        protected ILogging _log;

        public ProductController(IUnitOfWork uow, IFactory f, ICollect collect, ILogging log) : base(uow, f, collect)
        {
            _log = log;
        }

        #region Ürün Listeleme
        public ActionResult List(int? page)
        {
            int sayfaNo = page ?? 1;  
                
            var model =
                _uow
                .GetRepo<Product>()
                .Where(x => x.IsDeleted == false);
            int totalPage = (int)Math.Ceiling((decimal)(model.Count() / pageSize));

            model
                .Skip(pageSize * (sayfaNo - 1))
                .Take(pageSize);

            if (pageSize <= model.Count())
                TempData["ListCount"] = totalPage;
            return View(model);
        }

        [HttpPost]
        public ActionResult List(int page)
        {


            return PartialView("_ProductList");
        }
        #endregion

        #region Ürün Ekleme Alanı
        public ActionResult Add()
        {
            ViewBag.Categories = CategoryFill();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(ProductAddModel model)
        {

            if (ModelValidate(model.Product).IsValid)
            {
                _uow.GetRepo<Product>().Add(model.Product);
                try
                {
                    if (_uow.Commit() > 0)
                    {
                        TempData["Msg"] = "Başarıyla eklenmiştir.";
                        productId =
                            _uow.GetRepo<Product>()
                            .GetList()
                            .OrderByDescending(x => x.Id)
                            .FirstOrDefault()
                            .Id;
                        ModelState.Clear();

                        if (model.UploadedProductPic != null)
                        {
                            foreach (HttpPostedFileBase item in model.UploadedProductPic)
                            {
                                string uniqueFileName = Guid.NewGuid().ToString();
                                string extention      = Path.GetExtension(item.FileName);
                                string fullFileName   = HttpContext.Server.MapPath("/Media/Images/" + uniqueFileName + extention);
                                item.SaveAs(fullFileName);

                                model.ProductPics.ProductId = productId;
                                model.ProductPics.Name      = uniqueFileName + extention;
                                model.ProductPics.Path      = "/Media/Images/" + uniqueFileName + extention;

                                ProductPics pics = new ProductPics()
                                {
                                    ProductId = model.ProductPics.ProductId,
                                    Name      = model.ProductPics.Name,
                                    Path      = model.ProductPics.Path
                                };

                                _uow.GetRepo<ProductPics>()
                                    .Add(pics);
                            }

                            _uow.Commit();
                        }
                    }
                    else
                    {
                        TempData["Msg"] = "Bir hata oluştu!";
                        return View();
                    }
                }
                catch (Exception ex)
                {
                    _log.ProgramLogging(ex.Message);

                };

                return View();
            }
            else
                _collect.CollectError<ProductValidator, Product>(model.Product);
            ViewBag.Categories = CategoryFill();
            return View();
        }
        #endregion

        #region Ürün Güncelleme Alanı
        public ActionResult Update(int id)
        {
            Product model =
                _uow.GetRepo<Product>()
                .GetById(id);

            return View(model);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(ProductAddModel model)
        {
            if (ModelValidate(model.Product).IsValid)
            {
                _uow.GetRepo<Product>().Update(model.Product);
                try
                {
                    if (_uow.Commit() > 0)
                    {
                        TempData["Msg"] = "Başarıyla güncellenmiştir.";
                        ModelState.Clear();
                    }
                }
                catch (Exception ex)
                {
                    TempData["Msg"] = "Bir hata oluştu";
                    _log.ProgramLogging(ex.Message);
                    _uow.Commit();
                }

            }
            else
                _collect.CollectError<ProductValidator, Product>(model.Product);

            return View();
        }
        #endregion

        #region Ürün Silme Alanı
        public ActionResult Delete(int id)
        {
            _uow.GetRepo<Product>().Delete(id);
            _uow.Commit();

            return RedirectToAction("List");
        }
        #endregion

        #region Model Doğrulama Fonksiyonu
        private ValidationResult ModelValidate(Product model)
        {
            return _f.Create<ProductValidator, Product>(model);
        }
        #endregion

        #region Kategori Doldurma
        private List<SelectListItem> CategoryFill()
        {
            List<SelectListItem> cat = new List<SelectListItem>();

            _uow
                .GetRepo<Category>()
                .GetList()
                .ForEach(x => cat.Add
                (
                    new SelectListItem
                    {
                        Text = x.Name,
                        Value = x.Id.ToString()
                    })
                 );

            return cat;
        }
        #endregion

    }
}
