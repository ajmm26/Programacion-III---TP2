using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Datos
{
    public class BaseService
    {
        private SqlConnection conexion;

        protected SqlCommand comando;

        protected SqlDataReader lector;


        public BaseService()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
        }


        public void conectar()
        {
            conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true;";
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            conexion.Open();
        }

        public void desconectar()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }

        }

        public void setStringCommand(string stsqlcommand)
        {
            comando.CommandText = stsqlcommand;
        }

        public void ExcecuteLector()
        {
            lector = comando.ExecuteReader();

        }

        public bool verificarId(int id)
        {
            if (id > 0)
            {
                comando.Parameters.AddWithValue("@Id", id);
                return true;
            }
            return false;
        }


    }
}
