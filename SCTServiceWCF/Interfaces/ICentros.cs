using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SCTServiceWCF.Servicios
{
    [ServiceContract]
    public interface ICentros
    {
        [OperationContract]
        Centros CrearCentro(string descripcion, int empresa);
        [OperationContract]
        Centros ObtenerCentro(int codigo);
        [OperationContract]
        List<Centros> ListarCentro();
    }
}
