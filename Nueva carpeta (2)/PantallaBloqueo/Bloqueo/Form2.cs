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
    public partial class Form2 : Form
    {
        int matricula; // aqui se almacena la matricula que el alumno digito desde la ventana bloqueo
        string clase;
        public Form2()
        {
            InitializeComponent();
            // MessageBox.Show("hola");
        }

        public Form2 (int dat, string dat2)
        {
            InitializeComponent();
            this.matricula = dat;
            this.clase = dat2;
            EtiqNmbre(matricula);
            tmrMedio.Start();
        }

        public void EtiqNmbre (int cad1)
        {
            int val1;
            val1 = cad1;

            Consultas query2 = new Consultas();
            lblAlumno.Text =query2.Nombre(val1);
            //nombre = lblAlumno.Text;
        }

        private void lblClase_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 bitacora = new Form4(matricula,clase);
            tmrMedio.Stop();
            bitacora.Show();
            this.Hide();
        }

        //public void Espera()
        //{
        //    while (true)
        //    {
        //        tmrMedio.Start();
        //        if
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            //Form4 bitacora = new Form4();

            //bitacora.Show();
            //this.Hide();
        }

        private void tmrMedio_Tick(object sender, EventArgs e)
        {
            DialogResult btnSelect = MessageBox.Show("Desea finalizar su sesión", "Confirmación", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (btnSelect == DialogResult.Yes)
            {
                Form4 bitacora = new Form4(matricula, clase);
                tmrMedio.Stop();
                bitacora.Show();
                this.Hide();
            }
        }
    }
}
