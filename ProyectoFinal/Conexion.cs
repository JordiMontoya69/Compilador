using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoFinal
{
    class Conexion
    {
        private string servidor;
        private string bd;
        private SqlConnection conecsion;
        
        public Conexion()
        {
            servidor = "localhost\\SQLEXPRESS";
            bd = "Compilador";
            conecsion = new SqlConnection("Server=" + servidor + ";Database=" + bd + ";Trusted_Connection=True;");
        }

        public DataTable Query(string query)
        {
            conecsion.Open();
            SqlCommand comando = new SqlCommand(query, conecsion);
            SqlDataReader datos = comando.ExecuteReader();
            DataTable tabla = new DataTable();

            tabla.Load(datos);

            datos.Close();
            conecsion.Close();
            comando.Dispose();
            return tabla;
        }
    }
}
