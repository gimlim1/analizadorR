using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using R2PB.AnalisisCodigo.AC.ClienteAnalisis;
using System;
using System.Collections.Generic;

namespace R2PB.AnalisisCodigo.AC.Usings
{
    public class Constructor : CSharpSyntaxWalker
    {
        public List<Using> UsingsConstruidos = new List<Using>();
        private string IdSolucion;

        public Constructor(string IdDeLaSolucion) {
            this.IdSolucion = IdDeLaSolucion;
        }
        public override void VisitUsingDirective(UsingDirectiveSyntax elNodo)
        {
            try {
                Using nuevoUsing = new Using();
                nuevoUsing.UsingDeclarado = elNodo.Name.ToFullString();
                UsingsConstruidos.Add(nuevoUsing);
            } catch(Exception laExcepcion) {
                Bitacoras.Registrador elRegistrador = new Bitacoras.Registrador();
                elRegistrador.Registre(laExcepcion,IdSolucion,BC.Componentes.AnalizadorCodigoFuente);
            }
        }
    }
}
