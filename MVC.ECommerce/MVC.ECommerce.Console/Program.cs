using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace MVC.ECommerce.Console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<object> className = new List<object>();
            Assembly asm = Assembly.GetExecutingAssembly();
            Type[] t = asm.GetTypes();
            var a = t.Where(x => x.IsClass && x.Namespace == "MVC.ECommerce.Console" && x.Name.Contains("mapping"));
            foreach (Type item in a)
            {
                className.Add(Activator.CreateInstance(item));
            }

            className.ForEach(x=> System.Console.WriteLine(x.ToString()));

        }
    }

    abstract class basemp{
        public int Id
        {
            get;
            set;
        }
    }
    class productmapping:basemp
    {
        public string name
        {
            get;
            set;
        }
    }

    class categorymapping:basemp
    {
        public string LastName
        {
            get;
            set;
        }

    }


}


