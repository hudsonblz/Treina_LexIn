using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treina_LexIn.Views;
using Treina_LexIn.Models;

namespace Treina_LexIn.Presenters
{
    public class ContatoPresenter
    {
        IContato contatoView;
        ContatoModel contato = new ContatoModel();
        
        public ContatoPresenter(IContato view)
        {
            contatoView = view;
        }

        public void InserirQualificacaoPJ()
        {
            contato.nomeContatoPJ = contatoView.nomeContatoPJ;
            contato.representantePF = contatoView.representantePF;
            contato.numRepresentante = contatoView.numRepresentante;
            contato.InserirQualificacaoPJ();
        }        
    }
}
