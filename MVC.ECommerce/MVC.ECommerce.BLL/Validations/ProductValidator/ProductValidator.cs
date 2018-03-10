using FluentValidation;
using MVC.ECommerce.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.ECommerce.BLL.Validations.ProductValidator
{
    public class ProductValidator: _BaseValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adı boş geçilemez!");
            RuleFor(x => x.Name).MaximumLength(200).WithMessage("200 karakteri geçtiniz!");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("50 karakteri geçtiniz!");
            RuleFor(x => x.Description).MaximumLength(250).WithMessage("250 karakteri geçtiniz!");
            RuleFor(x => x.ProductCode).NotEmpty().WithMessage("Ürün kodu boş geçilemez!");
            RuleFor(x => x.ProductCode).MaximumLength(50).WithMessage("50 karakteri geçtiniz!");
            RuleFor(x => x.Category.Name).NotEmpty().WithMessage("Kategori adı boş geçilemez");
        }
    }
}
