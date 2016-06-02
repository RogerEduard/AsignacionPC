using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RESTServicePersonas.Dominio;
using RESTServicePersonas.Persistencia;
using RESTServicePersonas.Errores;
using System.Net;

namespace RESTServicePersonas
{
    
    public class Personas : IPersonas
    {
        private PersonaDAO dao = new PersonaDAO();
        public Persona ObtenerPersona(string dni)
        {

            Persona p = dao.Obtener(dni);

            if (p == null)
            {
                throw new WebFaultException<string>("DNI no existe", HttpStatusCode.InternalServerError);
                //throw new WebFaultException<RepetidoExcepcion>
                //(
                //    new RepetidoExcepcion()
                //    {
                //        Codigo = "101",
                //        Descripcion = "DNI no existe"
                //    },
                //    HttpStatusCode.NotFound);      
            }
            else
            // if (p.ToString() == String.Empty)
            //{
            //    throw new WebFaultException<string>("Ingrese un número de DNI", HttpStatusCode.BadRequest);
            //}
                if (p.estado == "I")
                {
                    throw new WebFaultException<string>("DNI Inactivo", HttpStatusCode.ExpectationFailed);
                }

            return p;
        }
    }
}
