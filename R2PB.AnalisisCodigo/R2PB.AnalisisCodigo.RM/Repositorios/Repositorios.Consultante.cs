using Octokit;
using R2PB.AnalisisCodigo.RM.Bitacoras;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace R2PB.AnalisisCodigo.RM.Repositorios
{
    public class Consultante
    {
        public void Consulte(int IdPaquete,string url) {
         
            string[] datosUrl = url.Split('/');
            string usuario = datosUrl[3];
            string repositorio = datosUrl[4];
            Commit[] losCommits = Construya(ObtengaInformacionRepositorio(usuario, repositorio,IdPaquete),usuario,repositorio);
            RepositoriosClient cliente = new RepositoriosClient();
            try
            {
                cliente.GuardeElRepositorio(losCommits, IdPaquete);
            }
            catch (Exception laExcepcion)
            {
                Registrador elRegistrador = new Registrador();
                elRegistrador.Registre(laExcepcion, IdPaquete.ToString(), Componentes.WebService);
            }
            finally
            {
                cliente.Close();
            }
        }
        public bool ConsulteSiExisteUltimaVersion(string url)
        {
            bool existe = false;
            string[] datosUrl = url.Split('/');
            string usuario = datosUrl[3];
            string repositorio = datosUrl[4];
            Commit[] losCommits = Construya(ObtengaInformacionRepositorio(usuario, repositorio, 0), usuario, repositorio);
            RepositoriosClient cliente = new RepositoriosClient();
            try
            {
                existe = cliente.ValideSiSeDebeAnalizar(losCommits);
            }
            catch (Exception laExcepcion)
            {
                Registrador elRegistrador = new Registrador();
                elRegistrador.Registre(laExcepcion, "0", Componentes.WebService);
            }
            finally
            {
                cliente.Close();
            }

            return existe;
        }

        private Commit[] Construya(Task<IReadOnlyList<GitHubCommit>> losCommits,string usuario,string repositorio) {
            List<Commit> losCommitsConvertidos = new List<Commit>();
            foreach (GitHubCommit elCommit in losCommits.Result.ToList()) {
                Commit elCommitConvertido = new Commit();
                elCommitConvertido.AutorCommit = elCommit.Commit.Author.Name;
                elCommitConvertido.Fecha = elCommit.Commit.Author.Date.DateTime;
                elCommitConvertido.Hash = elCommit.Sha;
                elCommitConvertido.NombreAutorRepositorio = usuario;
                elCommitConvertido.NombreRepositorio = repositorio;
                losCommitsConvertidos.Add(elCommitConvertido);

            }
            return losCommitsConvertidos.ToArray();
        }

        private Task<IReadOnlyList<GitHubCommit>> ObtengaInformacionRepositorio(string usuario, string repositorio,int IdPaquete)
        {
            Task<IReadOnlyList<GitHubCommit>> commits = null;
            try {
                GitHubClient github = new GitHubClient(new ProductHeaderValue("RP2BAcceso"));
                github.Connection.Credentials = new Credentials("AnalisisRepositorioR2BP", "rastaloca123");
                commits = github.Repository.Commit.GetAll(usuario, repositorio);
                commits.Wait();
            } catch (Exception laExcepcion) {
                Registrador elRegistrador = new Registrador();
                elRegistrador.Registre(laExcepcion, IdPaquete.ToString(), Componentes.AnalizadorRepositorio);
            }

            return commits;
        }

        public FileInfo[] ObtengaLaRutaDeLaSolucion(string carpeta)
        {
            DirectoryInfo directorioPrincipal = new DirectoryInfo(carpeta);
            DirectoryInfo[] subdirectorios = directorioPrincipal.GetDirectories();
            FileInfo[] informacionArchivos = null;

            foreach (DirectoryInfo subdirectorio in subdirectorios) {
                informacionArchivos = subdirectorio.GetFiles("*.sln");
                if (informacionArchivos.Count() >= 1) {
                    break;
                }
            }

            if (informacionArchivos.Count() == 0) {
                informacionArchivos=  directorioPrincipal.GetFiles("*.sln");         
            }

            return informacionArchivos;
        }
    }
}
