using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPreso
{
    class Presione : System.Windows.Forms.PictureBox
    {
        public string prid;
        public string prsid;
        public string pname;
        public string psurname;
        public string page;
        public string pcrime;


        public Presione(string id,string sid ,string name,string surname,string age,string crime)
        {
            this.prid=id;
            this.prsid = sid;
            this.pname= name;
            this.psurname = surname;
            this.page = age;
            this.pcrime = crime;

            this.Size = new System.Drawing.Size(140, 140);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Image = ControlPreso.Properties.Resources.dealer;
            this.Visible = true;

            this.Click += delegate
            {
                MessageBox.Show("ID: " + prsid + "\n" + "Nombre: " + pname + "\n" + "Apellido: " + psurname + "\n" + "Edat: " + page + "\n" + "Crimen: " + pcrime);
            };
        }

        public string GetPrid()
        {
            return prid;
        }
        public void SetPrid(string prid)
        {
            this.prid = prid;
        }

        public string GetPrsid()
        {
            return prsid;
        }
        public void SetPrsid(string prsid)
        {
            this.prsid = prsid;
        }

        public void SetPname(string pname)
        {
            this.pname = pname;
        }
        public string GetPname()
        {
            return pname;
        }

        public void SetPsurname(string psurname)
        { 
            this.psurname = psurname;
        }
        public string GetPsurname()
        {
            return psurname;
        }
        public void SetPage(string page)
        {
            this.page = page;
        }
        public string GetPage()
        {
            return page;
        }
        public void SetPcrime(string pcrime)
        {
            this.pcrime = pcrime;
        }
        public string GetPcrime()
        {
            return pcrime;
        }

    }
}
