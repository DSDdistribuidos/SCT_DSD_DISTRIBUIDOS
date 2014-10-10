using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCTServiceWCF.Dominio;
using SCTServiceWCF.Persistencia;
using SCTServiceWCF.Servicios;
using SCTServiceWCF.Interfaces;

namespace TestTarifaService
{
     [TestClass]
    class TarifaTest
    {
        [TestMethod]
        public void CrearTarifaTest()
        {
            Tarifas TarifaWS = new Tarifas();
            Tarifa resultado = TarifaWS.RegistrarTarifa("PRUEBA",100, "D");
            Assert.AreEqual("PRUEBA", resultado.NOM_TARIFA);
        }

        [TestMethod]
        public void ObtenerTarifaTest()
        {
            Tarifas TarifaWS = new Tarifas();
            Tarifa resultado = TarifaWS.ObtenerTarifa(44);
            Assert.AreEqual("PRUEBA", resultado.NOM_TARIFA);
        }

        [TestMethod]
        public void ModificarTarifaTest()
        {
            Tarifas TarifaWS = new Tarifas();
            Tarifa resultado = TarifaWS.ModificarTarifa(50,"PRUEBA2", 100, "D");
            Assert.AreEqual("PRUEBA2", resultado.NOM_TARIFA);
        }
        [TestMethod]
        public void EliminarTarifaTest()
        {
            Tarifas TarifaWS = new Tarifas();
            TarifaWS.EliminarTarifa(33);
            Tarifa obtener = TarifaWS.ObtenerTarifa(33);
            Assert.AreEqual(null, obtener);

        }
        [TestMethod]
        public void ListarTarifaTest()
        {
            Tarifas TarifaWS = new Tarifas();
            ICollection<SCTServiceWCF.Dominio.Tarifa> resultado = TarifaWS.ListarTarifa();
            Assert.AreEqual(18, resultado.Count);
        }
    }
}
