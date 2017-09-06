using R2PB.AnalisisCodigo.SI.Datos.Clases;
using R2PB.AnalisisCodigo.SI.Datos.Herencias;
using R2PB.AnalisisCodigo.SI.Datos.Metodos;
using R2PB.AnalisisCodigo.SI.Datos.Paquetes;
using R2PB.AnalisisCodigo.SI.Datos.Propiedades;
using R2PB.AnalisisCodigo.SI.Datos.Proyectos;
using R2PB.AnalisisCodigo.SI.Datos.Usings;
using System.Data.Entity.Validation;
using System.Linq;

namespace R2PB.AnalisisCodigo.DS.SolucionesCodigoFuente
{
    public class Registrador
    {
        public int Registre(Paquete elPaquete)
        {
            using (var contexto = new AnalisisCodigoEntities())
            {
                R2PBPaquete elPaqueteRegistrado = contexto.R2PBPaquete.Add(ConstruyaElPaquete(elPaquete));
                contexto.SaveChanges();

                foreach (Proyecto elProyecto in elPaquete.Proyectos)
                {
                    try
                    {
                        R2PBProyecto elProyectoRegistrado = contexto.R2PBProyecto.Add(ConstruyaElProyecto(elProyecto, elPaqueteRegistrado.IdPaquete));
                        contexto.SaveChanges();

                        foreach (Clase laClase in elProyecto.Clases)
                        {
                            R2PBClase laClaseRegistrada = contexto.R2PBClase.Add(ConstruyaLaClase(laClase, elProyectoRegistrado.IdProyecto, elPaqueteRegistrado.IdPaquete));
                            contexto.SaveChanges();

                            foreach (Metodo elMetodo in laClase.Metodos)
                            {
                                R2PBMetodo elMetodoRegistrado = contexto.R2PBMetodo.Add(ConstruyaElMetodo(elMetodo, laClaseRegistrada.IdClase, elPaqueteRegistrado.IdPaquete, elProyectoRegistrado.IdProyecto));
                                contexto.SaveChanges();

                                foreach (Parametro elParametro in elMetodo.Parametros)
                                {
                                    R2PBParametro elParametroRegistrado = contexto.R2PBParametro.Add(ConstruyaElParametro(elParametro, elMetodoRegistrado.IdMetodo, elPaqueteRegistrado.IdPaquete, elProyectoRegistrado.IdProyecto));
                                    contexto.SaveChanges();
                                    if (elParametro.TieneMasModificadores.Count > 0)
                                    {
                                        foreach (string elModificador in elParametro.TieneMasModificadores)
                                        {
                                            contexto.R2PBParametroModificador.Add(ConstruyaElModificador(elModificador, elParametroRegistrado.IdParametro));
                                        }
                                        contexto.SaveChanges();
                                    }
                                }

                                foreach (Control elControl in elMetodo.Controles)
                                {
                                    contexto.R2PBControl.Add(ConstruyaElControl(elControl, elMetodoRegistrado.IdMetodo, elPaqueteRegistrado.IdPaquete, elProyectoRegistrado.IdProyecto, laClaseRegistrada.IdClase));
                                    if (elControl.OtroControl != null)
                                    {
                                        contexto.R2PBControl.Add(ConstruyaElControl(elControl.OtroControl, elMetodoRegistrado.IdMetodo, elPaqueteRegistrado.IdPaquete, elProyectoRegistrado.IdProyecto, laClaseRegistrada.IdClase));
                                    }
                                }
                                contexto.SaveChanges();

                            }

                            foreach (Using elUsing in laClase.Usings)
                            {
                                contexto.R2PBUsing.Add(ConstruyaElUsing(elUsing, laClaseRegistrada.IdClase, elProyectoRegistrado.IdProyecto, elPaqueteRegistrado.IdPaquete));
                            }

                            foreach (Herencia laHerencia in laClase.Herencias)
                            {
                                contexto.R2PBHerencia.Add(ConstruyaLaHerencia(laHerencia, laClaseRegistrada.IdClase, elProyectoRegistrado.IdProyecto, elPaqueteRegistrado.IdPaquete));
                            }

                            foreach (Propiedad laPropiedad in laClase.Propiedades)
                            {
                                contexto.R2PBPropiedad.Add(ConstruyaLaPropiedad(laPropiedad, laClaseRegistrada.IdClase, elProyectoRegistrado.IdProyecto, elProyectoRegistrado.IdPaquete));
                            }

                            contexto.SaveChanges();
                        }

                    }
                    catch (DbEntityValidationException ex)
                    {
                        var mensajesError = ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage);
                        var todoslosMensajes = string.Join("; ", mensajesError);

                        Bitacoras.Registrador elRegistrador = new Bitacoras.Registrador();
                        elRegistrador.Registre(new SI.Datos.Bitacoras.Bitacora{
                            IdSolucion = elPaqueteRegistrado.IdentificadorPaquete,
                            StackTrace = ex.StackTrace,
                            Tipo = BC.Componentes.AnalizadorCodigoFuente,
                            Mensaje = ex.Message,
                            MasInformacionExcepcion = todoslosMensajes,
                        });
                    }


                }
                return elPaqueteRegistrado.IdPaquete;
            }
        }


        private R2PBPaquete ConstruyaElPaquete(Paquete elPaquete)
        {
            R2PBPaquete elPaqueteConvertido = new R2PBPaquete();
            elPaqueteConvertido.IdentificadorPaquete = elPaquete.IdSolucion;
            elPaqueteConvertido.NombrePaquete = elPaquete.NombrePaquete;

            return elPaqueteConvertido;
        }

