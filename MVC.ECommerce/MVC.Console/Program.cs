using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MVC.ECommerce.DAL.Mapping;

namespace MVC.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            merhaba m = new merhaba();
            var t = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsClass && x.Name.Contains("mapping")).ToArray();


            foreach (var item in t)
            {
                Activator.CreateInstance(item);
            }

            System.Console.ReadKey();


        }

        public class categorymapping
        {
            public categorymapping()
            {

            }

        }

        public class productmapping
        {
            public productmapping()
            {

            }
        }

        public class merhaba
        {
            public T Create<T>() where T : class, new()
            {
                return new T();
            }

        }
    }
}
