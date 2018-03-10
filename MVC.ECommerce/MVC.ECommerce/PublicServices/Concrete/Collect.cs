using FluentValidation;
using MVC.ECommerce.Areas.Admin.Controllers;
using MVC.ECommerce.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.ECommerce.Repository._UnitOfWork.Abstract;
using System.Web.Mvc;
using MVC.ECommerce.BLL.Services.Abstract;
using MVC.ECommerce.PublicServices.Abstract;

namespace MVC.ECommerce.PublicServices.Concrete
{
    public class Collect : ICollect
    {
        protected IFactory _f;
        protected Controller _c; 

        public Collect(IFactory f)
        {
            _f = f;
        }

        public void CollectError<T,TModel>(TModel model)
            where T : AbstractValidator<TModel>, new()
            where TModel : _EntityBase,new()
        {
            _f.Create<T, TModel>(model)
                .Errors
                .ToList()
                .ForEach(x => _c.ModelState.AddModelError
                (
                    x.PropertyName,
                    x.ErrorMessage
                ));
        }


    }
}