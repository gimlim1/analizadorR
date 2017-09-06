using Microsoft.CodeAnalysis;
using R2PB.AnalisisCodigo.AC.ClienteAnalisis;
using System.IO;

namespace R2PB.AnalisisCodigo.AC.Paquetes
{
    public class Constructor
    {
        public Paquete Construya(Solution laSolucion)
        {
            Paquete elPaquete = new Paquete();
            elPaquete.IdSolucion = laSolucion.Id.Id.ToString();
            elPaquete.NombrePaquete =  Path.GetFileName(laSolucion.FilePath);

            return elPaquete;
        }
    }
}
