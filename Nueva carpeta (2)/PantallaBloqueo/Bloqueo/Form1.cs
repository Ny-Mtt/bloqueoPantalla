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
    public partial class Form1 : Form
    {
        int matric;
        string numClase;
        public Form1()
        {
            InitializeComponent();
            this.BringToFront();
            TheOne.AboveAll(this.Handle.ToInt32());
        }

        private void btnBloqueo_Click(object sender, EventArgs e)
        {
            matric = Int32.Parse(txtBoxMatricula.Text);
            numClase = txtBoxNumClas.Text;

            
            Consultas query1 = new Consultas();
            if(query1.Login(matric, numClase)=="ok")
            {
                Form2 linea = new Form2(matric, numClase);
               //Form4 bitac = new Form4(matric, numClase);

                Limpiar();
                linea.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("datos incorrectos, ingrese sus datos correctamente");
                Limpiar();
            }                       
        }

        public void Limpiar()
        {
            matric = 0;
            numClase = "";
            txtBoxMatricula.Clear();
            txtBoxNumClas.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 linea = new Form2(matric);
            //Form4 bitac = new Form4(matric, numClase);

           // Limpiar();
            //linea.Show();
            //this.Hide();
        }
    }
}
