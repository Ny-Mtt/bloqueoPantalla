using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloqueo
{
    class Consultas
    {
        //método para consultar las cedenciales a la base de datos y verificar credenciales y desbloquear
        public string Login(int dat1, string dat2) 
        {
            Conexion objConex = new Conexion();

            try
            {
                string Query; //en esta variable se almacena la consulta SQL para utilizar parametros se usa @vmatric y @vclasscode

                Query = "SELECT * FROM prueblogin WHERE matricula = @vmatric AND codigClase = @vclasscode";

                SqlCommand comando = new SqlCommand(Query, objConex.establecerConexion());

                comando.Parameters.AddWithValue("@vmatric", dat1);
                comando.Parameters.AddWithValue("@vclasscode", dat2);

                SqlDataReader lectura = comando.ExecuteReader();

                if (lectura.HasRows == true)
                {
                    // MessageBox.Show("exito");
                    objConex.cerrarConexion();
                    return "ok";
                }
                else
                {
                    //MessageBox.Show("suerte para la prxima");
                    objConex.cerrarConexion();
                    return "error";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                objConex.cerrarConexion();
                return "error";
            }

        }

        //método para consultar el nombre del alumno de la base de datos y se visualice en la ventana
        public string Nombre(int dat1)
        {

            Conexion objConex = new Conexion();

            try
            {
                string Query2; //en esta variable se almacena la consulta SQL, para utilizar parametros se usa @vmatric y @vclasscode

                Query2 = "SELECT * FROM Alumnos WHERE Numero_Control = @vmatric";
                SqlCommand comando = new SqlCommand(Query2, objConex.establecerConexion());
                comando.Parameters.AddWithValue("@vmatric", dat1);
                SqlDataReader lectura = comando.ExecuteReader();

                if (lectura.Read() == true)
                {
                    //MessageBox.Show(" "+ lectura["nombre"].ToString());
                    String resultado;
                    resultado = lectura["Nombre_Alumno"].ToString();
                    objConex.cerrarConexion();
                    return resultado;
                }
                objConex.cerrarConexion();
                return " ";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                objConex.cerrarConexion();
                return "error";
            }

        }

        //método para guardar la información en la tabla bitacora

        public string CargBitac(string dat1, int dat2, int dat3, int dat4)
        {

            Conexion objConex = new Conexion();            

            try
            {
                string Query; //en esta variable se almacena la consulta SQL para utilizar parametros se usa @vmatric y @vclasscode

                Query = "INSERT INTO Bitacora (ID_Numero_Clase, Numero_Control, PC, ID_Observacion) VALUES (@vclassCode, @vmatric, @vPC, @vidIncid)";
                SqlCommand comando = new SqlCommand(Query, objConex.establecerConexion());

                comando.Parameters.AddWithValue("@vclassCode", dat1);
                comando.Parameters.AddWithValue("@vmatric", dat2);
                comando.Parameters.AddWithValue("@vPC", dat3);
                comando.Parameters.AddWithValue("@vidIncid", dat4);

                SqlDataReader insertBitac = comando.ExecuteReader();    
                   // MessageBox.Show("bitacora registrada satisfactoriamente");
                    objConex.cerrarConexion();
                    return "ok";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                objConex.cerrarConexion();
                return "error";
            }

        }

        //método para obtener el ID de la observación que se utliliza para llenar la tabla bitacora
        public int obtenerIdObserv(string dat1)
        {
            Conexion objConex = new Conexion();
            try
            {
                string Query; //en esta variable se almacena la consulta SQL para utilizar parametros se usa @vmatric y @vclasscode

                Query = "SELECT ID_Observacion FROM Observaciones where Observacion = @vincid";
                SqlCommand comando = new SqlCommand(Query, objConex.establecerConexion());
                comando.Parameters.AddWithValue("@vincid", dat1);
                SqlDataReader lectura1 = comando.ExecuteReader();

                int idObserv;

                if (lectura1.Read() == true)
                {
                    //MessageBox.Show(" "+ lectura["nombre"].ToString());

                    idObserv = Int16.Parse(lectura1["ID_Observacion"].ToString());
                    //MessageBox.Show("el Idobserv es :" + idObserv);
                   
                    objConex.cerrarConexion();
                    return idObserv;
                }

                objConex.cerrarConexion();
                return 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                objConex.cerrarConexion();
                return 0;
            }


        }



    }
}
