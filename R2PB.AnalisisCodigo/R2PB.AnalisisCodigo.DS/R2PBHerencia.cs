//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace R2PB.AnalisisCodigo.DS
{
    using System;
    using System.Collections.Generic;
    
    public partial class R2PBHerencia
    {
        public int IdHerencia { get; set; }
        public int IdClase { get; set; }
        public string HerenciaDeclarada { get; set; }
        public int IdProyecto { get; set; }
        public int IdPaquete { get; set; }
    
        public virtual R2PBClase R2PBClase { get; set; }
    }
}
