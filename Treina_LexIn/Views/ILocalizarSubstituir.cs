using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;

namespace Treina_LexIn.Views
{
    public interface ILocalizarSubstituir : IView
    {
        event EventHandler LocalizarProxima;
        event EventHandler SubstituirTodos;
        event EventHandler Substituir;
        event EventHandler ViewLoading;
        event EventHandler OnInit;

        void BindAttribute(string type, string attribute, object model);
        void ConfirmLoaded();

        string palavraBusca { get; set; }
        string palavraSubstituir { get; set; }
        bool caseSensitive { get; set; }
    }
}
