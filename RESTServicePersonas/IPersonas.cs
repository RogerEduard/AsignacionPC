using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RESTServicePersonas.Dominio;

namespace RESTServicePersonas
{
    [ServiceContract]
    public interface IPersonas
    {

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Personas/{dni}", ResponseFormat = WebMessageFormat.Json)]
        Persona ObtenerPersona(string dni);
        
    }


}
