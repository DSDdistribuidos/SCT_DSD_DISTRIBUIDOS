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
    public interface ITarifa
    {
        
        #region Operaciones de negocio
        //Registra un nuevo Tarifa asociado aun Sede.
        [OperationContract]
        Tarifa RegistrarTarifa(Tarifa addTarifa);
        [OperationContract]
        Tarifa ModificarTarifa(Tarifa editTarifa);
        [OperationContract]
        void EliminarTarifa(Tarifa deleteTarifa);
        [OperationContract]
        Tarifa ObtenerTarifa(int codigoTarifa);
        #endregion

        #region Metodos para la Administrar un Tarifa
        [OperationContract]
        ICollection<Tarifa> ListarTarifa();
        #endregion
    }
}