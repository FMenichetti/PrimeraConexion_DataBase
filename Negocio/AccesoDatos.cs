using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoDatos
    {
        //Esta clase la vamos a crear para evitar tanta declaracion de codigo en las conecciones y pedido de datos
        
        //Declaramos los atributos que vamos a necesitar
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector { get { return lector; }  }

        //Creamos la instancia a la conexion y al comando que utilizaremos
        public  AccesoDatos()
        {
            conexion = new SqlConnection("Server=DESKTOP-A78M7US\\SQLEXPRESS; database = POKEDEX_DB;integrated security=true");
            comando = new SqlCommand();

        }

        public void setearConsulta(string consulta)//Tipo de conexion y consulta por parametro
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()//Comenzamos a leer
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cerrarConexion()//Si el lector esta activo lo cerramos al igual que la conexion
        {
            if (lector != null) lector.Close();
            conexion.Close();
        }
    }
}
