using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace R2PB.AnalisisCodigo.AC.NameSpaces
{
    public class Constructor : CSharpSyntaxRewriter
    {
        private string elIdDeLaSolucion;

        public Constructor(string elIdSolucion)
        {
            this.elIdDeLaSolucion = elIdSolucion;
        }
        public override SyntaxNode VisitNamespaceDeclaration(NamespaceDeclarationSyntax elNodo)
        {
            try
            {
                elNodo = (NamespaceDeclarationSyntax)base.VisitNamespaceDeclaration(elNodo);
                elNodo.Name.ToString();
            }
            catch (Exception laExcepcion)
            {
                Bitacoras.Registrador elRegistrador = new Bitacoras.Registrador();
                elRegistrador.Registre(laExcepcion, elIdDeLaSolucion, BC.Componentes.AnalizadorCodigoFuente);
            }

            return elNodo;
        }
    }
}
