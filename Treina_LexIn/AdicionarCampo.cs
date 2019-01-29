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
    public partial class AdicionarCampo : Form, IAdicionarCampo
    {
        public AdicionarCampo()
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
        private void btnAdicionarCampo_Click(object sender, EventArgs e)
        {
            AdicionarCampoPresenter adicionarCampo = new AdicionarCampoPresenter(this);
            adicionarCampo.AdicionarCampo();
            this.Close();
        }

        private void txbTextoCampo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbTextoCampo.Text))
            {
                btnAdicionarCampo.Enabled = true;
            }
            else
            {
                btnAdicionarCampo.Enabled = false;
            }
        }
    }
}
