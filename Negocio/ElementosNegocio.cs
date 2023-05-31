using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ElementosNegocio
    {
        public List<Elemento> listar()//Metodo tipo lista de elementos
        {
            List<Elemento> lista = new List<Elemento>();// creamos la lista
            AccesoDatos datos = new AccesoDatos();// Creamos la instancia nuestra nueva clase de acceso a datos

            try
            {
                datos.setearConsulta("select Id, Descripcion from ELEMENTOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Elemento aux = new Elemento();// Creamos un elemento, recordemos que estamso creando una lista de ellos
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Id = (int)datos.Lector["Id"];

                    lista.Add(aux);
                }
                return lista; //devolvemos la lista 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
