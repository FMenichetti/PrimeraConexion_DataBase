using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Elemento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        //Cuando pedimos el valor desde dataRead, esta clase al ser instanciada pasa el valor del ToString
        // entonces lo sobreescribimos para que me muestre la descripcion cuando se instancie la misma
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
