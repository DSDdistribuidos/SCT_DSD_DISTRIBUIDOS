using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SCTServiceWCF.Dominio
{
    [DataContract]
    public class ReporteVenta
    {
        [DataMember]
        public int ID_TARIFA { get; set; }
        [DataMember]
        public string NOM_TARIFA { get; set; }
        [DataMember]
        public decimal PRECIO { get; set; }
        [DataMember]
        public string MONEDA { get; set; }
    }
}