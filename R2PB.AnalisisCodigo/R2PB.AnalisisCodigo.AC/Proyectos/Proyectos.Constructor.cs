using Microsoft.CodeAnalysis;
using R2PB.AnalisisCodigo.AC.ClienteAnalisis;

namespace R2PB.AnalisisCodigo.AC.Proyectos
{
  public class Constructor
  {
    public Proyecto Construya(Project proyectoCompilado)
    {
       Proyecto proyectoConvertido = new Proyecto();
       proyectoConvertido.NombreProyecto = proyectoCompilado.Name;
       proyectoConvertido.Lenguaje = proyectoCompilado.Language;
       proyectoConvertido.IdProyecto = proyectoCompilado.Id.Id.ToString();

       return proyectoConvertido;
    }

  }

}
