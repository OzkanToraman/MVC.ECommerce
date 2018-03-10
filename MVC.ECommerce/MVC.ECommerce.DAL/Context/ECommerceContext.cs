using System;
using System.Reflection;
using System.Data.Entity;
using System.Linq;
using MVC.ECommerce.DAL.Data;
using MVC.ECommerce.DAL.Mapping;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace MVC.ECommerce.DAL.Context
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext() : base("name = ECommerceContext" )
        {
        }


        #region DbSet
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<UpCategory> UpCategory
        {
            get;
            set;
        }
        public virtual DbSet<Category> Category
        {
            get;
            set;
        }
        public virtual DbSet<Product> Product
        {
            get;
            set;
        }
        public virtual DbSet<ProductProperty> ProductProperty
        {
            get;
            set;
        }
        public virtual DbSet<ProductPics> ProductPic
        {
            get;
            set;
        }
        public virtual DbSet<UserArea> UserArea
        {
            get;
            set;
        }
        public virtual DbSet<Comment> Comment
        {
            get;
            set;
        }
        public virtual DbSet<BankAccount> BankAccount
        {
            get;
            set;
        }
        public virtual DbSet<Account> Account
        {
            get;
            set;
        }
        public virtual DbSet<UserAddress> UserAddress
        {
            get;
            set;
        }
        public virtual DbSet<Address> Address
        {
            get;
            set;
        }
        public virtual DbSet<Role> Role
        {
            get;
            set;
        } 
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Mapping.AboutMapping());
            modelBuilder.Configurations.Add(new Mapping.AccountMapping());
            modelBuilder.Configurations.Add(new Mapping.AddressMapping());
            modelBuilder.Configurations.Add(new Mapping.BankAccountMapping());
            modelBuilder.Configurations.Add(new Mapping.CategoryMapping());
            modelBuilder.Configurations.Add(new Mapping.CommentMapping());
            modelBuilder.Configurations.Add(new Mapping.ContactMapping());
            modelBuilder.Configurations.Add(new Mapping.ProductMapping());
            modelBuilder.Configurations.Add(new Mapping.ProductPicMapping());
            modelBuilder.Configurations.Add(new Mapping.ProductPropertyMapping());
            modelBuilder.Configurations.Add(new Mapping.RoleMapping());
            modelBuilder.Configurations.Add(new Mapping.UpCategoryMapping());
            modelBuilder.Configurations.Add(new Mapping.UserAddressMapping());
            modelBuilder.Configurations.Add(new Mapping.UserAreaMapping());
            modelBuilder.Configurations.Add(new Mapping.LogMapping());
            modelBuilder.Configurations.Add(new Mapping.MessageMapping());
            modelBuilder.Configurations.Add(new Mapping.MediaUploadMapping());


        }
    }
}
