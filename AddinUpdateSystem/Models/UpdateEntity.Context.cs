﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AddinUpdateSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SWP_SmartCubeEntities : DbContext
    {
        public SWP_SmartCubeEntities()
            : base("name=SWP_SmartCubeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Product> T_Product { get; set; }
        public virtual DbSet<ProductModule> T_ProductModule { get; set; }
        public virtual DbSet<ProductVersion> T_ProductVersion { get; set; }
    }
}
