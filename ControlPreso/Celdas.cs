using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPreso
{
    class Celdas : System.Windows.Forms.GroupBox
    {
        private string pid;
        private string ptype;
        private string pcapacity;
        private int count;
        private FlowLayoutPanel llistaPresoners;

        public Celdas()
        {
            this.pid = " ";
            this.ptype=" ";
            this.pcapacity = " ";
 //valor dins de this.nomvalor amb condicio spai
            
        }

        public Celdas(string id, string tipo, string capacitat)
        {
            this.pid = id;
            this.ptype = tipo;
            this.pcapacity = capacitat;
            this.Text = "Celda "+ id+ " Capacitat " + tipo+" Tipo " + capacitat;
            this.Size = new System.Drawing.Size(140 * 4, 150 * 2);


            llistaPresoners = new FlowLayoutPanel();
            llistaPresoners.Dock = DockStyle.Fill;
            this.Controls.Add(llistaPresoners);

            
            

        }

        public void AñadirPrisionero(Presione prisionero)
        {
            llistaPresoners.Controls.Add(prisionero);
        }

        public string GetPid() {
            return pid;
        }

        public void SetPid(string pid) {
            this.pid = pid;
        }

        public string GetPtype()
        {
            return ptype;
        }

        public void SetPtype(string ptype)
        {
            this.ptype = ptype;
        }

        public string GetPcapacity()
        {
            return pcapacity;
        }

        public void SetPcapacity(string pcapacity)
        {
            this.pcapacity = pcapacity;
        }

        public int GetCount()
        {
            return llistaPresoners.Controls.Count;
        }
    
        // for(){}

    }

}
