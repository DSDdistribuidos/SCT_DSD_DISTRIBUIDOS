using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SCTServiceWCF.Persistencia;
using SCTServiceWCF.Dominio;

namespace SCTServiceWCF.Servicios
{
    public class Centros : ICentros
    {
        private CentroDAO centroDAO = null;
        private CentroDAO CentroDAO
        {
            get
            {
                if (centroDAO == null)
                    centroDAO = new CentroDAO();
                return centroDAO;
            }
        }

        private EmpresaDAO empresaDAO = null;
        private EmpresaDAO EmpresasDAO
        {
            get
            {
                if (empresaDAO == null)
                    empresaDAO = new EmpresaDAO();
                return empresaDAO;
            }
        }


        public Centro CrearCentro(string descripcion, int empresa)
        {
            Empresa empresaExistente = EmpresasDAO.Obtener(empresa);
            Centro centroACrear = new Centro()
            {
                Descripcion = descripcion,
                Empresa = empresaExistente
            };
            return CentroDAO.Crear(centroACrear);
        }

        public Centro ObtenerCentro(int codigo)
        {
            return CentroDAO.Obtener(codigo);
        }

        public List<Centro> ListarCentro()
        {
            return CentroDAO.ListarTodos().ToList();
        }
    }
}
