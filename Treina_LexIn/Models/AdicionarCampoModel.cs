using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace Treina_LexIn.Models
{
    public class AdicionarCampoModel
    {
        public string textoCampo { get; set; }

        private Word.Document documentoAtual = Globals.ThisAddIn.Application.ActiveDocument;
        private object missingValue = Missing.Value;
        private Word.Range range;

        public AdicionarCampoModel()
        {
            range = documentoAtual.Content;
            range.SetRange(Globals.ThisAddIn.Application.Selection.End, Globals.ThisAddIn.Application.Selection.End);
        }

        public void AdicionarCampo()
        {
            range.Select();
            range.Text = "{" + textoCampo + "}";
            range.Select();
        }

        public void AdicionarSpan()
        {
            range.SetRange(Globals.ThisAddIn.Application.Selection.Start, Globals.ThisAddIn.Application.Selection.End);
            string spanContent = range.Text;
            range.Text = textoCampo;
                        
            range.InsertBefore("[");
            range.InsertAfter("]");

            range.SetRange(range.Start + 1, range.End - 1);
            range.Select();
            range.Font.Subscript = 1;
            range.SetRange(range.End, range.End);
            range.Text = spanContent;
            range.Select();
            range.Font.Subscript = 0;
        }
    }
}
