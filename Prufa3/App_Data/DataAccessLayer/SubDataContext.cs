﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;
using Prufa3.Models.Entity;

namespace Prufa3.App_Data.DataAccessLayer
{
    public class SubDataContext : DbContext
    {
        public SubDataContext() : base("SubDataContext")
        {
        }

        // Gagnagrunnstoflur
        public DbSet<Client> Clients { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<SubFile> SubFiles { get; set; }

        // Kemur i veg fyrir ad toflur fai Fleirtolunofn (t.d. Clients)
        //  Nu halda thaer nofnunum i eintolu (t.d. Client)
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}