using LibGit2Sharp;

namespace R2PB.AnalisisCodigo.RM.Repositorios
{
    public class Clonador
    {
        public void Clone(string repositorio,string workSpace) {
            Repository.Clone(repositorio, workSpace);
        }

    }
}
