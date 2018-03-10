using FluentValidation;
using MVC.ECommerce.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.ECommerce.PublicServices.Abstract
{
    public interface ICollect
    {
        void CollectError<T, TModel>(TModel model)
            where T : AbstractValidator<TModel>, new()
            where TModel : _EntityBase, new();
    }
}
