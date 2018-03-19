using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace LogicaExcepciones
{
    [ServiceContract]
    public interface IServicioTexto
    {
        [OperationContract]
        [FaultContract(typeof(TextoVacioException))]
        String ConvertirMinusculas(String texto);
    }
}
