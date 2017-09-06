using R2PB.AnalisisCodigo.SI.Datos.Proyectos;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace R2PB.AnalisisCodigo.SI.Datos.Paquetes
{
    [DataContract]
    public class Paquete
    {
        [DataMember]
        public string NombrePaquete;
        [DataMember]
        public string IdSolucion;
        [DataMember]
        public List<Proyecto> Proyectos;

        public Paquete(string elId, string nombre) {
            this.NombrePaquete = nombre;
            this.IdSolucion = elId;
            this.Proyectos = new List<Proyecto>();
        }
    }
}
