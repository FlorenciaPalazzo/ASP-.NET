using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SistemaWebTransporte.Models;

namespace SistemaWebTransporte.Data
{
    public class AutoDbContext:DbContext
    {
        public AutoDbContext() : base("keyAutoDB") { }
        public DbSet<Auto> Autos { get; set; }
    }
}