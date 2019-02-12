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

                llegirXML(document);
            }
        }

        private void llegirXML(XDocument document)
        {
            limpiezaDatos();

            IEnumerable<XElement> elements = document.Descendants();

            XDocument doc = this.document;

            IEnumerable<XElement> Celdas = document.Descendants("Cell");
            foreach (XElement celda in Celdas)
            {
                string id_celda = celda.Element("ID").Value; //Elemento de ID Celda del XML
                string capacidad = celda.Element("Capacity").Value;  //Elemento de Capacidad Celda del XML
                string tipo = celda.Element("Type").Value;  //Elemento de Tipo de Celda del XML

                Celdas cel = new Celdas(id_celda, capacidad, tipo);
                celdas.Add(cel);

                contenedorCeldas.Controls.Add(cel);

                IEnumerable<XElement> prisionerosIE = celda.Descendants("Prisoner"); //Hijo de Celda para extraer elementos de un prisonero
                foreach (XElement prisionero in prisionerosIE)
                {
                    String id_prisionero = prisionero.Element("ID").Value;
                    String name = prisionero.Element("Name").Value;
                    String surname = prisionero.Element("Surname").Value;
                    String age = prisionero.Element("Age").Value;
                    String crime = prisionero.Element("Crime").Value;

                    //Variable que guarda la informacion del prisionero
                    Presione presionado = new Presione(id_celda, id_prisionero, name, surname, age, crime);
                    priseneros.Add(presionado); //Se añade los datos al objecto prisioneros
                    cel.AñadirPrisionero(presionado);
                }

            }

        
        }

        private void limpiezaDatos()
        {
            contenedorCeldas.Controls.Clear();
            celdas.Clear();
            priseneros.Clear();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
         
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
                    string letra = Microsoft.VisualBasic.Interaction.InputBox("Escribe un motivo, D de Defucion, P Cumplir Pena, R de Reformando");
                    string motivo = null;

                    XElement prisoner = (from result in document.Descendants("Prisoner")
                                         where result.Element("ID").Value == pris
                                         select result).FirstOrDefault();

                         letra = letra.ToUpper(); 
                         if (letra == "D" ) 
                         {
                            motivo = "Defuncion";
                         }
                         else if (letra == "P")
                         {
                          motivo = "Cumplir Pena";
                         }
                         else if (letra == "R")
                         {
                         motivo = "Reformacion";
                         }
                         else {
                            MessageBox.Show("Opcion no valida");
                         }


                    if (prisoner is null)
                    {
                        MessageBox.Show("Prisionero No Encontrado");
                    }
                    else
                    {
                        if (motivo is null)
                        {

                        }
                        else
                        {
                            prisoner.Remove();
                            document.Save(filePath);
                            llegirXML(document);
                        }
                       
                    }


                }

                private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    //Creacion de un prisionero
                    string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre");
                    string apellido = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el apellido");
                    string edat = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la edat");
                    string crimen = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la crimen");
                    string celda = null;
                    Random rnd = new Random();
                    int month = rnd.Next(1000, 9999);

                    string id = month.ToString();

                    for (int i = 0; celda is null; i++)
                    {
                      
                         if (celdas[i].GetCount() < Int32.Parse(celdas[i].GetPtype()))
                        {
                           celda = celdas[i].GetPid();
                            MessageBox.Show("Actuales " + celdas[i].GetCount() + " Maximo " + celdas[i].GetPtype());
                            MessageBox.Show("Se ha asignado en la celda "+celda);
                        }

                    }

                    if (celda is null)
                    {
                       MessageBox.Show("No espacio en ninguna celda");
                    }
                     else{

                        XElement cell = (from result in document.Descendants("Cell")
                                         where result.Element("ID").Value == celda
                                         select result).FirstOrDefault();


                        XElement pres = (from result in cell.Descendants("Prisoners")
                                         select result).FirstOrDefault();





                        if (pres is null)
                        {
                            MessageBox.Show("No existe la celda " + celda);
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

                            pres.Add(newNode);

                            document.Save(filePath);
                            llegirXML(document);
                        }



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


                     XElement pres = (from result in cell.Descendants("Prisoners")
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

