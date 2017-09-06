using System.Collections.Generic;

namespace R2PB.AnalisisCodigo.SI.Datos.Metodos
{
    public class Metodo
    {
        public string NombreMetodo;
        public string Visibilidad;
        public string Retorno;
        public int LineaComienzo;
        public int LineaFinal;
        public List<Parametro> Parametros;
        public List<Control> Controles;
    }
}
