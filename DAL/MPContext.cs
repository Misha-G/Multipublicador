using Multipublicador.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Multipublicador.DAL
{
    public class MPContext : DbContext
    {
        public MPContext() : base("MPContext")
        {
        }

        public DbSet<MPSourcePortal> MPSourcePortals { get; set; }
        public DbSet<MPDealer> MPDealers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}