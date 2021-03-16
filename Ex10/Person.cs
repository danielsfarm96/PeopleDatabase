using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ex10
{
    public class Person
    {
        public int PersonId { get; set; }

        [MaxLength(30, ErrorMessage = "First name cannot be longer than 30")]
        public string FirstName { get; set; }

        [MaxLength(30, ErrorMessage = "Last name cannot be longer than 30")]
        public string LastName { get; set; }

        [StringLength(1, MinimumLength = 1)]
        [Column(TypeName = "CHAR")]
        public string MiddleName { get; set; }

        [MaxLength(40, ErrorMessage = "Nick name cannot be longer than 40")]
        public string NickName { get; set; }

        public DateTime? BirthDate { get; set; }

        public int Age { get; set; }

        public DateTime DateAdded { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }
        public Person()
        {
            Phones = new HashSet<Phone>();
        }

        public virtual ICollection<Company> Companies { get; set; }
    }
}
