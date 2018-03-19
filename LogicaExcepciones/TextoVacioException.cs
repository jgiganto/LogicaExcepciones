using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LogicaExcepciones
{
    [DataContract]
   public class TextoVacioException:Exception
    {
        [DataMember]
        public String Mensaje { get; set; }
        public TextoVacioException(String detalleerror)
        {
            this.Mensaje = detalleerror;
        }
    }
}
