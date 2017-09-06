using System;

namespace R2PB.AnalisisCodigo.RM.Bitacoras
{
    public class Registrador
    {
        public void Registre(Exception laExcepcion, string IdSolucion, Componentes elComponente) {
            Bitacora laBitacora = new Bitacora();
            laBitacora.IdSolucion = IdSolucion;
            laBitacora.Mensaje = laExcepcion.Message;
            laBitacora.StackTrace = laExcepcion.StackTrace;
            laBitacora.Tipo = elComponente;
            laBitacora.MasInformacionExcepcion = laExcepcion.InnerException.Message;

            Invoque(laBitacora);
        }

        private void Invoque(Bitacora laBitacora) {
            BitacoraClient elCliente = new BitacoraClient();
            try
            {
                elCliente.RegistreError(laBitacora);
            }
            finally
            {
                elCliente.Close();
           }
        }
      
    }
}
