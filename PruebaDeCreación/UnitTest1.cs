using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaDeCreación
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaCrear()
        {
            ColaboradorService.ColaboradoresClient proxy = new ColaboradorService.ColaboradoresClient();
            ColaboradorService.Colaborador colaboradorCreado = proxy.CrearColaborador(new ColaboradorService.Colaborador()
            {
                codigo = 13,
                nombre = "Roger",
                fechanacimiento = Convert.ToDateTime("20/05/2016 11:50 p.m."),
                ingreso = Convert.ToDateTime("20/05/2016 11:50 p.m."),
                cargo = "Administrador"
            });
            Assert.AreEqual(13, colaboradorCreado.codigo);
            Assert.AreEqual("Roger", colaboradorCreado.nombre);
            Assert.AreEqual(Convert.ToDateTime("20/05/2016 11:50 p.m."), colaboradorCreado.fechanacimiento);
            Assert.AreEqual(Convert.ToDateTime("20/05/2016 11:50 p.m."), colaboradorCreado.ingreso);
            Assert.AreEqual("Administrador", colaboradorCreado.cargo);
        }
    }
}
