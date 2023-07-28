using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloqueo
{
    class Conexion
    {
        SqlConnection conex = new SqlConnection();

        static string servidor = "192.168.20.35";//"labUniver.mssql.somee.com";//"localhost";
        static string bd = "BSLaboratorioTESChi";//"labUniver";
        static string usuario = /*"hunter_magno_SQLLogin_2";/*/"sa";
        static string password = /*"55lo6pa3io";/*/"Qdragon86 3";
        static string puerto = "1433";

        string cadenaConexion = "Data Source=" + servidor + "," + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "Initial Catalog=" + bd + ";" + "Persist Security Info=true";


        public SqlConnection establecerConexion()
        {

            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
               // MessageBox.Show("Se conectó correctamente a la Base de Datos");

            }
            catch (SqlException e)
            {

                MessageBox.Show("No se logró conectar a la Base de Datos" + e.ToString());
            }

            return conex;
        }

        public void cerrarConexion()
        {
            conex.Close();
        }
    }
}
