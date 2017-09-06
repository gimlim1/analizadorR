using R2PB.AnalisisCodigo.SI.SolucionesCodigoFuente.Contratos;
using R2PB.AnalisisCodigo.SI.Datos.Paquetes;
using R2PB.AnalisisCodigo.DS.SolucionesCodigoFuente;

namespace R2PB.AnalisisCodigo.BS.SolucionesCodigoFuente
{
    public class SolucionesCodigoFuente : ISolucionesCodigoFuente
    {
        public int GuardeElPaquete(Paquete elPaquete)
        {
            Registrador elRegistrador = new Registrador();
            return elRegistrador.Registre(elPaquete);
        }
    }
}