        private R2PBProyecto ConstruyaElProyecto(Proyecto elProyecto, int elIdPaquete)
        {
            R2PBProyecto elProyectoConvertido = new R2PBProyecto();
            elProyectoConvertido.IdPaquete = elIdPaquete;
            elProyectoConvertido.IdentificadorProyecto = elProyecto.IdProyecto;
            elProyectoConvertido.NombreProyecto = elProyecto.NombreProyecto;
            elProyectoConvertido.Lenguaje = elProyecto.Lenguaje;

            return elProyectoConvertido;
        }

        private R2PBClase ConstruyaLaClase(Clase laClase, int elIdProyecto, int elIdPaquete)
        {
            R2PBClase laClaseConvertida = new R2PBClase();
            laClaseConvertida.IdProyecto = elIdProyecto;
            laClaseConvertida.NameSpace = laClase.NameSpace;
            laClaseConvertida.Nombre = laClase.Nombre;
            laClaseConvertida.Tipo = (short)laClase.Tipo;
            laClaseConvertida.Visibilidad = laClase.Visibilidad;
            laClaseConvertida.IdPaquete = elIdPaquete;
            laClaseConvertida.LineaComienzo = laClase.LineaComienzo;
            laClaseConvertida.LineaFinal = laClase.LineaFinal;
            return laClaseConvertida;
        }

        private R2PBMetodo ConstruyaElMetodo(Metodo elMetodo, int elIdClase, int elIdPaquete, int elIdProyecto)
        {
            R2PBMetodo elMetodoConvertido = new R2PBMetodo();
            elMetodoConvertido.IdClase = elIdClase;
            elMetodoConvertido.Nombre = elMetodo.NombreMetodo;
            elMetodoConvertido.Retorno = elMetodo.Retorno;
            elMetodoConvertido.Visibilidad = elMetodo.Visibilidad;
            elMetodoConvertido.IdPaquete = elIdPaquete;
            elMetodoConvertido.IdProyecto = elIdProyecto;
            elMetodoConvertido.LineaComienzo = elMetodo.LineaComienzo;
            elMetodoConvertido.LineaFinal = elMetodo.LineaFinal;
            return elMetodoConvertido;
        }

        private R2PBParametro ConstruyaElParametro(Parametro elParametro, int elIdMetodo, int elIdPaquete, int elIdProyecto)
        {
            R2PBParametro elParametroConvertido = new R2PBParametro();
            elParametroConvertido.IdMetodo = elIdMetodo;
            elParametroConvertido.Nombre = elParametro.Nombre;
            elParametroConvertido.Estatico = elParametro.EsStatico;
            elParametroConvertido.Tipo = elParametro.Tipo;
            elParametroConvertido.IdPaquete = elIdPaquete;
            elParametroConvertido.IdProyecto = elIdProyecto;

            return elParametroConvertido;
        }

        private R2PBParametroModificador ConstruyaElModificador(string elModificador, int elIdParametro)
        {
            R2PBParametroModificador elModificadorConvertido = new R2PBParametroModificador();
            elModificadorConvertido.IdParametro = elIdParametro;
            elModificadorConvertido.Modificador = elModificador;


            return elModificadorConvertido;
        }

        private R2PBControl ConstruyaElControl(Control elControl, int elIdMetodo, int elIdPaquete, int elIdProyecto, int elIdClase)
        {
            R2PBControl elControlConvertido = new R2PBControl();
            elControlConvertido.IdMetodo = elIdMetodo;
            elControlConvertido.LineaComienzo = elControl.LineaComienzo;
            elControlConvertido.LineaFinal = elControl.LineaFinal;
            elControlConvertido.Nombre = elControl.NombreSintaxis;
            elControlConvertido.Tipo = (int)elControl.TipoControl;
            elControlConvertido.IdPaquete = elIdPaquete;
            elControlConvertido.IdProyecto = elIdProyecto;
            elControlConvertido.IdClase = elIdClase;

            return elControlConvertido;
        }

        private R2PBUsing ConstruyaElUsing(Using elUsing, int elIdClase, int elIdProyecto, int elIdPaquete)
        {
            R2PBUsing elUsingConvertido = new R2PBUsing();
            elUsingConvertido.IdClase = elIdClase;
            elUsingConvertido.UsingDeclarado = elUsing.UsingDeclarado;
            elUsingConvertido.IdProyecto = elIdProyecto;
            elUsingConvertido.IdPaquete = elIdPaquete;

            return elUsingConvertido;
        }

        private R2PBHerencia ConstruyaLaHerencia(Herencia laHerencia, int elIdClase, int elIdProyecto, int elIdPaquete)
        {
            R2PBHerencia laHerenciaConvertida = new R2PBHerencia();
            laHerenciaConvertida.IdClase = elIdClase;
            laHerenciaConvertida.HerenciaDeclarada = laHerencia.DeclaracionHerencia;
            laHerenciaConvertida.IdProyecto = elIdProyecto;
            laHerenciaConvertida.IdPaquete = elIdPaquete;

            return laHerenciaConvertida;
        }

        private R2PBPropiedad ConstruyaLaPropiedad(Propiedad laPropiedad, int elIdClase, int elIdProyecto, int elIdPaquete)
        {
            R2PBPropiedad laPropiedadConvertida = new R2PBPropiedad();
            laPropiedadConvertida.IdClase = elIdClase;
            laPropiedadConvertida.Estatico = laPropiedad.EsEstatica;
            laPropiedadConvertida.Nombre = laPropiedad.Nombre;
            laPropiedadConvertida.Tipo = laPropiedad.Tipo;
            laPropiedadConvertida.Visibilidad = laPropiedad.Visibilidad;
            laPropiedadConvertida.IdProyecto = elIdProyecto;
            laPropiedadConvertida.IdPaquete = elIdPaquete;

            return laPropiedadConvertida;
        }

    }
}
