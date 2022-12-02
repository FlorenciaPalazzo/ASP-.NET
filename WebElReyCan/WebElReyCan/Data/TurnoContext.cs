using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebElReyCan.Models;

namespace WebElReyCan.Data
{
    public class TurnoContext :DbContext

    {
       public TurnoContext() : base("keyTurnoDB") { }
        public DbSet<Turno>Turnos { get; set; }
    }
}