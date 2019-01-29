using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treina_LexIn.Views
{
    public interface ILocalizarSubstituir
    {
        string palavraBusca { get; set; }
        string palavraSubstituir { get; set; }
        bool caseSensitive { get; set; }
    }
}
