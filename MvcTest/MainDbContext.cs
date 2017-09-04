using System.Data.Entity;
using MvcTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTest
{
    public class MainDbContext : DbContext
    {
        public MainDbContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<List> List { get; set; }
    }

}