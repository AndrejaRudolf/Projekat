using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Projekat_ITS.Models;

namespace Projekat_ITS.Context
{
    public class UcenikContext : DbContext
    {
        public DbSet<Ucenik> Ucenik { get; set; }

  
    }
}