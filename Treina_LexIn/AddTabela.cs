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
    public partial class AddTabela : Form, ITabela
    {
        string ITabela.numColunas
        {
            get
            {
                return nupColunas.Value.ToString();
            }

          set
            {
                nupColunas.Value = int.Parse(value);
            }
        }
        string ITabela.numLinhas
        {
            get
            {
                return nupLinhas.Value.ToString();
            }
            set
            {
                nupLinhas.Value = int.Parse(value);
            }
        }

        public AddTabela()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Ribbon1Presenter presenter = new Ribbon1Presenter(this);
            presenter.InserirTabela();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
