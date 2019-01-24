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

namespace Treina_LexIn
{
    public partial class Localizar_Substituir : UserControl
    {
        public Localizar_Substituir()
        {
            InitializeComponent();
        }

        private void Localizar_Substituir_Load(object sender, EventArgs e)
        {

        }
        #region Botões
        private void btnLocalizarProximo_Click(object sender, EventArgs e)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            Word.Words palavras = Globals.ThisAddIn.Application.ActiveDocument.Words;
            for(int i = 0; i < palavras.Count; i++)
            {

            }

            doc.Range(0,0).Select();
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
        #endregion
    }
}
