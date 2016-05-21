using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaDeCreación
{
    /// <summary>
    /// Descripción resumida de UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTest2
    {
        public void PruebaModificar()
        {
            ColaboradorService.ColaboradoresClient proxy = new ColaboradorService.ColaboradoresClient();
            ColaboradorService.Colaborador colaboradormodificado = proxy.ModificarColaborador(new ColaboradorService.Colaborador()
            {
                codigo = 13,
                nombre = "Roger Paucar",
                fechanacimiento = Convert.ToDateTime("20/05/2016 11:50 p.m."),
                ingreso = Convert.ToDateTime("20/05/2016 11:50 p.m."),
                cargo = "Administrador"
            });
            Assert.AreEqual(13, colaboradormodificado.codigo);
            Assert.AreEqual("Roger Paucar", colaboradormodificado.nombre);
            Assert.AreEqual(Convert.ToDateTime("20/05/2016 11:50 p.m."), colaboradormodificado.fechanacimiento);
            Assert.AreEqual(Convert.ToDateTime("20/05/2016 11:50 p.m."), colaboradormodificado.ingreso);
            Assert.AreEqual("Administrador", colaboradormodificado.cargo);
        }
    }
}
