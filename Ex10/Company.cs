using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}
