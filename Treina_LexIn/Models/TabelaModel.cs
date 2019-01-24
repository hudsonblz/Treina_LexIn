using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace Treina_LexIn.Models
{
    public class TabelaModel
    {
        public int numColunas { get; set; }
        public int numLinhas { get; set; }

        private Word.Document documentoAtual { get; set; }
        private object start = 0, end = 0;
        private Word.Range range;

        public void InserirTabela()
        {
            documentoAtual = Globals.ThisAddIn.Application.ActiveDocument;

            range = documentoAtual.Range(ref start, ref end);
            range.Tables.Add(Globals.ThisAddIn.Application.Selection.Range, numLinhas, numColunas);
        }
    }
}
