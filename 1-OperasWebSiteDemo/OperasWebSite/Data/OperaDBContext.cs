using OperasWebSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OperasWebSite.Data
{
    public class OperaDBContext:DbContext
    {
        public OperaDBContext(): base("keyOperaDB") { }
        public DbSet<Opera> Operas { get; set; }
    }
}