using R2PB.AnalisisCodigo.SI.Bitacoras.Contratos;
using R2PB.AnalisisCodigo.SI.Datos.Bitacoras;
using R2PB.AnalisisCodigo.DS.Bitacoras;

namespace R2PB.AnalisisCodigo.BS.Bitacoras
{
    public class Bitacoras : IBitacora
    {
        public void RegistreError(Bitacora laBitacora)
        {
            Registrador elRegistrador = new Registrador();
            elRegistrador.Registre(laBitacora);
        }

    }
}