using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SCTServiceWCF.Dominio;

namespace SCTServiceWCF.Servicios
{
    [ServiceContract]
    public interface IReportes
    {
        [OperationContract]
        List<Reportes> ListarVentas();
    }
}