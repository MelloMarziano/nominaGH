﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NominaGH.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class grupohie_nominaEntities : DbContext
    {
        public grupohie_nominaEntities()
            : base("name=grupohie_nominaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<empleados> empleados { get; set; }
        public DbSet<resultados> resultados { get; set; }
    }
}