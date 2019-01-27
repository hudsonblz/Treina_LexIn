namespace Treina_LexIn
{
    partial class Localizar_Substituir
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
            this.SuspendLayout();
            // 
            // btnLocalizarProximo
            // 
            this.btnLocalizarProximo.Enabled = false;
            this.btnLocalizarProximo.Location = new System.Drawing.Point(185, 82);
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
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Localizar:";
            // 
            // txbBusca
            // 
            this.txbBusca.Location = new System.Drawing.Point(70, 41);
            this.txbBusca.Name = "txbBusca";
            this.txbBusca.Size = new System.Drawing.Size(150, 20);
            this.txbBusca.TabIndex = 0;
            this.txbBusca.TextChanged += new System.EventHandler(this.txbBusca_TextChanged);
            // 
            // Localizar_Substituir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.txbBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLocalizarProximo);
            this.MinimumSize = new System.Drawing.Size(400, 0);
            this.Name = "Localizar_Substituir";
            this.Size = new System.Drawing.Size(400, 125);
            this.Load += new System.EventHandler(this.Localizar_Substituir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalizarProximo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBusca;
    }
}
