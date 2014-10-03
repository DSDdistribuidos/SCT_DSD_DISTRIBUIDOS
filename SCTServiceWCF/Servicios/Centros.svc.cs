﻿using System;
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
        #region Miembros de ICentros

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

        public Dominio.Centro CrearCentro(string descripcion, int empresa)
        {
            Centro CentroACrear = new Centro()
            {
                DESCRIPCION = descripcion,
                //EMPRESA = Empresa
            };
            return CentroDAO.Crear(CentroACrear);
        
        }
        public Dominio.Centro ObtenerCentro(int codigo)
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
