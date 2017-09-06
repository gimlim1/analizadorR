using R2PB.AnalisisCodigo.SI.Datos.Paquetes;
using System.ServiceModel;

namespace R2PB.AnalisisCodigo.SI.SolucionesCodigoFuente.Contratos
{
        [ServiceContract]
        public interface ISolucionesCodigoFuente
        {
            [OperationContract]
            int GuardeElPaquete(Paquete elPaquete);
        }
    
}