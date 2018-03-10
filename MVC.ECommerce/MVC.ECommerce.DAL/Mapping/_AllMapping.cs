using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace MVC.ECommerce.DAL.Mapping
{
    public class _AllMapping
    {
        public _AllMapping()
        {
        }

        public static T Factory<T>() where T:class,new()
        {
            return new T();    
        }
    }
}
