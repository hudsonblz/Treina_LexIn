using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Treina_LexIn.Views;
using Treina_LexIn.Presenters;

namespace Treina_LexIn
{
    public partial class AdicionarSpan : Form, IAdicionarCampo
    {
        public AdicionarSpan()
        {
            InitializeComponent();
        }

        string IAdicionarCampo.textoCampo
        {
            get
            {
                return txbTextoCampo.Text;
            }
            set
            {
                value = txbTextoCampo.Text;
            }
        }

        private void txbTextoCampo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbTextoCampo.Text))
            {
                btnAdicionarSpan.Enabled = true;
            }
            else
            {
                btnAdicionarSpan.Enabled = false;
            }
        }

        private void btnAdicionarSpan_Click(object sender, EventArgs e)
        {
            AdicionarCampoPresenter adicionarSpan = new AdicionarCampoPresenter(this);
            adicionarSpan.AdicionarSpan();
            this.Close();
        }
    }
}
