using R2PB.AnalisisCodigo.SI.Datos.Repositorios;
using System.ServiceModel;

namespace R2PB.AnalisisCodigo.SI.Repositorios.Contratos
{
    [ServiceContract]
    public interface IRepositorios
    {
        [OperationContract]
        void GuardeElRepositorio(Commit[] losCommits, int idPaquete);

        [OperationContract]
        bool ValideSiSeDebeAnalizar(Commit[] losCommits);
    }

}