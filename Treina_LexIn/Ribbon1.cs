using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;
using System.Reflection;
using System.ComponentModel;
using Treina_LexIn.Presenters;

namespace Treina_LexIn
{
    public partial class Ribbon1
    {
        private Ribbon1Presenter ribbonPresenter = Ribbon1Presenter.Instance;
        private Localizar_Substituir painelLocaliza;
        private Microsoft.Office.Tools.CustomTaskPane painelLateral;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        #region Botões

        private void btnSaveAsPdf_Click(object sender, RibbonControlEventArgs e)
        {
            ribbonPresenter.SalvarComoPDF();           
        }

        private void btnAddImagem_Click(object sender, RibbonControlEventArgs e)
        {
            ribbonPresenter.InserirImagem();
        }

        private void btnAddTabela_Click(object sender, RibbonControlEventArgs e)
        {
            AddTabela formTabela = new AddTabela();
            formTabela.ShowDialog();           
        }

        private void btnInverteCase_Click(object sender, RibbonControlEventArgs e)
        {
            ribbonPresenter.InverterCase();
        }

        private void btdLocalizar_Substituir_Click(object sender, RibbonControlEventArgs e)
        {
            painelLocaliza = new Localizar_Substituir();
            painelLateral = Globals.ThisAddIn.CustomTaskPanes.Add(painelLocaliza, "Localizar e Substituir");
            painelLateral.Visible = true;
        }
        #endregion


    }
}
   

