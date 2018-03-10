using MVC.ECommerce.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MVC.ECommerce.DAL.Model
{
    public class ProductAddModel
    {
        public Product Product { get; set; }
        public ProductPics ProductPics { get; set; }
        public IEnumerable<HttpPostedFileBase> UploadedProductPic { get; set; }
    }
}
