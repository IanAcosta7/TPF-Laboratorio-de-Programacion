using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TPF_Laboratorio_de_Programacion
{
    class Utilidades
    {

        public static DataSet Ejecutar (string cmd)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TPF2019;Integrated Security=True");
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);

            try { 
                con.Open();
                DP.Fill(DS);
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }
            con.Close();

            return DS;
        }

        /*
        public static void agregarDB (string cmd)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TPF2019;Integrated Security=True");

            try
            {
                // Conexion a la base de datos
                con.Open();

                // Comando de la conexion
                SqlCommand command = new SqlCommand(cmd, con);

                // Se ejecuta el comando
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR: " + err.Message);
            }
            con.Close();
        }
        */
    }
}
