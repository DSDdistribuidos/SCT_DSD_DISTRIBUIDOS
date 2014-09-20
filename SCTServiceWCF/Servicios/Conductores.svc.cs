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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Conductores" en el código, en svc y en el archivo de configuración a la vez.
    public class Conductores : IConductores
    {
        #region Miembros de IConductores

        private ConductorDAO conductorDAO = null;
        private ConductorDAO ConductorDAO
        {
            get
            {
                if (conductorDAO == null)
                    conductorDAO = new ConductorDAO();
                return conductorDAO;
            }
        }



        public Dominio.Conductor CrearConductor(string nombres_apellidos, string dni, string sexo, string sede, string condicion,
            string cargo, string licencia, int empresa)
        {
            Conductor ConductorACrear = new Conductor()
            {

                NOMBRES_APELLIDOS = nombres_apellidos,
                DNI = dni,
                SEXO = sexo,
                SEDE = sede,
                CONDICION = condicion,
                CARGO = cargo,
                LICENCIA = licencia,
                //EMPRESA = empresa
            };

            return ConductorDAO.Crear(ConductorACrear);
        }
    }

        #endregion
}
