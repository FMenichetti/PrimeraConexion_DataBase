using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Libreria para comunicarme con mi servidor sql
using Dominio;

namespace Negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> Listar() //Creo el metodo de tipo lista
        {
            List<Pokemon> lista = new List<Pokemon>(); // Creo una lista de pokemones
            SqlConnection conexion = new SqlConnection(); //Creo una conexion con el servidor
            SqlCommand comando = new SqlCommand(); //Creo los comandos con los que voy a mandar acciones
            SqlDataReader lector; //este lector lee y trae valores con formato sql reader y no puede heredarse

            try
            {
                //A travez del string le decimos a que servidor apuntamos, a que base de datos y el tipo de seguridad que vamos a manejar. 
                //Si el servidor es local podemos poner antes de las barras (local), un punto. esto nos ahorra cambiar el codigo en caso de cambio de pc
                //cuando nos conectamos a un servidor remoto, va el IP y luego las barras
                conexion.ConnectionString = "server=DESKTOP-A78M7US\\SQLEXPRESS; database = POKEDEX_DB; integrated security = true";
                //Creamos el tipo de comando a utilizar
                comando.CommandType = System.Data.CommandType.Text;
                //Enviamos el comando de texto a la DB, es el mismo request que escribimos en SLQ server, lo recomendable es probarlo antes alli
                comando.CommandText = "Select Numero, Nombre, p.descripcion ,p.UrlImagen,  e.Descripcion Tipo, d.Descripcion debilidad from  POKEMONS P, ELEMENTOS E, ELEMENTOS D where p.IdTipo = e.Id and p.IdTipo = d.Id";
                //Guardamos la conexion en el comando
                comando.Connection = conexion;
                //Abrimos conexion
                conexion.Open();
                //ejecutamos el lector
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    //Mientras el lector lea algo, ejecutamos el while. Vamos leyendo y mapeando
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["UrlImagen"];
                    //Como el objeto Tipo no existe, tenemos una referencia nula y hay que crear si o si el elemento para esto
                    aux.Tipo = new Elemento();
                    //una vez que lo creamos ya podemos usar el atributo descripcion de elemento
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];
                    //Aderimos a la lista lo que ya guardamos en el objeto aux
                    lista.Add(aux);
                }
                //cerramos conexion
                conexion.Close();
                //retornamos la lista
                return lista;

            
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
