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
        public bool caseSensitive { get; set; }
        public string palavraBusca { get; set; }
        public string palavraSubstituir { get; set; }           
    }
}
