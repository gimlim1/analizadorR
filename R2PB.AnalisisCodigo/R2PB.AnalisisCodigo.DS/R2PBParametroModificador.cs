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
    
    public partial class R2PBParametroModificador
    {
        public int IdModificador { get; set; }
        public int IdParametro { get; set; }
        public string Modificador { get; set; }
    
        public virtual R2PBParametro R2PBParametro { get; set; }
    }
}
