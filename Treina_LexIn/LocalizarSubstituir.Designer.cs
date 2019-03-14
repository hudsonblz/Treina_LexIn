namespace Treina_LexIn
{
    partial class LocalizarSubstituir
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnLocalizarProximo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBusca = new System.Windows.Forms.TextBox();
            this.chbCaseSensitive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSubstituicao = new System.Windows.Forms.TextBox();
            this.btnSubstituir = new System.Windows.Forms.Button();
            this.btnSubstituirTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLocalizarProximo
            // 
            this.btnLocalizarProximo.Enabled = false;
            this.btnLocalizarProximo.Location = new System.Drawing.Point(207, 167);
            this.btnLocalizarProximo.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
            this.btnLocalizarProximo.Name = "btnLocalizarProximo";
            this.btnLocalizarProximo.Size = new System.Drawing.Size(107, 23);
            this.btnLocalizarProximo.TabIndex = 1;
            this.btnLocalizarProximo.Text = "Localizar Próximo";
            this.btnLocalizarProximo.UseVisualStyleBackColor = true;
            this.btnLocalizarProximo.Click += new System.EventHandler(this.btnLocalizarProximo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Localizar:";
            // 
            // txbBusca
            // 
            this.txbBusca.Location = new System.Drawing.Point(85, 51);
            this.txbBusca.Name = "txbBusca";
            this.txbBusca.Size = new System.Drawing.Size(150, 20);
            this.txbBusca.TabIndex = 0;
            this.txbBusca.TextChanged += new System.EventHandler(this.txbBusca_TextChanged);
            // 
            // chbCaseSensitive
            // 
            this.chbCaseSensitive.AutoSize = true;
            this.chbCaseSensitive.Location = new System.Drawing.Point(8, 119);
            this.chbCaseSensitive.Name = "chbCaseSensitive";
            this.chbCaseSensitive.Size = new System.Drawing.Size(198, 17);
            this.chbCaseSensitive.TabIndex = 2;
            this.chbCaseSensitive.Text = "Diferenciar Maiúsculas e Minúsculas";
            this.chbCaseSensitive.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Substituir por:";
            // 
            // txbSubstituicao
            // 
            this.txbSubstituicao.Location = new System.Drawing.Point(85, 84);
            this.txbSubstituicao.Name = "txbSubstituicao";
            this.txbSubstituicao.Size = new System.Drawing.Size(150, 20);
            this.txbSubstituicao.TabIndex = 4;
            this.txbSubstituicao.TextChanged += new System.EventHandler(this.txbSubstituicao_TextChanged);
            // 
            // btnSubstituir
            // 
            this.btnSubstituir.Enabled = false;
            this.btnSubstituir.Location = new System.Drawing.Point(126, 167);
            this.btnSubstituir.Name = "btnSubstituir";
            this.btnSubstituir.Size = new System.Drawing.Size(75, 23);
            this.btnSubstituir.TabIndex = 5;
            this.btnSubstituir.Text = "Substituir";
            this.btnSubstituir.UseVisualStyleBackColor = true;
            this.btnSubstituir.Click += new System.EventHandler(this.btnSubstituir_Click);
            // 
            // btnSubstituirTodos
            // 
            this.btnSubstituirTodos.Enabled = false;
            this.btnSubstituirTodos.Location = new System.Drawing.Point(24, 167);
            this.btnSubstituirTodos.Name = "btnSubstituirTodos";
            this.btnSubstituirTodos.Size = new System.Drawing.Size(96, 23);
            this.btnSubstituirTodos.TabIndex = 6;
            this.btnSubstituirTodos.Text = "Substituir Todas";
            this.btnSubstituirTodos.UseVisualStyleBackColor = true;
            this.btnSubstituirTodos.Click += new System.EventHandler(this.btnSubstituirTodos_Click);
            // 
            // Localizar_Substituir
            // 
            this.ClientSize = new System.Drawing.Size(328, 200);
            this.Controls.Add(this.btnSubstituirTodos);
            this.Controls.Add(this.btnSubstituir);
            this.Controls.Add(this.txbSubstituicao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbCaseSensitive);
            this.Controls.Add(this.txbBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLocalizarProximo);
            this.Name = "Localizar_Substituir";
            this.Load += new System.EventHandler(this.Localizar_Substituir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalizarProximo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBusca;
        private System.Windows.Forms.CheckBox chbCaseSensitive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSubstituicao;
        private System.Windows.Forms.Button btnSubstituir;
        private System.Windows.Forms.Button btnSubstituirTodos;
    }
}
