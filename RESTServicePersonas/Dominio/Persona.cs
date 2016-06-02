using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace RESTServicePersonas.Dominio
{
    [DataContract]
    public class Persona
    {

        [DataMember]
        public string dni { get; set; }

        [DataMember]
        public string nombre { get; set; }

        [DataMember]
        public string apellidopaterno { get; set; }

        [DataMember]
        public string apellidomaterno { get; set; }

        [DataMember]
        public DateTime nacimiento { get; set; }

        [DataMember]
        public string estado { get; set; }

    }
}