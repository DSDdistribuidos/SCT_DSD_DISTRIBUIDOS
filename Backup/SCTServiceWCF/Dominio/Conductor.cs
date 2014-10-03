using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SCTServiceWCF.Dominio
{
    [DataContract]
    public class Conductor
    {
        [DataMember]
        public int ID_CHOFER { get; set; }
        [DataMember]
        public string NOMBRES_APELLIDOS { get; set; }
        [DataMember]
        public string DNI { get; set; }
        [DataMember]
        public string SEXO { get; set; }
        [DataMember]
        public string SEDE { get; set; }
        [DataMember]
        public string CONDICION { get; set; }
        [DataMember]
        public string CARGO { get; set; }
        [DataMember]
        public string LICENCIA { get; set; }
        [DataMember]
        public Empresa EMPRESA { get; set; }


    }
}