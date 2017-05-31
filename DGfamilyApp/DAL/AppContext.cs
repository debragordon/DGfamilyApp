using FamilyApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DGfamilyApp.DAL
{
    public class AppContext : DbContext
    {
        public AppContext() : base("FamilyApp") { }
        public DbSet<Family> Families { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}