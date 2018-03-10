using MVC.ECommerce.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.ECommerce.DAL.Mapping
{
    public class MediaUploadMapping : _BaseMapping<MediaUpload>
    {
        public MediaUploadMapping()
        {
            Property(x => x.Name)
                .HasColumnType("nvarchar(max)")
                .IsRequired();
            Property(x => x.Path)
                .HasColumnType("nvarchar(max)")
                .IsRequired();
                
        }
    }
}
