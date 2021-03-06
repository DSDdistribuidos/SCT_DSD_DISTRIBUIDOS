﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestEmpresaService.TarifaWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TarifaWS.ITarifa")]
    public interface ITarifa {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITarifa/RegistrarTarifa", ReplyAction="http://tempuri.org/ITarifa/RegistrarTarifaResponse")]
        SCTServiceWCF.Dominio.Tarifa RegistrarTarifa(string NOM_TARIFA, decimal PRECIO, string MONEDA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITarifa/ModificarTarifa", ReplyAction="http://tempuri.org/ITarifa/ModificarTarifaResponse")]
        SCTServiceWCF.Dominio.Tarifa ModificarTarifa(int ID_TARIFA, string NOM_TARIFA, decimal PRECIO, string MONEDA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITarifa/EliminarTarifa", ReplyAction="http://tempuri.org/ITarifa/EliminarTarifaResponse")]
        void EliminarTarifa(int ID_TARIFA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITarifa/ObtenerTarifa", ReplyAction="http://tempuri.org/ITarifa/ObtenerTarifaResponse")]
        SCTServiceWCF.Dominio.Tarifa ObtenerTarifa(int ID_TARIFA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITarifa/ListarTarifa", ReplyAction="http://tempuri.org/ITarifa/ListarTarifaResponse")]
        SCTServiceWCF.Dominio.Tarifa[] ListarTarifa();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITarifaChannel : TestEmpresaService.TarifaWS.ITarifa, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TarifaClient : System.ServiceModel.ClientBase<TestEmpresaService.TarifaWS.ITarifa>, TestEmpresaService.TarifaWS.ITarifa {
        
        public TarifaClient() {
        }
        
        public TarifaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TarifaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TarifaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TarifaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SCTServiceWCF.Dominio.Tarifa RegistrarTarifa(string NOM_TARIFA, decimal PRECIO, string MONEDA) {
            return base.Channel.RegistrarTarifa(NOM_TARIFA, PRECIO, MONEDA);
        }
        
        public SCTServiceWCF.Dominio.Tarifa ModificarTarifa(int ID_TARIFA, string NOM_TARIFA, decimal PRECIO, string MONEDA) {
            return base.Channel.ModificarTarifa(ID_TARIFA, NOM_TARIFA, PRECIO, MONEDA);
        }
        
        public void EliminarTarifa(int ID_TARIFA) {
            base.Channel.EliminarTarifa(ID_TARIFA);
        }
        
        public SCTServiceWCF.Dominio.Tarifa ObtenerTarifa(int ID_TARIFA) {
            return base.Channel.ObtenerTarifa(ID_TARIFA);
        }
        
        public SCTServiceWCF.Dominio.Tarifa[] ListarTarifa() {
            return base.Channel.ListarTarifa();
        }
    }
}
