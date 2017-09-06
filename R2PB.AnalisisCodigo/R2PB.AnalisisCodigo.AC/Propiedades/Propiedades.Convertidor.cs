using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace R2PB.AnalisisCodigo.AC.Propiedades
{
    public class Convertidor : CSharpSyntaxWalker
    {
        private string IdSolucion;

        public Convertidor(string elIdSolucion) {
            this.IdSolucion = elIdSolucion;
        }

        public List<FieldDeclarationSyntax> Convierta(SyntaxList<MemberDeclarationSyntax> losNodos)
        {
            List<FieldDeclarationSyntax> lasPropiedades = new List<FieldDeclarationSyntax>();
            foreach (MemberDeclarationSyntax elNodo in losNodos)
            {
                try {
                    if (elNodo.Kind() == SyntaxKind.FieldDeclaration)
                    {
                        FieldDeclarationSyntax laPropiedadCasteada = (FieldDeclarationSyntax)elNodo;
                        lasPropiedades.Add(laPropiedadCasteada);
                    }
                } catch (Exception laExcepcion) {
                    Bitacoras.Registrador elRegistrador = new Bitacoras.Registrador();
                    elRegistrador.Registre(laExcepcion, IdSolucion, BC.Componentes.AnalizadorCodigoFuente);
                }

            }
            return lasPropiedades;
        }

    }
}
