using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using R2PB.AnalisisCodigo.AC.ClienteAnalisis;
using R2PB.AnalisisCodigo.AC.Proyectos;
using R2PB.AnalisisCodigo.BC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R2PB.AnalisisCodigo.AC.SolucionesCodigoFuente
{
    public class Analizador
    {
        public Paquete Analice(string ruta)
        {
            Paquete elPaquete = null;
            List<Project> losProyectos = null;
            try
            {
                Solution laSolucion = ConstruyaLaSolucion(ruta);
                elPaquete = new Paquete();
                Paquetes.Constructor elConstructorDePaquetes = new Paquetes.Constructor();
                elPaquete = elConstructorDePaquetes.Construya(laSolucion);

                losProyectos = new List<Project>();
                Consultante elConsultante = new Consultante();
                losProyectos = elConsultante.Consulte(laSolucion);

            }
            catch (Exception laExcepcion)
            {
                Bitacoras.Registrador elRegistrador = new Bitacoras.Registrador();
                elRegistrador.Registre(laExcepcion, "", Componentes.AnalizadorCodigoFuente);
            }


            List<Proyecto> losProyectosConvertidos = new List<Proyecto>();
            foreach (Project proyectoCompilado in losProyectos)
            {
                try
                {
                    Proyecto proyecto = new Proyecto();
                    Constructor elConstructor = new Constructor();
                    proyecto = elConstructor.Construya(proyectoCompilado);

                    var resultadoCompilacion = proyectoCompilado.GetCompilationAsync().Result;
                    proyecto.Clases = ConstruyaLaClase(resultadoCompilacion.SyntaxTrees.ToList(), elPaquete.IdSolucion).ToArray();

                    losProyectosConvertidos.Add(proyecto);
                }
                catch (Exception laExcepcion)
                {
                    Bitacoras.Registrador elRegistrador = new Bitacoras.Registrador();
                    elRegistrador.Registre(laExcepcion, elPaquete.IdSolucion, Componentes.AnalizadorCodigoFuente);
                }
            }

            elPaquete.Proyectos = losProyectosConvertidos.ToArray();

            return elPaquete;
        }

        public List<Clase> ConstruyaLaClase(List<SyntaxTree> losArboles,string elIdSolucion)
        {
            List<Clase> claseList = new List<Clase>();
            foreach (SyntaxTree elArbol in losArboles)
            {
                Clases.Constructor constructor = new Clases.Constructor(elIdSolucion);
                constructor.Visit(elArbol.GetRoot());
                claseList.AddRange((IEnumerable<Clase>)constructor.lasClases);
            }
            return claseList;
        }

        private Solution ConstruyaLaSolucion(string ruta)
        {
            var workspace = MSBuildWorkspace.Create();
            var solucion = workspace.OpenSolutionAsync(ruta).Result;
            workspace.WorkspaceFailed += (o, e) =>
            {
                var ee = e;
            };

            return solucion;
        }
    }
}
