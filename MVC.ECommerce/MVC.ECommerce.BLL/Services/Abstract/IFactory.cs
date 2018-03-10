using FluentValidation;
using FluentValidation.Results;
using MVC.ECommerce.BLL.Validations;
using MVC.ECommerce.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.ECommerce.BLL.Services.Abstract
{
    public interface IFactory
    {
        ValidationResult Create<T,Tmodel>(Tmodel model) 
            where T : AbstractValidator<Tmodel>,new()
            where Tmodel : _EntityBase,new();
    }
}
