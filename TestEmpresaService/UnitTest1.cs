using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCTServiceWCF.Dominio;
using SCTServiceWCF.Servicios;

namespace TestEmpresaService
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CrearEmpresaTest()
        {
            Empresas EmpresaWS = new Empresas();
            Empresa resultado = EmpresaWS.CrearEmpresa("Transporte Vergara", "104334634432", "5563232", "su casa en donde no lo se");
            Assert.AreEqual("Transporte Vergara", resultado.EMPRESA);
        }

        [TestMethod]
        public void ObtenerEmpresaTest()
        {
            Empresas EmpresaWS = new Empresas();
            Empresa resultado = EmpresaWS.ObtenerEmpresa(25);
            Assert.AreEqual("Empresa el Ande", resultado.EMPRESA);
        }

        [TestMethod]
        public void ModificarEmpresaTest()
        {
            Empresas EmpresaWS = new Empresas();
            Empresa resultado = EmpresaWS.ModificarEmpresa(25, "Empresa el Andesssss", "343234565675", "453212", "su domicilio");
            Assert.AreEqual("Empresa el Andesssss", resultado.EMPRESA);
        }
        [TestMethod]
        public void EliminarEmpresaTest()
        {
            Empresas EmpresaWS = new Empresas();
            EmpresaWS.EliminarEmpresa(33);
            Empresa obtener = EmpresaWS.ObtenerEmpresa(33);
            Assert.AreEqual(null, obtener);

        }
        [TestMethod]
        public void ListarEmpresaTest()
        {
            Empresas EmpresaWS = new Empresas();
            List<Empresa> resultado = EmpresaWS.ListarEmpresa();
            Assert.AreEqual(18, resultado.Count);
        }

    


    }
}
