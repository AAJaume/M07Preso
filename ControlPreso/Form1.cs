using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Text.RegularExpressions;

namespace ControlPreso
{
    public partial class Form1 : Form
    {
        static int Max = 0;
        static List<Celdas> celdas = new List<Celdas>();
        static List<Presione> priseneros = new List<Presione>();
        static String filePath = "";


        private XDocument document;

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


            LoadFileDialog.InitialDirectory = "C:\\";
            LoadFileDialog.Filter = "xml files (*.xml) | *.xml";
            LoadFileDialog.RestoreDirectory = true;


  

            if (LoadFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = LoadFileDialog.FileName;
                document = XDocument.Load(filePath);

               
                //querySelect(document);
                //queryDelete(ref document, filePath);
                //queryAdd(ref document, filePath);
                llegirXML(document);
            }

        }
        private void llegirXML(XDocument document)
        {
            
            IEnumerable<XElement> elements = document.Descendants();

            XDocument doc = this.document;

            foreach (XElement element in elements)
           {
               // MessageBox.Show(element.ToString());
            }

            IEnumerable<XElement> elements2 = document.Descendants("Cell");
            foreach (XElement element in elements2)
            {
             //   MessageBox.Show(elements2.ToString());
                // label1.Text = element.ToString();
                Max++;
              

            }



            XElement librosEjemplo = doc.Element("Cells"); //Nodo de Celdas en conjunto

            IEnumerable<XElement> libros = librosEjemplo.Descendants("Cell"); //Nodo de Celda

            IEnumerable<XElement> preciones = libros.Descendants("Prisoners"); //Nodo de Pricioneros en conjunto

            IEnumerable<XElement> precione = preciones.Descendants("Prisoner"); //Nodo de Pricioneros





            //int posi = 0;
            foreach (XElement zelda in libros)
            {
                
                int pos = 0; //Pos contador de posicion de la lista prisionerosLista
                string id_celda = zelda.Element("ID").Value; //Elemento de ID Celda del XML
                string capacidad = zelda.Element("Capacity").Value;  //Elemento de Capacidad Celda del XML
                string tipo = zelda.Element("Type").Value;  //Elemento de Tipo de Celda del XML


                IEnumerable<XElement> prisionerosIE = zelda.Descendants("Prisoner"); //Hijo de Celda para extraer elementos de un prisonero
                List<XElement> prisionerosLista = prisionerosIE.ToList(); //Lista de Prisoneros

                for (pos = 0; pos< prisionerosLista.Count; pos++) //Bucle de para añadir prisioneros en el objecto
                {
                    // MessageBox.Show(prisionerosLista[pos].ToString());

                    XElement prisionero = prisionerosLista[pos];
                    String id_prisionero = prisionero.Element("ID").Value;
                    String name = prisionero.Element("Name").Value;
                    String surname = prisionero.Element("Surname").Value;
                    String age = prisionero.Element("Age").Value;
                    String crime = prisionero.Element("Crime").Value;

                    //Variable que guarda la informacion del prisionero



                    priseneros.Add(new Presione(id_celda, id_prisionero, name,surname,age,crime)); //Se añade los datos al objecto prisioneros
                }

               
                










                    //  MessageBox.Show(id_celda+ " "+capacidad+ " "+tipo);
                    celdas.Add(new Celdas(id_celda,capacidad, tipo));
                   // MessageBox.Show(priseneros[0].GetPrinfo());
               // posi++;
                
            }
            /*foreach (XElement precion in precione)
            {
                string id_pre = precion.Element("ID").Value;
                string name = precion.Element("Name").Value;
                MessageBox.Show(name);
            }*/
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Generacion de IMG 
            String celda = textBox1.Text;
            XDocument doc = this.document;
            string info = "";
            string typo = "";
            string id = "";
            int config = 0;
            int pos1 = 0;
            int pos2 = 0;
            int x = 50;
            int Conteo = 1;

            if (doc is null)
            {
                MessageBox.Show("No se cargado el XML");
            }
            else
            {
                foreach (var zoldo in celdas)
                {
                    if (celdas[pos1].GetPid() == celda)
                    {
                        id = celdas[pos1].GetPid();
                        typo = celdas[pos1].GetPtype();
                        info = celdas[pos1].GetPcapacity();
                        config++;
                    }
                    pos1++;
                }
                if (config > 0)
                {
                    label1.Text = id;
                    label2.Text = info;
                    label3.Text = typo;
                    foreach (var presso in priseneros)
                    {
                        if (priseneros[pos2].GetPrid() == id)
                        {

                            /*
                            Label lbl = new Label();
                            lbl.Name = "labwel" + Conteo.ToString();
                            lbl.Height = 400;
                            lbl.Width = 400;
                            lbl.Location = new Point(55, x);
                            x += 25;
                            lbl.Text = priseneros[pos2].GetPrinfo();
                            panel1.Controls.Add(lbl);
                            Conteo++;*/

                            string suid = priseneros[pos2].GetPrsid();
                            string nombre = priseneros[pos2].GetPname();
                            string apel = priseneros[pos2].GetPsurname();
                            string edad = priseneros[pos2].GetPage();
                            string crimen = priseneros[pos2].GetPcrime();
                            if (Conteo <= 3)
                            {
                                priseneros[pos2].Location = new System.Drawing.Point(x, 20);
                            }
                            if (Conteo == 4)
                            {
                                x = 50;
                                priseneros[pos2].Location = new System.Drawing.Point(x, 150);
                            }
                            if (Conteo > 4)
                            {
                                priseneros[pos2].Location = new System.Drawing.Point(x, 150);
                            }

                            Controls.Add(priseneros[pos2]);
                            priseneros[pos2].Click += delegate
                            {
                                MessageBox.Show("ID: "+suid+ "\n" +"Nombre: "+ nombre+ "\n" +"Apellido: "+apel+ "\n"+"Edat: "+edad+ "\n"+"Crimen: "+crimen);
                            };

                            priseneros[0].Visible = true;
                            x +=150;
                            Conteo++;
                        }
                        pos2++;

                    }

                }
                else
                {
                    MessageBox.Show("No existe dicha celda");
                }
            }
            







        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void liberarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Liberacion de un prisionero
            string pris = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID que quieres liberar");
            string motivo = Microsoft.VisualBasic.Interaction.InputBox("Escribe un motivo");

            XElement prisoner = (from result in document.Descendants("Prisoner")
                                 where result.Element("ID").Value == pris
                                 select result).FirstOrDefault();
            

            if (prisoner is null)
            {
                MessageBox.Show("Prisionero No Encontrado");
            }
            else
            {
                prisoner.Remove();
                document.Save(filePath);
                llegirXML(document);
            }

            
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creacion de un prisionero
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre");
            string apellido = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el apellido");
            string edat = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la edat");
            string crimen = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la crimen");
            string celda = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la celda");
            Random rnd = new Random();
            int month = rnd.Next(1000, 9999);

            string id = month.ToString();

            XElement cell = (from result in document.Descendants("Cell")
                             where result.Element("ID").Value == celda
                             select result).FirstOrDefault();

            

            if (cell is null)
            {
                MessageBox.Show("No existe la celda "+celda);
            }
            else
            {
                XElement newNode = new XElement("Prisoner",
                                new XElement("ID", id),
                                new XElement("Name", nombre),
                                new XElement("Surname", apellido),
                                new XElement("Age", edat),
                                new XElement("Crime", crimen));

                // document.Element("Cells").Add(newNode);

                cell.Add(newNode);

                document.Save(filePath);
                llegirXML(document);
            }


         

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Editar el nombre
            string pris = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID del prisionero");
            string name = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre");
            XElement prisoner = (from result in document.Descendants("Prisoner")
                                 where result.Element("ID").Value == pris
                                 select result).FirstOrDefault();

            prisoner.Element("Name").Value = name;

            document.Save(filePath);
            llegirXML(document);
            if (prisoner is null)
            {
                MessageBox.Show("No existe el prisionero  " + pris);
            }
            else
            {

                prisoner.Element("Name").Value = name;

                document.Save(filePath);
                llegirXML(document);
            }
        }
        private void apellidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Editar el apellido
            string pris = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID del prisionero");
            string apel = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el apellido");
            XElement prisoner = (from result in document.Descendants("Prisoner")
                                 where result.Element("ID").Value == pris
                                 select result).FirstOrDefault();

