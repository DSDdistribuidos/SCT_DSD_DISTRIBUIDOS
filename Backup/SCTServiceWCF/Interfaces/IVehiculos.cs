using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SCTServiceWCF.Dominio;

namespace SCTServiceWCF.Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IVehiculos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IVehiculos
    {
        [OperationContract]
        Vehiculo CrearVehiculo(int ID_VEHICULO, string PLACA, string MODELO, string MARCA, string ANNIO_FABRICACION, string NRO_UNIDAD, int ID_EMPRESA);
        [OperationContract]
        Vehiculo ObtenerVehiculo(int ID_VEHICULO);
        [OperationContract]
        Vehiculo ModificarVehiculo(int ID_VEHICULO, string PLACA, string MODELO, string MARCA, string ANNIO_FABRICACION, string NRO_UNIDAD, int id_empresa);
        [OperationContract]
        List<Vehiculo> ListarVehiculo();
        [OperationContract]
        Vehiculo EliminarVehiculo(int ID_VEHICULO, string PLACA, string MODELO, string MARCA, string ANNIO_FABRICACION, string NRO_UNIDAD, int id_empresa, int FLAG_ANULA);


    }
}
