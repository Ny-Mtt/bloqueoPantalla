using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloqueo
{
    public partial class Form4 : Form
    {
        int matr;
        string numClase;
        int pc = 10;

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(int dat1, string dat2)
        {
            InitializeComponent();
            this.matr = dat1;
            this.numClase = dat2;
            EtiqNmbre(matr);
            FillIncidencias();
            tmrSend.Start();


        }

        public void EtiqNmbre(int cad1)
        {
            int val1;
            val1 = cad1;

            Consultas query2 = new Consultas();
            lblnameAlumno.Text = query2.Nombre(val1);
           
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string incidencia;
            incidencia = cmbIncd.Text;
            //MessageBox.Show(incidencia);
            Consultas guardBitac = new Consultas();
            int idBitac;
            idBitac = guardBitac.obtenerIdObserv(incidencia);
            //if (idBitac != 0)
            //{
                if (guardBitac.CargBitac(numClase, matr, pc, idBitac) == "ok")
                {
                    MessageBox.Show("información guardada satisfactoriamente");
                    matr = 0;
                    numClase = null;
                    Form1 inicio = new Form1();
                    tmrSend.Stop();
                    inicio.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("error al guardar la información, volver a intentar ");
                }
            //}
            //else
            //{
            //    MessageBox.Show("error al ingresar los datos , vuelve a intentar");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 inicio = new Form1();
            //inicio.Show();
            //this.Hide();
        }

        public void FillIncidencias()
        {
            Conexion objConex = new Conexion();
            try
            {
                string Query; //en esta variable se almacena la consulta SQL para utilizar parametros se usa @vmatric y @vclasscode

                Query = "SELECT * FROM observacion";

                SqlCommand comando = new SqlCommand(Query, objConex.establecerConexion());

                SqlDataReader lectura = comando.ExecuteReader();

                while (lectura.Read() == true)
                {
                    //DataTable incidencias = new DataTable();
                    //lectura.Read();
                    //MessageBox.Show(" "+ lectura["observ"].ToString);
                    //MessageBox.Show("incidencia "+ lectura["observ"].ToString());
                    //MessageBox.Show("id " + lectura["idobservacion"].ToString());
                    //String resultado;
                    //resultado = lectura["observ"].ToString();
                    //cmbIncd.SelectedItem =
                    cmbIncd.Items.Add(lectura.GetString(1));
                    cmbIncd.SelectedItem= "Ninguna";
                }

            } catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            objConex.cerrarConexion();
        }

        private void tmrSend_Tick(object sender, EventArgs e)
        {
           DialogResult btnSelect = MessageBox.Show("La bitacora será enviada, esta seguro, ¡confirme!",
                 "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (btnSelect == DialogResult.Yes)
            {

                string incidencia;
                incidencia = cmbIncd.Text;
                //MessageBox.Show(incidencia);
                Consultas guardBitac = new Consultas();
                int idBitac;
                idBitac = guardBitac.obtenerIdbitac(incidencia);
                //if (idBitac != 0)
                //{

                if (guardBitac.CargBitac(numClase, matr, pc, idBitac) == "ok")
                {
                    MessageBox.Show("información guardada satisfactoriamente");
                    matr = 0;
                    numClase = null;
                    Form1 inicio = new Form1();
                    tmrSend.Stop();
                    inicio.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("error al guardar la información, volver a intentar ");
                }

            }
        }
    }
}
