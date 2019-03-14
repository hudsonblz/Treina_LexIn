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
using Treina_LexIn.Models;
using Treina_LexIn.Services;
using Treina_LexIn.Views;
using WinFormsMvp.Forms;

namespace Treina_LexIn
{
    public partial class LocalizarSubstituir : MvpForm, ILocalizarSubstituir
    {

        public LocalizarSubstituir()
        {
            InitializeComponent();
        }

        public event EventHandler ViewLoading;
        public event EventHandler LocalizarProxima;
        public event EventHandler SubstituirTodos;
        public event EventHandler Substituir;
        public event EventHandler OnInit;


        protected override void OnLoad(EventArgs e)
        {
            try
            {
                OnViewLoding();
                base.OnLoad(e);
            }
            catch(Exception Ex)
            {
                string a = Ex.Message;
                string b = Ex.StackTrace;
            }
        }

        protected virtual void OnViewLoding()
        {
            ViewLoading?.Invoke(this, EventArgs.Empty);
        }

        public bool caseSensitive
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
        public string palavraBusca
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
        public string palavraSubstituir
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
        public void ConfirmLoaded()
        {
        }
        #region Controles
        private void btnLocalizarProximo_Click(object sender, EventArgs e)
        {
            LocalizarProxima(sender, e);
        }
        private void btnSubstituir_Click(object sender, EventArgs e)
        {
            Substituir(sender, e);
        }
        private void btnSubstituirTodos_Click(object sender, EventArgs e)
        {
            SubstituirTodos(sender, e);
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

        public void BindAttribute(string type, string attribute, object model)
        {
            if (model != null)
            {
                this.txbBusca.DataBindings.Add(type, model, attribute, false, DataSourceUpdateMode.OnPropertyChanged);
                this.txbSubstituicao.DataBindings.Add(type, model, attribute, false, DataSourceUpdateMode.OnPropertyChanged);
                this.chbCaseSensitive.DataBindings.Add(type, model, attribute, false, DataSourceUpdateMode.OnPropertyChanged);
            }
        }


        private void Localizar_Substituir_Load(object sender, EventArgs e)
        {
            OnInit(null, EventArgs.Empty);
        }
        #endregion
    }
}
