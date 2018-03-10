using FluentValidation;
using MVC.ECommerce.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.ECommerce.BLL.Validations
{
    public class _BaseValidator<T> : AbstractValidator<T> where T : _EntityBase , new()
    {
        public _BaseValidator()
        {

        }
    }
}
