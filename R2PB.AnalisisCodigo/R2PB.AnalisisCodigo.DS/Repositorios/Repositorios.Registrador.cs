using R2PB.AnalisisCodigo.SI.Datos.Repositorios;

namespace R2PB.AnalisisCodigo.DS.Repositorios
{
    public class Registrador
    {
        public void Registre(int idPaquete,Commit[] losCommits) {
            using (var contexto = new AnalisisCodigoEntities())
            {
                foreach (Commit elCommit in losCommits) {
                    contexto.R2PBRepositorio.Add(Construya(elCommit,idPaquete));
                    contexto.SaveChanges();
                }
            }
        }

        private R2PBRepositorio Construya(Commit elCommit, int elIdPaquete)
        {
            R2PBRepositorio elRepositorioCovertido = new R2PBRepositorio();
            elRepositorioCovertido.NombreRepositorio = elCommit.NombreRepositorio;
            elRepositorioCovertido.NombreAutorRepositorio = elCommit.NombreAutorRepositorio;
            elRepositorioCovertido.AutorCommit = elCommit.AutorCommit;
            elRepositorioCovertido.Año = elCommit.Fecha.Year;
            elRepositorioCovertido.Dia = elCommit.Fecha.Day;
            elRepositorioCovertido.FechaCompleta = elCommit.Fecha;
            elRepositorioCovertido.Hash = elCommit.Hash;
            elRepositorioCovertido.Hora = elCommit.Fecha.Hour;
            elRepositorioCovertido.IdPaquete = elIdPaquete;
            elRepositorioCovertido.Mes = elCommit.Fecha.Month;
            elRepositorioCovertido.Minuto = elCommit.Fecha.Minute;
            elRepositorioCovertido.Segundo = elCommit.Fecha.Second;

            return elRepositorioCovertido;
        }

    }
}
