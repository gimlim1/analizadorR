using System.ServiceModel;
using R2PB.AnalisisCodigo.SI.Datos.Bitacoras;

namespace R2PB.AnalisisCodigo.SI.Bitacoras.Contratos
{
    [ServiceContract]
    public interface IBitacora
    {
        [OperationContract]
        void RegistreError(Bitacora laBitacora);
    }
}
