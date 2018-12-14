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

namespace ControlPreso
{
    public partial class Form1 : Form
    {

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


            String filePath = "";

            if (LoadFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = LoadFileDialog.FileName;
                document = XDocument.Load(filePath);

                llegirXML(document);
                //querySelect(document);
                //queryDelete(ref document, filePath);
                //queryAdd(ref document, filePath);
            }
        }
        private void llegirXML(XDocument document)
        {
            IEnumerable<XElement> elements = document.Descendants();

            foreach (XElement element in elements)
            {
               // MessageBox.Show(element.ToString());
               
            }

            IEnumerable<XElement> elements2 = document.Descendants("Cell");
            foreach (XElement element in elements)
            {
              //  MessageBox.Show(element.ToString());
               // label1.Text = element.ToString();

            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string celda = textBox1.Text;
            XElement cell = (from result in document.Descendants("Cell")
                             where result.Element("ID").Value == celda
                             select result).FirstOrDefault();

            MessageBox.Show(cell.ToString());

        }

       
    }
}
