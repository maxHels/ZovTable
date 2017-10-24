using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZovTable
{
    class Db:DbContext
    {
        public Db() : base("ShipsDb") { }

        public DbSet<Ship> Ships { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pack> Packs { get; set; }
        public DbSet<Detail> Details { get; set; }

    }
}
