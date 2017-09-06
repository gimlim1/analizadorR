using Microsoft.CodeAnalysis.CSharp.Syntax;
using R2PB.AnalisisCodigo.AC.Bitacoras;
using R2PB.AnalisisCodigo.AC.ClienteAnalisis;
using R2PB.AnalisisCodigo.BC;
using System;
using System.Collections.Generic;

namespace R2PB.AnalisisCodigo.AC.Herencias
{
    public class Constructor
    {
        public List<Herencia> Construya(BaseListSyntax laListaDeHerencias, string IdSolucion)
        {
            List<Herencia> lasHerencias = new List<Herencia>();
            if (laListaDeHerencias != null)
            {
                foreach (BaseTypeSyntax type in laListaDeHerencias.Types)
                {
                    try
                    {
                        Herencia laHerencia = new Herencia();
                        laHerencia.DeclaracionHerencia = type.ToString();
                        lasHerencias.Add(laHerencia);

                    }
                    catch (Exception laExcepcion) {
                        Registrador elRegistrador = new Registrador();
                        elRegistrador.Registre(laExcepcion,IdSolucion,Componentes.AnalizadorCodigoFuente);

                    }

                }
            }

            return lasHerencias;
        }
    }
}
