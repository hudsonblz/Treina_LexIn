using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Treina_LexIn.Services
{

    public class LocalizarSubstituirService : ILocalizarSubstituirService
    {
        private Word.Document documentoAtual = Globals.ThisAddIn.Application.ActiveDocument;
        private int pontoInicial;
        private Word.Range range;
        private object missingValue = Missing.Value;

        private static readonly Lazy<ILocalizarSubstituirService> instancia =
            new Lazy<ILocalizarSubstituirService>(() => new LocalizarSubstituirService());

        public static ILocalizarSubstituirService Instancia
        {
            get
            {
                return instancia.Value;
            }
        }

        private LocalizarSubstituirService()
        {
            pontoInicial = Globals.ThisAddIn.Application.Selection.End;
            range = documentoAtual.Content;
            range.SetRange(pontoInicial, documentoAtual.Content.End);
        }

        public bool LocalizarProxima(bool caseSensitive, string palavraBusca)
        {
            Word.Selection selecao = Globals.ThisAddIn.Application.Selection;
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            Word.Selection selection = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;

            object findText = palavraBusca;
            selection.Find.ClearFormatting();
            selection.Find.Forward = true;
            selection.Find.MatchCase = false;
            selection.Find.Execute(ref findText);

            if (!selection.Find.Found)
            {
                doc.Range(0, 0).Select();
                selection.Find.Execute(ref findText);
                if (!selection.Find.Found)
                {
                    return false;
                }
            }
            return true;
         }

        public bool Substituir(bool caseSensitive, string palavraBusca, string palavraSubstituir)
        {
            Word.Document documentoAtual = Globals.ThisAddIn.Application.ActiveDocument;
            Word.Selection range = documentoAtual.Application.Selection;
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

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SubstituirTodos(bool caseSensitive, string palavraBusca, string palavraSubstituir)
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
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
