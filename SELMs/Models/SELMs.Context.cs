﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_QLBH_BQD.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SELMsEntities : DbContext
    {
        public SELMsEntities()
            : base("name=SELMsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<Equipment_Import_Application> Equipment_Import_Application { get; set; }
        public virtual DbSet<Equipment_Import_Application_Detail> Equipment_Import_Application_Detail { get; set; }
        public virtual DbSet<Inventory_Request_Application> Inventory_Request_Application { get; set; }
        public virtual DbSet<Inventory_Request_Application_Detail> Inventory_Request_Application_Detail { get; set; }
        public virtual DbSet<Kpi> Kpis { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Project_Investment_Cost_Application> Project_Investment_Cost_Application { get; set; }
        public virtual DbSet<Project_Investment_Cost_Application_Detail> Project_Investment_Cost_Application_Detail { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Project_Equipment> Project_Equipment { get; set; }
        public virtual DbSet<Project_Member> Project_Member { get; set; }
    }
}
