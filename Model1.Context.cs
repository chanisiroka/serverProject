﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class databaseOrEntities : DbContext
    {
        public databaseOrEntities()
            : base("name=databaseOrEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EmzeiTashlum> EmzeiTashlum { get; set; }
        public virtual DbSet<hakdashaTbl> hakdashaTbl { get; set; }
        public virtual DbSet<studentTbl> studentTbl { get; set; }
        public virtual DbSet<tashlumTbl> tashlumTbl { get; set; }
        public virtual DbSet<tashlumTbl1> tashlumTbl1 { get; set; }
        public virtual DbSet<tblKlali> tblKlali { get; set; }
        public virtual DbSet<tblTorem> tblTorem { get; set; }
    }
}