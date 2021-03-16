using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Ex10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database.SetInitializer(new Initializer());

            using (var db = new Context())
            {

                var query = (from pple in db.People
                             from cmpy in db.Companies
                             select new
                             {
                                 PName = pple.FirstName + " " + pple.LastName,
                                 CName = cmpy.Name.ToString() + " Inc."
                             }).ToList();

                dgvSample.DataSource = query;

                var phonePeople = (from p in db.People
                                   from pn in p.Phones
                                   where pn.PhoneNumber.StartsWith("123")
                                   select new
                                   {
                                       Person_Id = p.PersonId,
                                       First_Name = p.FirstName,
                                       Last_Name = p.LastName,
                                       Middle_Name = p.MiddleName
                                   }).ToList();

                dgvTwo.DataSource = phonePeople;
            }
        }
    }
}
