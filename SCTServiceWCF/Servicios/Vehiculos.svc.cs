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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Vehiculos" en el código, en svc y en el archivo de configuración a la vez.
    public class Vehiculos : IVehiculos
    {

        private VehiculoDAO vehiculoDAO = null;
        private VehiculoDAO VehiculoDAO
        {
            get
            {
                if (vehiculoDAO == null)
                    vehiculoDAO = new VehiculoDAO();
                return vehiculoDAO;

            }


        }

        private EmpresaDAO empresaDAO = null;
        private EmpresaDAO EmpresaDAO
        {
            get
            {
                if (empresaDAO == null)
                    empresaDAO = new EmpresaDAO();
                return empresaDAO;

            }


        }

        public Vehiculo CrearVehiculo(int ID_VEHICULO, string PLACA, string MODELO, string MARCA, string ANNIO_FABRICACION, string NRO_UNIDAD, int id_empresa)
        {
            Empresa empresaExiste = EmpresaDAO.Obtener(id_empresa);
            Vehiculo VehiculoACrear = new Vehiculo()
            {
                //ID_VEHICULO = ID_VEHICULO,
                PLACA = PLACA,
                MODELO = MODELO,
                MARCA = MARCA,
                ANNIO_FABRICACION = ANNIO_FABRICACION,
                NRO_UNIDAD = NRO_UNIDAD,
                ID_EMPRESA = empresaExiste.ID_EMPRESA,

            };
            return VehiculoDAO.Crear(VehiculoACrear);
        }

        public Vehiculo ObtenerVehiculo(int ID_VEHICULO)
        {

            return VehiculoDAO.Obtener(ID_VEHICULO);
        }

        public Vehiculo ModificarVehiculo(int ID_VEHICULO, string PLACA, string MODELO, string MARCA, string ANNIO_FABRICACION, string NRO_UNIDAD, int id_empresa)
        {
            Vehiculo vehiculoaAModificar = new Vehiculo()

            {

                ID_VEHICULO = ID_VEHICULO,
                PLACA = PLACA,
                MODELO = MODELO,
                MARCA = MARCA,
                ANNIO_FABRICACION = ANNIO_FABRICACION,
                NRO_UNIDAD = NRO_UNIDAD,
                ID_EMPRESA = id_empresa,

            };

            return VehiculoDAO.Modificar(vehiculoaAModificar);
        }

        public List<Vehiculo> ListarVehiculo()
        {
            return VehiculoDAO.ListarTodos().ToList();
        }



        public Vehiculo EliminarVehiculo(int ID_VEHICULO, string PLACA, string MODELO, string MARCA, string ANNIO_FABRICACION, string NRO_UNIDAD, int id_empresa, int FLAG_ANULA)
        {
            Vehiculo vehiculoaAEliminar = new Vehiculo()
            {
                ID_VEHICULO = ID_VEHICULO,
                PLACA = PLACA,
                MODELO = MODELO,
                MARCA = MARCA,
                ANNIO_FABRICACION = ANNIO_FABRICACION,
                NRO_UNIDAD = NRO_UNIDAD,
                ID_EMPRESA = id_empresa,
                FLAG_ANULA = FLAG_ANULA,
            };
            //return VehiculoDAO.Eliminar(vehiculoaAEliminar);
            return VehiculoDAO.Modificar(vehiculoaAEliminar);


        }

    }

}
