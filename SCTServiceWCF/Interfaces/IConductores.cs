using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SCTServiceWCF.Dominio;

namespace SCTServiceWCF.Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IConductores" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IConductores
    {
        [OperationContract]
        Conductor CrearConductor(string nombres_apellidos, string dni, string sexo, string sede, string condicion, string cargo, string licencia, int empresa );
    }
}
