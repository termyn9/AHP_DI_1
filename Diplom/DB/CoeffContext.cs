using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    class CoeffContext : DbContext
    {
        public CoeffContext()
            :base("DefaultConnection")
        { }

        public DbSet<GroupFactor> Groups { get; set; }
    }
}
