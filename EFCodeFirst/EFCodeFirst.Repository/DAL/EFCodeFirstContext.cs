using EFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Repository.DAL
{
    //Reference: https://dotblogs.com.tw/supershowwei/2016/04/11/000015


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
