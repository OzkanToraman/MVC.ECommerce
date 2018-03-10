using FluentValidation;
using MVC.ECommerce.DAL.Context;
using MVC.ECommerce.DAL.Data;
using MVC.ECommerce.Repository._UnitOfWork.Abstract;
using MVC.ECommerce.Repository._UnitOfWork.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.ECommerce.BLL.Validations.UpCategoryValidation
{
    public class UpCategoryValidator : _BaseValidator<UpCategory>
    {

        protected IUnitOfWork _uow;

        public UpCategoryValidator()
        {
            if (_uow == null)
                _uow = new UnitOfWork(new ECommerceContext());


            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adı boş geçilemez!");
            RuleFor(x => x.Name).Must(IsExist).WithMessage("Böyle bir kategori adı mevcuttur!");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("50 karakterden fazla yazamazsınız!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Bu alan boş geçilemez!");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("200 karakterden fazla yazamazsınız!");
        }

        bool IsExist(string Ad)
        {
            bool sonuc = Convert.ToBoolean(_uow.GetRepo<UpCategory>().Where(x => x.Name == Ad).Count());
            if (sonuc)
                return false;
            return true;
        }
    }
}
