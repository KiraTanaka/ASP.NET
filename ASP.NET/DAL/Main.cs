using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 
using ASP.NET.Models; 
using System.Data.Entity.ModelConfiguration.Conventions; 

namespace ASP.NET.DAL
{
    public class SchoolContext : DbContext 
    { 
        public DbSet<HomeModel> Courses { get; set; } 
 
        protected override void OnModelCreating(DbModelBuilder modelBuilder) 
        { 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
        } 
    } 
}