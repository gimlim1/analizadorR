using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using R2PB.AnalisisCodigo.AC.ClienteAnalisis;
using R2PB.AnalisisCodigo.BC.Controles;
using System;
using System.Collections.Generic;

namespace R2PB.AnalisisCodigo.AC.Metodos.Controles
{
    public class Constructor
    {
        public List<Control> Construya(SyntaxList<StatementSyntax> losControles,string elIdSolucion)
        {
            List<Control> losControlesConstruidos = new List<Control>();
            if (losControles != null && losControles.Count != 0) {
                foreach (StatementSyntax elControl in losControles)
                {
                    try
                    {
                        Tipo tipo = ObtengaElTipoDeControl(elControl);
                        if (tipo != Tipo.Ninguno)
                        {
                            Control controlConvertido = new Control();
                            FileLinePositionSpan lineSpan = elControl.SyntaxTree.GetLineSpan(elControl.Span);
                            controlConvertido.LineaComienzo = lineSpan.StartLinePosition.Line;
                            controlConvertido.LineaFinal = lineSpan.EndLinePosition.Line;
                            controlConvertido.TipoControl = tipo;
                            controlConvertido.NombreSintaxis = elControl.Kind().ToString();

                            if (tipo == Tipo.If)
                            {
                                IfStatementSyntax elControlIf = (IfStatementSyntax)elControl;
                                if (elControlIf.Else != null)
                                    controlConvertido.OtroControl = ConstruyaElElse(elControlIf);
                            }
                            losControlesConstruidos.Add(controlConvertido);
                        }

                    }
                    catch (Exception laExcepcion)
                    {
                        Bitacoras.Registrador elRegistrador = new Bitacoras.Registrador();
                        elRegistrador.Registre(laExcepcion, elIdSolucion, BC.Componentes.AnalizadorCodigoFuente);
                    }

                }
            }

            return losControlesConstruidos;
        }

        private Control ConstruyaElElse(IfStatementSyntax elControlIf)
        {
            Control control = new Control();
            FileLinePositionSpan lineSpan = elControlIf.Else.SyntaxTree.GetLineSpan(elControlIf.Else.Span);
            control.LineaComienzo = lineSpan.StartLinePosition.Line;
            control.LineaFinal = lineSpan.EndLinePosition.Line;
            control.TipoControl = Tipo.Else;
            control.NombreSintaxis = elControlIf.Else.Kind().ToString();

            return control;
        }

        private Tipo ObtengaElTipoDeControl(StatementSyntax elControl)
        {
            Tipo tipo = Tipo.Ninguno;

            if (elControl.Kind() == SyntaxKind.ForEachVariableStatement)
                tipo = Tipo.Foreach;
            if (elControl.Kind() == SyntaxKind.IfStatement)
                tipo = Tipo.If;
            if (elControl.Kind() == SyntaxKind.ForStatement)
                tipo = Tipo.For;
            if (elControl.Kind() == SyntaxKind.WhileStatement)
                tipo = Tipo.While;
            if (elControl.Kind() == SyntaxKind.DoStatement)
                tipo = Tipo.DoWhile;
            if (elControl.Kind() == SyntaxKind.SwitchStatement)
                tipo = Tipo.Switch;

            return tipo;
        }
    }
}
