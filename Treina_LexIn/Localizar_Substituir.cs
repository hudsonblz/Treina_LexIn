using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Treina_LexIn.Presenters;
using Treina_LexIn.Views;

namespace Treina_LexIn
{
    public partial class Localizar_Substituir : UserControl, ILocalizarSubstituir
    {
        public Localizar_Substituir()
        {
            InitializeComponent();
        }

        bool ILocalizarSubstituir.caseSensitive
        {
            get
            {
                return chbCaseSensitive.Checked;
            }

            set
            {
                chbCaseSensitive.Checked = value;
            }
        }
        string ILocalizarSubstituir.palavraBusca
        {
            get
            {
                return txbBusca.Text;
            }

            set
            {
                txbBusca.Text = value;
            }
        }
        string ILocalizarSubstituir.palavraSubstituir
        {
            get
            {
                return txbSubstituicao.Text;
            }

            set
            {
                txbSubstituicao.Text = value;
            }
        }

        #region Controles
        private void btnLocalizarProximo_Click(object sender, EventArgs e)
        {
            LocalizarSubstituirPresenter localizarSubstituir = new LocalizarSubstituirPresenter(this);
            localizarSubstituir.LocalizarProxima();

        }

        private void btnSubstituir_Click(object sender, EventArgs e)
        {
            LocalizarSubstituirPresenter localizarSubstituir = new LocalizarSubstituirPresenter(this);
            localizarSubstituir.Substituir();
        }

        private void btnSubstituirTodos_Click(object sender, EventArgs e)
        {
            LocalizarSubstituirPresenter localizarSubstituir = new LocalizarSubstituirPresenter(this);
            localizarSubstituir.SubstituirTodos();
        }

        private void Localizar_Substituir_Load(object sender, EventArgs e)
        {

        }

        private void txbBusca_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbBusca.Text))
            {
                btnLocalizarProximo.Enabled = true;
            }
            else
            {
                btnLocalizarProximo.Enabled = false;
            }
        }

        private void txbSubstituicao_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbSubstituicao.Text))
            {
                btnSubstituir.Enabled = true;
                btnSubstituirTodos.Enabled = true;
            }
            else
            {
                btnSubstituir.Enabled = false;
                btnSubstituirTodos.Enabled = false;
            }
        }
        #endregion
    }
}
