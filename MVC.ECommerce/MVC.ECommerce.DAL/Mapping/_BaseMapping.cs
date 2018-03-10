using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using MVC.ECommerce.DAL.Data;

namespace MVC.ECommerce.DAL.Mapping
{
    public abstract class _BaseMapping<T> : EntityTypeConfiguration<T>
        where T : _EntityBase,new()
    {
        public _BaseMapping()
        {
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
