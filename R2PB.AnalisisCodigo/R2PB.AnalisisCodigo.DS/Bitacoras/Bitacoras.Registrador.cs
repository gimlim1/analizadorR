using R2PB.AnalisisCodigo.SI.Datos.Bitacoras;

namespace R2PB.AnalisisCodigo.DS.Bitacoras
{
    public class Registrador
    {
        public void Registre(Bitacora laBitacora) {
                using (var contexto = new AnalisisCodigoEntities())
                {
                    contexto.R2PBBitacora.Add(ConstruyaLaBitacora(laBitacora));
                    contexto.SaveChanges();
                    
                }
            }  
        

        private R2PBBitacora ConstruyaLaBitacora(Bitacora laBitacora) {
            R2PBBitacora laBitacoraconvertida = new R2PBBitacora();
            laBitacoraconvertida.IdSolucion = laBitacora.IdSolucion;
            laBitacoraconvertida.Mensaje = laBitacora.Mensaje;
            laBitacoraconvertida.StackTrace = laBitacora.StackTrace;
            laBitacoraconvertida.Componente = (int)laBitacora.Tipo;
            laBitacoraconvertida.InformacionExepcion = laBitacora.MasInformacionExcepcion;
            return laBitacoraconvertida;
        }

    }
}
