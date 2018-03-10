using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.ECommerce.CustomHtmlHelpers
{
    public static class MyHtmlHelpers
    {
        //Html hepler dönüş tipi olarak MvcHmtlString alır ve HtmlHelper tipi tanımlamanız gerekiyo bu tiple Html. dediğinizde gelmesini sağlıyoruz.

        public static MvcHtmlString Button(this HtmlHelper htmlHelper,string Area,string actionName,string ControllerName,string innerHtml, IDictionary<string, string> htmlAttributes)
        {
            var builder = new TagBuilder("a") { InnerHtml = innerHtml };
            builder.MergeAttributes(htmlAttributes);
            builder.MergeAttribute("href",string.Format("/{0}/{1}/{2}",Area,ControllerName,actionName));
            return MvcHtmlString.Create(builder.ToString());
        }



    }
}


