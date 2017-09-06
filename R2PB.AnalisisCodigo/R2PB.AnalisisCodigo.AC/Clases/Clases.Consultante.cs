using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace R2PB.AnalisisCodigo.AC.Clases
{
    public class Consultante : CSharpSyntaxRewriter
    {

        public List<string> lasClases = new List<string>();
        public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax elNodo) {
            elNodo = (ClassDeclarationSyntax)base.VisitClassDeclaration(elNodo);

            string nombreDeLaClase = elNodo.Identifier.ValueText;
            lasClases.Add(nombreDeLaClase); 

            return elNodo;
        }

    }
}
