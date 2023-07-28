using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloqueo
{
    public partial class Form3 : Form
    {
        int name;
        string numClase;
        int pc = 10;
       

        public Form3()
        {
            InitializeComponent();
            //EtiqNmbre(name);
            
        }

        public Form3(int dat1,string dat2)
        {
            this.name = dat1;
            this.numClase = dat2;
            EtiqNmbre(name);
        }

        public void EtiqNmbre(int cad1)
        {
            int val1 = 0;
            val1 = cad1;

            Consultas query2 = new Consultas();
            lblnameAlumno.Text = query2.Nombre(val1);
        }

        private void lblClase_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Form3 bitacora = new Form3();

        //    bitacora.Show();
        //    this.Hide();
        //}

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviarBitacora_Click(object sender, EventArgs e)
        {
            int numIncid;
            if (cmbIncidencia.Text == "No sirve el raton")
            {
                numIncid = 1;
                Consultas query3 = new Consultas();
                if (query3.CargBitac(numClase, name, pc, numIncid) == "ok")
                {
                    Form1 inicio = new Form1();
                    inicio.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("error al llenar los datos, intentelo de nuevo");
                    cmbIncidencia.Items.Clear();
                }

            } else if(cmbIncidencia.Text == "No prende el monitor")
            {
                numIncid = 2;
                Consultas query3 = new Consultas();
                if (query3.CargBitac(numClase, name, pc, numIncid) == "ok")
                {
                    Form1 inicio = new Form1();
                    inicio.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("error al llenar los datos, intentelo de nuevo");
                    cmbIncidencia.Items.Clear();
                }

            }
            else if(cmbIncidencia.Text == "No prende la PC")
            {
                numIncid = 3;
                Consultas query3 = new Consultas();
                if (query3.CargBitac(numClase, name, pc, numIncid) == "ok")
                {
                    Form1 inicio = new Form1();
                    inicio.Show();
                    this.Hide();
                    cmbIncidencia.Items.Clear();
                }
                else
                {
                    MessageBox.Show("error al llenar los datos, intentelo de nuevo");
                    cmbIncidencia.Items.Clear();
                }

            }
            else if (cmbIncidencia.Text == "Esta lenta la PC")
            {
                numIncid = 4;
                Consultas query3 = new Consultas();
                if (query3.CargBitac(numClase, name, pc, numIncid) == "ok")
                {
                    Form1 inicio = new Form1();
                    inicio.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("error al llenar los datos, intentelo de nuevo");
                    cmbIncidencia.Items.Clear();
                }

            }
        }
    }
}
