
using FluentValidation.Results;
using MVC.ECommerce.BLL.Services.Abstract;
using MVC.ECommerce.BLL.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MVC.ECommerce.DAL.Data;

namespace MVC.ECommerce.BLL.Services.Concrete
{
    public class Factory : IFactory
    {
        public ValidationResult Create<T, Tmodel>(Tmodel model)
            where T : AbstractValidator<Tmodel>, new()
            where Tmodel : _EntityBase, new()
        {
            return new T().Validate(model);
        }
    }
}
