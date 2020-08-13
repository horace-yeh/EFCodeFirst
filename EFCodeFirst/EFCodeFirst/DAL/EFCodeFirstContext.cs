using EFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFCodeFirst.DAL
{
    public class EFCodeFirstContext : DbContext
    {
        public EFCodeFirstContext() : base("EFCodeFirstContext")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
    }
}