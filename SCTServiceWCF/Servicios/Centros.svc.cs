using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
<<<<<<< HEAD
<<<<<<< HEAD
using System.ServiceModel.Web;
=======
>>>>>>> origin/master
=======
>>>>>>> origin/master
using System.Text;
using SCTServiceWCF.Persistencia;
using SCTServiceWCF.Dominio;


namespace SCTServiceWCF.Servicios
{
    public class Centros : ICentros
    {
        #region Miembros de ICentros
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> origin/master
=======

>>>>>>> origin/master
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

<<<<<<< HEAD
<<<<<<< HEAD
        public Centro CrearCentro(string descripcion, int empresa)
=======
        public Dominio.Centro CrearCentro(string descripcion, int empresa)
>>>>>>> origin/master
=======
        public Dominio.Centro CrearCentro(string descripcion, int empresa)
>>>>>>> origin/master
        {
            Centro CentroACrear = new Centro()
            {
                DESCRIPCION = descripcion,
<<<<<<< HEAD
<<<<<<< HEAD
=======
                //EMPRESA = Empresa
>>>>>>> origin/master
=======
                //EMPRESA = Empresa
>>>>>>> origin/master
            };
            return CentroDAO.Crear(CentroACrear);
        
        }
<<<<<<< HEAD
<<<<<<< HEAD
        public Centro ObtenerCentro(int codigo)
=======
        public Dominio.Centro ObtenerCentro(int codigo)
>>>>>>> origin/master
=======
        public Dominio.Centro ObtenerCentro(int codigo)
>>>>>>> origin/master
        {
            return CentroDAO.Obtener(codigo);
        }
        public List<Centro> ListarCentro()
        {
            return CentroDAO.ListarTodos().ToList();
        }

    }
        #endregion
}
