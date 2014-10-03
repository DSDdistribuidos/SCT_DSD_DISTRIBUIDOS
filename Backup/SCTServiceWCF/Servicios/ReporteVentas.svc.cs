using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SCTServiceWCF.Persistencia.AccesoDatos;
using SCTServiceWCF.Dominio;

namespace SCTServiceWCF.Interfaces
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AdministrarReporte" en el código, en svc y en el archivo de configuración a la vez.
    public class ReporteVentas : IReporteVenta
    {

        #region Dependencias
        private ReporteDAO reporteDAO = null;
        private ReporteDAO ReporteDAO
        {
            get
            {
                if (reporteDAO == null)
                    reporteDAO = new ReporteDAO();
                return reporteDAO;
            }
        }
        #endregion

        public List<ReporteVenta> ListarReporteVentas()
        {
            return ReporteDAO.ListarReporteVentas();
        }
    }
}
