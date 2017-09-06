using R2PB.AnalisisCodigo.AC.ClienteAnalisis;
using R2PB.AnalisisCodigo.BC;
using System;


namespace R2PB.AnalisisCodigo.AC.SolucionesCodigoFuente
{
    public class Almacenador
    {
        public int Almacene(string laRuta)
        {
            Paquete elPaquete = new Paquete();
            Analizador elAnalizador = new Analizador();
            elPaquete = elAnalizador.Analice(laRuta);
            SolucionesCodigoFuenteClient cliente = new SolucionesCodigoFuenteClient();
            try
            {
                return cliente.GuardeElPaquete(elPaquete);
            }
            catch (Exception laExcepcion)
            {
                Bitacoras.Registrador elRegistrador = new Bitacoras.Registrador();
                elRegistrador.Registre(laExcepcion, elPaquete.IdSolucion, Componentes.WebService);
            }
            finally
            {
                cliente.Close();
            }
            return 0;
        }
    }
}
