using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;


namespace Treina_LexIn.Models
{
    public class ContatoModel
    {
        public string nomeContatoPJ { get; set; }
        public string representantePF { get; set; }
        public int numRepresentante { get; set; }

        private Word.Document documentoAtual = Globals.ThisAddIn.Application.ActiveDocument;
        private object missingValue = Missing.Value;
        private Word.Range range;
        private string aspas = "\"";

        public ContatoModel()
        {
            range = documentoAtual.Content;
            range.SetRange(Globals.ThisAddIn.Application.Selection.End, Globals.ThisAddIn.Application.Selection.End);
        }
        public void InserirQualificacaoPJ()
        {
            InserirContatoPJ();
            InserirTexto("\r\n");
            InserirTexto("\r\n");
            InserirContatoPF();
        }

        private void InserirContatoPF()
        {
            InserirTexto("[");
            InserirSubscrito("repetir 1 Ate " + numRepresentante.ToString() + " pontuacao "+aspas+"; |; e |."+aspas);
            InserirTextoNegrito("{"+representantePF+".Nome Formatar "+aspas+"caixaalta"+aspas+"}");
            InserirTexto(", {" + representantePF + ".Nacionalidade}, {"+representantePF+ ".EstadoCivil}, {"+representantePF+ ".Profissao}, portador[");
            InserirSubscrito(representantePF + ".Sexo = " + aspas + "feminino" + aspas);
            InserirTexto("a] d[");
            InserirSubscrito(representantePF + ".IdentidadeTipo=" + aspas + "Passaporte" + aspas);
            InserirTexto("o][");
            InserirSubscrito(representantePF + ".IdentidadeTipo!=" + aspas + "Passaporte" + aspas);
            InserirTexto("a] {" + representantePF + ".IdentidadeTipo} n. {" + representantePF + ".IdentidadeNumero} – {" + representantePF 
                + ".IdentidadeOrgaoEmissor Formatar " + aspas + "caixaalta" + aspas + "}, inscrit[");
            InserirSubscrito(representantePF+".Sexo = "+aspas+"masculino"+aspas);
            InserirTexto("o][");
            InserirSubscrito(representantePF + ".Sexo=" + aspas + "feminino" + aspas);
            InserirTexto("a] no CPF sob o n. {"+representantePF+".CPF}, residente e domiciliad[");
            InserirSubscrito(representantePF + ".Sexo=" + aspas + "masculino" + aspas);
            InserirTexto("o][");
            InserirSubscrito(representantePF + ".Sexo=" + aspas + "feminino" + aspas);
            InserirTexto("a] na {" + representantePF + ".Logradouro}, {" + representantePF + ".LogradouroNumeroComp}[");
            InserirSubscrito(representantePF + ".LogradouroNumeroComp=" + aspas + "n." + aspas);
            InserirTexto(" ]{"+representantePF+ ".LogradouroNumero}, [");
            InserirSubscrito(representantePF + ".LogradouroComplemento!=" + aspas + aspas);
            InserirTexto(representantePF + ".LogradouroComplemento}, ]bairro {"+representantePF+ ".Bairro}, {"+representantePF+ ".Municipio}/{"
                +representantePF+ ".Estado}, {"+representantePF+ ".Pais}, [");
            InserirSubscrito(representantePF + ".Pais = " + aspas + "Brasil" + aspas);
            InserirTexto("CEP][");
            InserirSubscrito(representantePF + ".Pais != " + aspas + "Brasil" + aspas);
            InserirTexto("Código Postal]: {" + representantePF + ".CEP}{sinal}]");
        }
        private void InserirContatoPJ()
        {
            InserirTextoNegrito("{" + nomeContatoPJ + ".RazaoSocial Formatar " + aspas + "caixaalta" + aspas + "}");
            InserirTexto(", { " + nomeContatoPJ + ".Tipo}, inscrit[");
            InserirSubscrito(nomeContatoPJ + ".Genero = " + aspas + "masculino" + aspas);
            InserirTexto("o][");
            InserirSubscrito(nomeContatoPJ + ".Genero = " + aspas + "feminino" + aspas);
            InserirTexto("a][ na {" + nomeContatoPJ + ".Logradouro}, {" + nomeContatoPJ + ".LogradouroNumeroComp}[");
            InserirSubscrito(nomeContatoPJ + ".LogradouroNumeroComp = " + aspas + "n." + aspas);
            InserirTexto(" ]{" + nomeContatoPJ + ".LogradouroNumero}, [");
            InserirSubscrito(nomeContatoPJ + ".LogradouroComplemento!=" + aspas + aspas);
            InserirTexto("{" + nomeContatoPJ + ".LogradouroComplemento}, ]bairro {" + nomeContatoPJ + ".Bairro}, {" + nomeContatoPJ +
                ".Municipio}/{" + nomeContatoPJ + ".Estado}, {" + nomeContatoPJ + ".Estado}, {" + nomeContatoPJ + ".Pais}, [");
            InserirSubscrito(nomeContatoPJ + ".Pais=" + aspas + "Brasil" + aspas);
            InserirTexto("CEP][");
            InserirSubscrito(nomeContatoPJ + ".Pais!=" + aspas + "Brasil" + aspas);
            InserirTexto("Código Postal]: {" + nomeContatoPJ + ".CEP}");
        }
        private void InserirSubscrito(string texto)
        {
            range.Select();
            range.Text = texto;
            range.Select();
            range.Font.Subscript = 1;
            range.SetRange(range.End, range.End);
        }
        private void InserirTexto(string texto)
        {
            range.InsertAfter(texto);
            range.Select();
            range.Bold = 0;
            range.Font.Subscript = 0;
            range.SetRange(range.End, range.End);
        }
        private void InserirTextoNegrito(string texto)
        {
            range.InsertAfter(texto);
            range.Select();
            range.Bold=1;
            range.Font.Subscript = 0;
            range.SetRange(range.End, range.End);
        }
    }
}
