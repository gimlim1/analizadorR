using R2PB.AnalisisCodigo.BC.Clases;
using R2PB.AnalisisCodigo.SI.Datos.Herencias;
using R2PB.AnalisisCodigo.SI.Datos.Metodos;
using R2PB.AnalisisCodigo.SI.Datos.Propiedades;
using R2PB.AnalisisCodigo.SI.Datos.Usings;
using System.Collections.Generic;

namespace R2PB.AnalisisCodigo.SI.Datos.Clases
{
    public class Clase
    {
        public string Visibilidad;
        public string Nombre;
        public Tipo Tipo;
        public string NameSpace;
        public int LineaComienzo;
        public int LineaFinal;
        public List<Metodo> Metodos;
        public List<Using> Usings;
        public List<Herencia> Herencias;
        public List<Propiedad> Propiedades;
    }
}
