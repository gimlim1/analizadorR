using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace R2PB.AnalisisCodigo.AC.Metodos
{
    public class Convertidor
    {
        public List<MethodDeclarationSyntax> Convierta(SyntaxList<MemberDeclarationSyntax> losNodos,string elIdSolucion)
        {
            List<MethodDeclarationSyntax> losMetodosConvertidos = new List<MethodDeclarationSyntax>();
            foreach (MemberDeclarationSyntax elNodo in losNodos)
            {
                try {
                    if (elNodo.Kind() == SyntaxKind.MethodDeclaration)
                    {
                        MethodDeclarationSyntax laDeclaracionMetodo = (MethodDeclarationSyntax)elNodo;
                        losMetodosConvertidos.Add(laDeclaracionMetodo);
                    }
                } catch (Exception laExcepcion) {
                    Bitacoras.Registrador elRegistrador = new Bitacoras.Registrador();
                    elRegistrador.Registre(laExcepcion, elIdSolucion, BC.Componentes.AnalizadorCodigoFuente);

                }
            }
            return losMetodosConvertidos;
        }
    }
}
