using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using R2PB.AnalisisCodigo.AC.ClienteAnalisis;
using R2PB.AnalisisCodigo.BC;
using System;
using System.Collections.Generic;

namespace R2PB.AnalisisCodigo.AC.Metodos.Parametros
{
    public class Constructor
    {
        public List<Parametro> Construya(SeparatedSyntaxList<ParameterSyntax> losParametros,string elIdSolucion)
        {
            List<Parametro> losParametrosConstruidos = new List<Parametro>();
            foreach (ParameterSyntax elParametro in losParametros)
            {
                try {
                    Parametro elParametroConverido = new Parametro();
                    elParametroConverido.Nombre = elParametro.Identifier.ToFullString();
                    elParametroConverido.Tipo = elParametro.Type.ToFullString();
                    elParametroConverido.EsStatico = VerifiqueSiEsStatic(elParametro);
                    elParametroConverido.TieneMasModificadores = ObtengaLosModificadores(elParametro).ToArray();

                    losParametrosConstruidos.Add(elParametroConverido);

                } catch(Exception laExcepcion)
                {
                    Bitacoras.Registrador elRegistrador = new Bitacoras.Registrador();
                    elRegistrador.Registre(laExcepcion, elIdSolucion, BC.Componentes.AnalizadorCodigoFuente);
                }

            }
            return losParametrosConstruidos;
        }

        public bool VerifiqueSiEsStatic(ParameterSyntax elParametro)
        {
            bool esEstatico = false;
            foreach (SyntaxToken elModificador in elParametro.Modifiers)
            {
                if (elModificador.ToString() == Constantes.TipoEstatico)
                    esEstatico = true;
            }
            return esEstatico;
        }

        public List<string> ObtengaLosModificadores(ParameterSyntax elParametro)
        {
            List<string> losModificadores = new List<string>();
            foreach (SyntaxToken elModificador in elParametro.Modifiers)
                losModificadores.Add(elModificador.ToString());
            return losModificadores;
        }
    }
}