            prisoner.Element("Surname").Value = apel;

            document.Save(filePath);
            llegirXML(document);

            if (prisoner is null)
            {
                MessageBox.Show("No existe el prisionero  " + pris);
            }
            else
            {

                prisoner.Element("Surname").Value = apel;

                document.Save(filePath);
                llegirXML(document);
            }
        }

        private void añosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Edicion de edad
            string pris = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID del prisionero");
            string ano = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Año");
            XElement prisoner = (from result in document.Descendants("Prisoner")
                                 where result.Element("ID").Value == pris
                                 select result).FirstOrDefault();


            if (prisoner is null)
            {
                MessageBox.Show("No existe el prisionero  " + pris);
            }
            else
            {
                prisoner.Element("Age").Value = ano;

                document.Save(filePath);
                llegirXML(document);
            }
        }

        private void crimenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Edicion de Crimen
            string pris = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID del prisionero");
            string crim = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Crimen");
            XElement prisoner = (from result in document.Descendants("Prisoner")
                                 where result.Element("ID").Value == pris
                                 select result).FirstOrDefault();

            if (prisoner is null)
            {
                MessageBox.Show("No existe el prisionero  " + pris);
            }
            else
            {
                prisoner.Element("Crime").Value = crim;

                document.Save(filePath);
                llegirXML(document);
            }


           
        }

        private void moverDeCeldaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Mover un prisionero de celda
            string nombre;
            string apellido;
            string edat;
            string crimen;
            string celda = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID de Celda Nueva");
         

            string id = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID del prisionero");

            XElement cell = (from result in document.Descendants("Cell")
                             where result.Element("ID").Value == celda
                             select result).FirstOrDefault();



            if (cell is null)
            {
                MessageBox.Show("No existe la celda " + celda);
            }
            else
            {

                XElement prisoner = (from result in document.Descendants("Prisoner")
                                     where result.Element("ID").Value == id
                                     select result).FirstOrDefault();
            if (prisoner is null)
                {
                    MessageBox.Show("No existe el prisionero  " + id);
                }
                else
                {
                    nombre = prisoner.Element("Name").Value;
                    apellido = prisoner.Element("Surname").Value;
                    edat = prisoner.Element("Age").Value;
                    crimen = prisoner.Element("Crime").Value;

                    XElement newNode = new XElement("Prisoner",
                                    new XElement("ID", id),
                                    new XElement("Name", nombre),
                                    new XElement("Surname", apellido),
                                    new XElement("Age", edat),
                                    new XElement("Crime", crimen));

                    // document.Element("Cells").Add(newNode);

                    cell.Add(newNode);
                    prisoner.Remove();
                    document.Save(filePath);
                    llegirXML(document);

                }

            }

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(celdas[1].GetPid());
        }
    }
}

