using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaExcepciones
{
    public class ServicioTexto : IServicioTexto
    {
          
        public string ConvertirMinusculas(string texto)
        {
            if (texto == String.Empty)
            {
                throw new TextoVacioException("La cadena "+  texto +" no puede estar vacia");
            }
            else
            {
                return texto.ToLower();
            }
        }
    }
}
