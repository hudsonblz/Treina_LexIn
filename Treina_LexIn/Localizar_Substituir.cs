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
        private int posicaoInicial;
        private Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
        private Word.Range rng;

        
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
            /* Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;

             Word.Range rng = doc.Range(Globals.ThisAddIn.Application.Selection.Characters.First.Start);

             rng.Find.ClearFormatting();
             rng.Find.Forward = true;
             if (rng.Find.Execute(txbBusca.Text.ToString()))
             {
                 rng.Select();
             }
             */


            //seta parametros da busca
            rng.Find.ClearFormatting();

            rng.Find.Text = txbBusca.Text;
            rng.Find.Wrap = Word.WdFindWrap.wdFindAsk;
            rng.Find.Execute();

            if (rng.Find.Found)
            {
                rng.Select();
                rng.SetRange(Globals.ThisAddIn.Application.Selection.End, doc.Content.End);
            }
            else
            {
                MessageBox.Show("O texto não foi encontrado");
            }
        }

        private void txbBusca_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbBusca.Text))
            {
                btnLocalizarProximo.Enabled = true;
                posicaoInicial = Globals.ThisAddIn.Application.Selection.Start;
                rng = doc.Content;
                rng.SetRange(posicaoInicial, doc.Content.End);
            }
            else
            {
                btnLocalizarProximo.Enabled = false;
            }
        }
        #endregion

    }
}
