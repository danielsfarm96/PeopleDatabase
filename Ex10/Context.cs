using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Ex10
{
    public class Context : DbContext
    {
        public Context() : base("name=example10")
        {

        }
        public DbSet<Person> People { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }
}
