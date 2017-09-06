using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using R2PB.AnalisisCodigo.AC.ClienteAnalisis;
using R2PB.AnalisisCodigo.BC;
using System;
using System.Collections.Generic;

namespace R2PB.AnalisisCodigo.AC.Propiedades
{
    public class Constructor : CSharpSyntaxWalker
    {

        public List<Propiedad> Construya(SyntaxList<MemberDeclarationSyntax> losNodos,string elIDSolucion)
        {
            List<FieldDeclarationSyntax> lasPropiedadesDeclaradas = new List<FieldDeclarationSyntax>();
            Convertidor elConvertidor = new Convertidor(elIDSolucion);
            lasPropiedadesDeclaradas = elConvertidor.Convierta(losNodos);

            List<Propiedad> lasPropiedadesConvertidas = new List<Propiedad>();
            foreach (FieldDeclarationSyntax laPropiedad in lasPropiedadesDeclaradas)
            {
                try {
                    Propiedad propiedadConvertida = new Propiedad();
                    propiedadConvertida.Visibilidad = laPropiedad.Modifiers.Count != 0 ? laPropiedad.Modifiers.First().ToString() : "";
                    propiedadConvertida.Nombre = laPropiedad.Declaration.Variables.Count != 0 ? laPropiedad.Declaration.Variables.FirstOrDefault().ToString() : "";
                    propiedadConvertida.Tipo = laPropiedad.Declaration.Type.ToFullString();
                    propiedadConvertida.EsEstatica = VerifiqueSiEsStatic(laPropiedad);
                    lasPropiedadesConvertidas.Add(propiedadConvertida);

                } catch(Exception laExcepcion) {
                    Bitacoras.Registrador elRegistrador = new Bitacoras.Registrador();
                    elRegistrador.Registre(laExcepcion, elIDSolucion, Componentes.AnalizadorCodigoFuente);
                }

            }

            return lasPropiedadesConvertidas;
        }

        public bool VerifiqueSiEsStatic(FieldDeclarationSyntax laPropiedad)
        {
            bool esEstatica = false;

            foreach (SyntaxToken modificador in laPropiedad.Modifiers)
            {
                if (modificador.ToString() == Constantes.TipoEstatico)
                    esEstatica = true;
            }

            return esEstatica;
        }

    }
}
