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
using WinFormsMvp.Forms;

namespace Treina_LexIn
{
    public partial class Contato : MvpForm, IContato
    {
        string IContato.nomeContatoPJ
        {
            get
            {
                return txbNomePJ.Text;
            }
            set
            {
                txbNomePJ.Text = value;
            }
        }
        string IContato.representantePF
        {
            get
            {
                return txbNomePF.Text;
            }
            set
            {
                txbNomePF.Text = value;
            }
        }

        public Contato()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
             ContatoPresenter contatoPresenter = new ContatoPresenter(this);
            contatoPresenter.InserirQualificacaoPJ();
            this.Close();
        }
    }
}
