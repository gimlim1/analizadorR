using R2PB.AnalisisCodigo.SI.Repositorios.Contratos;
using R2PB.AnalisisCodigo.SI.Datos.Repositorios;
using System;
using R2PB.AnalisisCodigo.DS.Repositorios;

namespace R2PB.AnalisisCodigo.BS.Repositorios
{
    public class Repositorios : IRepositorios
    {
        public void GuardeElRepositorio(Commit[] losCommits, int idPaquete)
        {
            Registrador elRegistrador = new Registrador();
            elRegistrador.Registre(idPaquete, losCommits);
        }

        public bool ValideSiSeDebeAnalizar(Commit[] losCommits)
        {
            Consultante elConsultante = new Consultante();
            return elConsultante.Consulte(losCommits);
        }

    }
}