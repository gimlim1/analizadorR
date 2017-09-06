using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;

namespace R2PB.AnalisisCodigo.AC.Proyectos
{

  public class Consultante
  {
    public List<Project> Consulte(Solution laSolucion)
    {
      List<Project> laListaDeProyectos = new List<Project>();
      laListaDeProyectos = laSolucion.Projects.ToList();
      return laListaDeProyectos;
    }

  }
}
