using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;
using SCTServiceWCF.Dominio;

namespace SCTServiceWCF.Interfaces
{
    [ServiceContract]
    public interface IReporteVenta
    {
        #region Metodos para la Administrar un Tarifa
        [OperationContract]
        List<ReporteVenta> ListarReporteVentas();
        #endregion
    }
}