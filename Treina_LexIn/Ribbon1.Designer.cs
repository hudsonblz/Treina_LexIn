namespace Treina_LexIn
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnSaveAsPdf = this.Factory.CreateRibbonButton();
            this.btnAddImagem = this.Factory.CreateRibbonButton();
            this.btnAddTabela = this.Factory.CreateRibbonButton();
            this.btnInverteCase = this.Factory.CreateRibbonButton();
            this.btdLocalizar_Substituir = this.Factory.CreateRibbonButton();
            this.btnAdicionarCampo = this.Factory.CreateRibbonButton();
            this.btnAdicionarSpan = this.Factory.CreateRibbonButton();
            this.btnQualificacao = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "Treina  LexIn";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnSaveAsPdf);
            this.group1.Items.Add(this.btnAddImagem);
            this.group1.Items.Add(this.btnAddTabela);
            this.group1.Items.Add(this.btnInverteCase);
            this.group1.Items.Add(this.btdLocalizar_Substituir);
            this.group1.Items.Add(this.btnAdicionarCampo);
            this.group1.Items.Add(this.btnAdicionarSpan);
            this.group1.Items.Add(this.btnQualificacao);
            this.group1.Label = "Ferramentas";
            this.group1.Name = "group1";
            // 
            // btnSaveAsPdf
            // 
            this.btnSaveAsPdf.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSaveAsPdf.Label = "Salvar como PDF";
            this.btnSaveAsPdf.Name = "btnSaveAsPdf";
            this.btnSaveAsPdf.OfficeImageId = "FileSaveAsPdfOrXps";
            this.btnSaveAsPdf.ShowImage = true;
            this.btnSaveAsPdf.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSaveAsPdf_Click);
            // 
            // btnAddImagem
            // 
            this.btnAddImagem.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAddImagem.Label = "Adicionar Imagem";
            this.btnAddImagem.Name = "btnAddImagem";
            this.btnAddImagem.OfficeImageId = "PictureInsertFromFile";
            this.btnAddImagem.ShowImage = true;
            this.btnAddImagem.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddImagem_Click);
            // 
            // btnAddTabela
            // 
            this.btnAddTabela.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAddTabela.Label = "Adicionar Tabela";
            this.btnAddTabela.Name = "btnAddTabela";
            this.btnAddTabela.OfficeImageId = "QueryShowTable";
            this.btnAddTabela.ShowImage = true;
            this.btnAddTabela.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddTabela_Click);
            // 
            // btnInverteCase
            // 
            this.btnInverteCase.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnInverteCase.Label = "Inverter Captalização";
            this.btnInverteCase.Name = "btnInverteCase";
            this.btnInverteCase.OfficeImageId = "ChangeCase";
            this.btnInverteCase.ShowImage = true;
            this.btnInverteCase.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnInverteCase_Click);
            // 
            // btdLocalizar_Substituir
            // 
            this.btdLocalizar_Substituir.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btdLocalizar_Substituir.Label = "Localizar e Substituir";
            this.btdLocalizar_Substituir.Name = "btdLocalizar_Substituir";
            this.btdLocalizar_Substituir.OfficeImageId = "ReplaceDialog";
            this.btdLocalizar_Substituir.ShowImage = true;
            this.btdLocalizar_Substituir.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btdLocalizar_Substituir_Click);
            // 
            // btnAdicionarCampo
            // 
            this.btnAdicionarCampo.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAdicionarCampo.Label = "Adicionar Campo";
            this.btnAdicionarCampo.Name = "btnAdicionarCampo";
            this.btnAdicionarCampo.OfficeImageId = "FieldInsert";
            this.btnAdicionarCampo.ShowImage = true;
            this.btnAdicionarCampo.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAdicionarCampo_Click);
            // 
            // btnAdicionarSpan
            // 
            this.btnAdicionarSpan.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAdicionarSpan.Label = "Adicionar Span";
            this.btnAdicionarSpan.Name = "btnAdicionarSpan";
            this.btnAdicionarSpan.OfficeImageId = "FieldInsert";
            this.btnAdicionarSpan.ShowImage = true;
            this.btnAdicionarSpan.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAdicionarSpan_Click);
            // 
            // btnQualificacao
            // 
            this.btnQualificacao.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnQualificacao.Label = "Qualificação PJ";
            this.btnQualificacao.Name = "btnQualificacao";
            this.btnQualificacao.OfficeImageId = "BusinessCardInsertMenu";
            this.btnQualificacao.ShowImage = true;
            this.btnQualificacao.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnQualificacao_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSaveAsPdf;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAddImagem;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAddTabela;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnInverteCase;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btdLocalizar_Substituir;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAdicionarCampo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAdicionarSpan;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnQualificacao;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
