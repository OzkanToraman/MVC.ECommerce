using MVC.ECommerce.DAL.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Type> a = new List<Type>()
        {
            typeof(AboutMapping),
            typeof(ProductMapping),
        };


            a.ForEach(x => System.Console.WriteLine(x.ToString()));
        }



    }
}
