
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.DB
{
    public class AppDB : DbContext
    {
        public AppDB() : base("DefaultConnection")
        {
        }
        public DbSet<User> Users { get; set; }
    }
}