using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using R2PB.AnalisisCodigo.AC.ClienteAnalisis;
using System;
using System.Collections.Generic;

namespace R2PB.AnalisisCodigo.AC.Metodos
{
    public class Constructor
    {
        public List<Metodo> Construya(SyntaxList<MemberDeclarationSyntax> losNodos,string elIdSolucion)
        {
            List<MethodDeclarationSyntax> losMetodosDeclarados = new List<MethodDeclarationSyntax>();
            List<Metodo> losMetodosConvertidos = new List<Metodo>();
            if (losNodos != null && losNodos.Count != 0) {
               
                Convertidor elConvertidor = new Convertidor();
                losMetodosDeclarados = elConvertidor.Convierta(losNodos, elIdSolucion);
                foreach (MethodDeclarationSyntax elMetodo in losMetodosDeclarados)
                {
                    try
                    {
                        Metodo elMetodoConvertido = new Metodo();
                        elMetodoConvertido.NombreMetodo = elMetodo.Identifier.Text;
                        elMetodoConvertido.Retorno = elMetodo.ReturnType.ToString();

                        FileLinePositionSpan lineSpan = elMetodo.SyntaxTree.GetLineSpan(elMetodo.Span);
                        elMetodoConvertido.LineaComienzo = lineSpan.StartLinePosition.Line;
                        elMetodoConvertido.LineaFinal = lineSpan.EndLinePosition.Line;

                        string elModificador;
                        if (elMetodo.Modifiers.Count == 0)
                            elModificador = "";
                        else
                            elModificador = elMetodo.Modifiers.First().ToString();

                        elMetodoConvertido.Visibilidad = elModificador;
                        Parametros.Constructor elConstructorDeParametros = new Parametros.Constructor();
                        elMetodoConvertido.Parametros = elConstructorDeParametros.Construya(elMetodo.ParameterList.Parameters, elIdSolucion).ToArray();

                        Controles.Constructor elConstructorDeControles = new Controles.Constructor();
                        if (elMetodo.Body != null)
                        {
                            elMetodoConvertido.Controles = elConstructorDeControles.Construya(elMetodo.Body.Statements, elIdSolucion).ToArray();
                        }
                        else {
                            elMetodoConvertido.Controles = new List<Control>().ToArray(); 
                        }

                        losMetodosConvertidos.Add(elMetodoConvertido);
                    }
                    catch (Exception laExcepcion)
                    {
                        Bitacoras.Registrador elRegistrador = new Bitacoras.Registrador();
                        elRegistrador.Registre(laExcepcion, elIdSolucion, BC.Componentes.AnalizadorCodigoFuente);

                    }
                }

            }
  

            return losMetodosConvertidos;
        }
    }
}
