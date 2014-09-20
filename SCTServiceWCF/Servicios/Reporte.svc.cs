using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SCTServiceWCF.Persistencia;
using SCTServiceWCF.Dominio;

namespace SCTServiceWCF.Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Reportes" en el código, en svc y en el archivo de configuración a la vez.
    public class Reportes : IReportes
    {

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

        public List<Reporte> ListarVentas()
        {
            return ReporteDAO.ListarTodos().ToList();
        }
    } 
}

