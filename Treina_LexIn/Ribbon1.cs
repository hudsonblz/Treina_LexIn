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
using Treina_LexIn.Properties;

namespace Treina_LexIn
{
    public partial class Ribbon1
    {
        private Ribbon1Presenter ribbonPresenter = Ribbon1Presenter.Instance;
        private LocalizarSubstituir painelLocaliza;
        private Microsoft.Office.Tools.CustomTaskPane painelLateral;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            btnSaveAsPdf.Label = Locale_PT_br.Ribbon_btnSaveAsPdf;
            btnAddImagem.Label = Locale_PT_br.Ribbon_btnAddImagem;
            btnAddTabela.Label = Locale_PT_br.Ribbon_btnAddTabela;
            btnInverteCase.Label = Locale_PT_br.Ribbon_btnInverteCase;
            btnLocalizar_Substituir.Label = Locale_PT_br.Ribbon_btnLocalizar_Substituir;
            btnAdicionarCampo.Label = Locale_PT_br.Ribbon_btnAdicionarCampo;
            btnAdicionarSpan.Label = Locale_PT_br.Ribbon_btnAdicionarSpan;
            btnQualificacao.Label = Locale_PT_br.Ribbon_btnQualificacao;
            group1.Label = Locale_PT_br.Ribbon_nomeGrupo;
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
            formTabela.Dispose();
        }

        private void btnInverteCase_Click(object sender, RibbonControlEventArgs e)
        {
            ribbonPresenter.InverterCase();
        }

        private void btnLocalizar_Substituir_Click(object sender, RibbonControlEventArgs e)
        {
            LocalizarSubstituir localizar_Substituir = new LocalizarSubstituir();
            localizar_Substituir.ShowDialog();
        }

        private void btnAdicionarCampo_Click(object sender, RibbonControlEventArgs e)
        {
            AdicionarCampo formAddCampo = new AdicionarCampo();
            formAddCampo.ShowDialog();
            formAddCampo.Dispose();
        }

        private void btnAdicionarSpan_Click(object sender, RibbonControlEventArgs e)
        {
            AdicionarSpan adicionarSpan = new AdicionarSpan();
            adicionarSpan.ShowDialog();
            adicionarSpan.Dispose();
        }

        private void btnQualificacao_Click(object sender, RibbonControlEventArgs e)
        {
            Contato contatoForm = new Contato();
            contatoForm.ShowDialog();
            contatoForm.Dispose();
        }

        #endregion
    }
}
   

