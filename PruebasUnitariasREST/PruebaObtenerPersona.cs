using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace PruebasUnitariasREST
{
    [TestClass]
    public class PruebaObtenerPersona
    {

        [TestMethod]
        public void ObtenerPersona() 
        {

            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:19434/Personas.svc/Personas/44444444");
                req.Method = "GET";
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string personaJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Persona personaObtenida = js.Deserialize<Persona>(personaJson);
                Assert.AreEqual("44444444", personaObtenida.dni);
                Assert.AreEqual("JOSE", personaObtenida.nombre);
                Assert.AreEqual("PEREZ", personaObtenida.apellidopaterno);
                Assert.AreEqual("SOLIS", personaObtenida.apellidomaterno);
                Assert.AreEqual(Convert.ToDateTime("1809/1991 02:30 p.m."), personaObtenida.nacimiento);
            }
            catch (WebException ex)
            {

                HttpStatusCode code = ((HttpWebResponse)ex.Response).StatusCode;
                if (Convert.ToInt32(code) == 500)
                {
                    string message = ((HttpWebResponse)ex.Response).StatusDescription;
                    StreamReader reader = new StreamReader(ex.Response.GetResponseStream());
                    string error = reader.ReadToEnd();
                    JavaScriptSerializer js1 = new JavaScriptSerializer();
                    string mensaje = js1.Deserialize<string>(error);
                    Assert.AreEqual("DNI no existe", mensaje);
                }
                else if (Convert.ToInt32(code) == 417)
                {
                    string message = ((HttpWebResponse)ex.Response).StatusDescription;
                    StreamReader reader = new StreamReader(ex.Response.GetResponseStream());
                    string error = reader.ReadToEnd();
                    JavaScriptSerializer js1 = new JavaScriptSerializer();
                    string mensaje = js1.Deserialize<string>(error);
                    Assert.AreEqual("DNI Inactivo", mensaje);
                    
                }
                //Console.WriteLine(mensaje);
            }        
        }

        //public PruebaObtenerPersona()
        //{
            
        //}

        //private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        //public TestContext TestContext
        //{
        //    get
        //    {
        //        return testContextInstance;
        //    }
        //    set
        //    {
        //        testContextInstance = value;
        //    }
        //}

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        //[TestMethod]
        //public void TestMethod1()
        //{
        //    //
        //    // TODO: Agregar aquí la lógica de las pruebas
        //    //
        //}
    }
}
