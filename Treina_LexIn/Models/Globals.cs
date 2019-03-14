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
    public static class Globais
    {
        public static Word.Document documentoAtual = Globals.ThisAddIn.Application.ActiveDocument;

        public static object missingValue = Missing.Value;

        public static Word.Range rangeSelecionadoDoc
        {
            get
            { 
            return Globals.ThisAddIn.Application.Selection.Range;
            }
            set
            {
                rangeSelecionadoDoc = value;
            }
        }
    }
}
