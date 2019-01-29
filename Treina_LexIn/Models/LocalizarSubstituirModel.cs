using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Treina_LexIn.Models
{
    public class LocalizarSubstituirModel
    {
        private Word.Document documentoAtual = Globals.ThisAddIn.Application.ActiveDocument;
        private object missingValue = Missing.Value;
        private int pontoInicial;
        private Word.Range range;

        public bool caseSensitive { get; set; }
        public string palavraBusca { get; set; }
        public string palavraSubstituir { get; set; }

        public LocalizarSubstituirModel()
        {
            pontoInicial = Globals.ThisAddIn.Application.Selection.End;
            range = documentoAtual.Content;
            range.SetRange(pontoInicial, documentoAtual.Content.End);
        }

       
        public void LocalizarProxima()
        {
            range.Find.ClearFormatting();
            range.Find.MatchCase = caseSensitive;
            range.Find.Text = palavraBusca;
            range.Find.Wrap = Word.WdFindWrap.wdFindAsk;
            range.Find.Execute();

            if (range.Find.Found)
            {
                range.Select();
                range.SetRange(Globals.ThisAddIn.Application.Selection.End, documentoAtual.Content.End);
            }
            else
            {
                MessageBox.Show("O texto não foi encontrado");
            }
        }
        public void Substituir()
        {
            range.Find.ClearFormatting();
            range.Find.MatchCase = caseSensitive;
            range.Find.Text = palavraBusca;
            range.Find.Wrap = Word.WdFindWrap.wdFindAsk;

            range.Find.Execute();

            if (range.Find.Found)
            {
                range.Select();
                range.Text = palavraSubstituir;
                range.Select();
                range.SetRange(Globals.ThisAddIn.Application.Selection.End, documentoAtual.Content.End);
            }
            else
            {
                MessageBox.Show("O texto não foi encontrado");
            }
        }
        public void SubstituirTodos()
        {
            Word.Find findObject = Globals.ThisAddIn.Application.Selection.Find;
            findObject.ClearFormatting();
            findObject.Text = palavraBusca;
            findObject.MatchCase = caseSensitive;
            findObject.Replacement.ClearFormatting();
            findObject.Replacement.Text = palavraSubstituir;
            object replaceAll = Word.WdReplace.wdReplaceAll;
            findObject.Execute(ref missingValue, ref missingValue, ref missingValue, ref missingValue, 
                ref missingValue, ref missingValue, ref missingValue, ref missingValue, ref missingValue, 
                ref missingValue, ref replaceAll, ref missingValue, ref missingValue, ref missingValue, 
                ref missingValue);

            if (findObject.Found)
            {
                MessageBox.Show("Todas substituições foram feitas");
            }
            else
            {
                MessageBox.Show("Nenhuma palavra encontrada para a substiuição");
            }
        }
        
    }
}
