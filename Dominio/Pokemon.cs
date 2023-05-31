using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pokemon
    {
        //Genero los atributos que va a tener mi pokemon, estos figuran en mi database tambien,
        //pueden no figurar? no lo se, si los quiero pedir creo que deberian estar si o si
        public int Numero { get; set; }
        public string  Nombre { get; set; }
        public string Descripcion { get; set; }
        public string  UrlImagen { get; set; }
        public Elemento Tipo { get; set; }
        public Elemento Debilidad { get; set; }

    }
}
