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
    public class Tarifas : ITarifa
    {

        #region Dependencias
        private TarifaDAO tarifaDAO = null;
        private TarifaDAO TarifaDAO
        {
            get
            {
                if (tarifaDAO == null)
                    tarifaDAO = new TarifaDAO();
                return tarifaDAO;
            }
        }
        #endregion

        public Dominio.Tarifa RegistrarTarifa(Dominio.Tarifa addTarifa)
        {
            Tarifa _addTarifa = new Tarifa();
            _addTarifa.NOM_TARIFA = addTarifa.NOM_TARIFA;
            _addTarifa.PRECIO = addTarifa.PRECIO;
            _addTarifa.MONEDA = addTarifa.MONEDA;
            return TarifaDAO.Crear(addTarifa);
        }

        public Dominio.Tarifa ModificarTarifa(Dominio.Tarifa editTarifa)
        {
            Tarifa _addTarifa = new Tarifa();
            _addTarifa.ID_TARIFA = editTarifa.ID_TARIFA;
            _addTarifa.NOM_TARIFA = editTarifa.NOM_TARIFA;
            _addTarifa.PRECIO = editTarifa.PRECIO;
            _addTarifa.MONEDA = editTarifa.MONEDA;

            return TarifaDAO.Modificar(editTarifa);
        }

        public void EliminarTarifa(Dominio.Tarifa deleteTarifa)
        {
            Tarifa objBungalows = TarifaDAO.Obtener(deleteTarifa.ID_TARIFA);
            TarifaDAO.Eliminar(objBungalows);
        }

        public Dominio.Tarifa ObtenerTarifa(int codigoTarifa)
        {
            return TarifaDAO.Obtener(codigoTarifa);
        }

        public ICollection<Dominio.Tarifa> ListarTarifa()
        {
            return TarifaDAO.ListarTodos();
        }
    }
}
