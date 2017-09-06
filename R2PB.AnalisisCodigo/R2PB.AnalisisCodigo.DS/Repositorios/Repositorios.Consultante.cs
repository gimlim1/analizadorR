using R2PB.AnalisisCodigo.SI.Datos.Repositorios;
using System.Linq;

namespace R2PB.AnalisisCodigo.DS.Repositorios
{
    public class Consultante
    {
        public bool Consulte(Commit[] losCommits) {
            bool existe = false;
            using (var contexto = new AnalisisCodigoEntities())
            {
                Commit elUltimoCommit = losCommits[0];
                R2PBRepositorio elUltimoRegistro = contexto.R2PBRepositorio.ToList()
                                                  .Where(filtro => filtro.NombreRepositorio == elUltimoCommit.NombreRepositorio
                                                        && filtro.NombreAutorRepositorio == elUltimoCommit.NombreAutorRepositorio
                                                        && filtro.Hash == elUltimoCommit.Hash).FirstOrDefault();
                if (elUltimoRegistro != null)
                    existe = true;
            }

            return existe;
        }

    }
}
