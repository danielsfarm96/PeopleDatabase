using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Ex10
{
    public class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context db)
        {
            db.Companies.Add(new Company
            {
                Name = "Walmart"
            });
            db.Companies.Add(new Company
            {
                Name = "Amazon"
            });
            db.Companies.Add(new Company
            {
                Name = "Casey's"
            });
            db.People.Add(new Person
            {
                FirstName = "Bubba",
                LastName = "Sample",
                MiddleName = "U"
            });
            db.People.Add(new Person
            {
                FirstName = "Jeffy",
                LastName = "Jones",
                MiddleName = "J"
            });
            db.People.Add(new Person
            {
                FirstName = "Harry",
                LastName = "Human",
                MiddleName = "H"
            });
        }
    }
}
