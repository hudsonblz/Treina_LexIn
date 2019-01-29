using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treina_LexIn.Views;
using Treina_LexIn.Models;


namespace Treina_LexIn.Presenters
{
    public class LocalizarSubstituirPresenter
    {
        ILocalizarSubstituir localizarSubstituirView;
        LocalizarSubstituirModel localizarSubstituir = new LocalizarSubstituirModel();

        public LocalizarSubstituirPresenter(ILocalizarSubstituir view)
        {
            localizarSubstituirView = view;
        }

        public void LocalizarProxima()
        { 
            localizarSubstituir.palavraBusca = localizarSubstituirView.palavraBusca;
            localizarSubstituir.caseSensitive = localizarSubstituirView.caseSensitive;
            localizarSubstituir.LocalizarProxima();
        }

        public void SubstituirTodos()
        {
            localizarSubstituir.palavraBusca = localizarSubstituirView.palavraBusca;
            localizarSubstituir.caseSensitive = localizarSubstituirView.caseSensitive;
            localizarSubstituir.palavraSubstituir = localizarSubstituirView.palavraSubstituir;
            localizarSubstituir.SubstituirTodos();
        }

        public void Substituir()
        {
            localizarSubstituir.palavraBusca = localizarSubstituirView.palavraBusca;
            localizarSubstituir.caseSensitive = localizarSubstituirView.caseSensitive;
            localizarSubstituir.palavraSubstituir = localizarSubstituirView.palavraSubstituir;
            localizarSubstituir.Substituir();
        }
    }
}
