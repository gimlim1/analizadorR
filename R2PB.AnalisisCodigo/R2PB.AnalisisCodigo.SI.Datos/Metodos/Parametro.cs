using System.Collections.Generic;

namespace R2PB.AnalisisCodigo.SI.Datos.Metodos
{
    public class Parametro
    {
        public string Nombre { set; get; }
        public string Tipo { set; get; }
        public bool EsStatico { set; get; }
        public List<string> TieneMasModificadores { set; get; }
    }
}
