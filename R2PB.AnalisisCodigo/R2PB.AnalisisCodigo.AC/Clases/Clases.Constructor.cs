using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using R2PB.AnalisisCodigo.AC.ClienteAnalisis;
using R2PB.AnalisisCodigo.BC.Clases;
using System;
using System.Collections.Generic;

namespace R2PB.AnalisisCodigo.AC.Clases
{
    public class Constructor : CSharpSyntaxRewriter
    {
        public List<Clase> lasClases = new List<Clase>();
        private string IdSolucion;

        public Constructor(string elIdSolucion) {
            this.IdSolucion = elIdSolucion;
        }

        public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax elNodo)
        {
            try
            {
                elNodo = (ClassDeclarationSyntax)base.VisitClassDeclaration(elNodo);

                Clase clase = new Clase();
                clase.Nombre = elNodo.Identifier.ValueText;

                if (elNodo.Parent.Kind() == SyntaxKind.NamespaceDeclaration)
                {
                    NamespaceDeclarationSyntax elNameSpace = (NamespaceDeclarationSyntax)elNodo.Parent;
                    clase.NameSpace = elNameSpace.Name.ToString();
                }
                else {
                    clase.NameSpace = null;
                }

                clase.Visibilidad = elNodo.Modifiers.Count != 0 ? elNodo.Modifiers.First().ToString() : "";
                clase.Tipo = Tipo.Clase;
                FileLinePositionSpan lineSpan = elNodo.SyntaxTree.GetLineSpan(elNodo.Span);
                clase.LineaComienzo = lineSpan.StartLinePosition.Line;
                clase.LineaFinal = lineSpan.EndLinePosition.Line;

                Usings.Constructor elConstructorDeUsings = new Usings.Constructor(IdSolucion);
                elConstructorDeUsings.Visit(elNodo.SyntaxTree.GetRoot());
                clase.Usings = elConstructorDeUsings.UsingsConstruidos.ToArray();

                Herencias.Constructor elConstructorDeHerencia = new Herencias.Constructor();
                clase.Herencias = elConstructorDeHerencia.Construya(elNodo.BaseList, IdSolucion).ToArray();

                Metodos.Constructor eConstructorDeMetodos = new Metodos.Constructor();
                clase.Metodos = eConstructorDeMetodos.Construya(elNodo.Members, IdSolucion).ToArray();

                Propiedades.Constructor elConstructorDePropiedades = new Propiedades.Constructor();
                clase.Propiedades = elConstructorDePropiedades.Construya(elNodo.Members, IdSolucion).ToArray();
                lasClases.Add(clase);
            } catch (Exception laExcepcion) {
                Bitacoras.Registrador elRegistrador = new Bitacoras.Registrador();
                elRegistrador.Registre(laExcepcion, IdSolucion, BC.Componentes.AnalizadorCodigoFuente);
            }
         
            return (SyntaxNode)elNodo;
        }
    }
}
