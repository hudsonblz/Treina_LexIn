using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treina_LexIn.Views;
using Treina_LexIn.Models;
using Treina_LexIn.Services;
using WinFormsMvp;
using System.Windows.Forms;


namespace Treina_LexIn.Presenters
{
    public class LocalizarSubstituirPresenter : Presenter<ILocalizarSubstituir>
    {
        private ILocalizarSubstituirService localizarSubstituirService;
        private readonly LocalizarSubstituirModel localizarSubstituirModel;

        public LocalizarSubstituirPresenter(ILocalizarSubstituir view) : base(view)
        {
            View.ViewLoading += View_ViewLoding;
            View.LocalizarProxima += View_LocalizarProxima;
            View.Substituir += View_Substituir;
            View.SubstituirTodos += View_SubstituirTodos;
            View.OnInit += View_OnInit;

            localizarSubstituirService = LocalizarSubstituirService.Instancia;
            localizarSubstituirModel = new LocalizarSubstituirModel();
        }

        public void View_LocalizarProxima(object sender, EventArgs e)
        {
            if (localizarSubstituirService.LocalizarProxima(View.caseSensitive, View.palavraBusca))
            {
                MessageBox.Show("Nenhum registro encontrado!");
            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado!");
            }
        }

        public void View_SubstituirTodos(object sender, EventArgs e)
        {
            if (localizarSubstituirService.Substituir(View.caseSensitive, View.palavraBusca, View.palavraSubstituir))
            {
                MessageBox.Show("Substituições realizadas!");
            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado!");
            }
        }

        public void View_Substituir(object sender, EventArgs e)
        {
            if (localizarSubstituirService.SubstituirTodos(View.caseSensitive, View.palavraBusca, View.palavraSubstituir))
            {
            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado!");
            }
        }

        public void View_OnInit(object sender, EventArgs e)
        {
            View.BindAttribute("palavraBusca", "palavraBusca", this.localizarSubstituirModel.palavraBusca);
            View.BindAttribute("caseSensitive", "caseSensitive", this.localizarSubstituirModel.caseSensitive);
            View.BindAttribute("palavraSubstituir", "palavraSubstituir", this.localizarSubstituirModel.palavraSubstituir);
        }

        public void View_ViewLoding(object sender, EventArgs e) { }
    }
}
