﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homeclick.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class vinabits_homeclickEntities : DbContext
    {
        public vinabits_homeclickEntities()
            : base("name=vinabits_homeclickEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Canva> Canvas { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Category_detail> Category_detail { get; set; }
        public virtual DbSet<Category_type> Category_type { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Customer_type> Customer_type { get; set; }
        public virtual DbSet<CustomSecurityRole> CustomSecurityRoles { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Floor> Floors { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Post_detail> Post_detail { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product_detail> Product_detail { get; set; }
        public virtual DbSet<Product_type> Product_type { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Wishlist> Wishlists { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectItem> ProjectItems { get; set; }
        public virtual DbSet<ProjectLayout_Collection> ProjectLayout_Collections { get; set; }
    }
}
