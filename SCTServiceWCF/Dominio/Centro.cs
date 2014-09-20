using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SCTServiceWCF.Dominio
{
    [DataContract]
    public class Centro
    {
        //https://github.com/jmallqui/SCT_DSD_DISTRIBUIDOS.git
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public Empresa Empresa { get; set; }
    }
}