using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treina_LexIn.Views;
using Treina_LexIn.Models;

namespace Treina_LexIn.Presenters
{
    public class AdicionarCampoPresenter
    {
        IAdicionarCampo adicionarCampoView;
        AdicionarCampoModel adicionarCampo = new AdicionarCampoModel();

        public AdicionarCampoPresenter(IAdicionarCampo view)
        {
            adicionarCampoView = view;
        }

        public void AdicionarCampo()
        {
            adicionarCampo.textoCampo = adicionarCampoView.textoCampo;
            adicionarCampo.AdicionarCampo();
        }

        public void AdicionarSpan()
        {
            adicionarCampo.textoCampo = adicionarCampoView.textoCampo;
            adicionarCampo.AdicionarSpan();
        }
    }
}
