using Microsoft.VisualStudio.TestTools.UnitTesting;
using R2PB.AnalisisCodigo.AC.SolucionesCodigoFuente;
using R2PB.AnalisisCodigo.RM.Repositorios;

namespace R2PB.AnalisisCodigo.Pruebas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string ruta = @"C:\Users\rpineda\Desktop\PaqueteAnalizar\QuasarRAT.sln";
            string ruta2 = "https://github.com/martinnbasile/aerolineaFRBA";
            Almacenador elAlmacenador = new Almacenador();
            elAlmacenador.Almacene(ruta);
        }
    }
}
