namespace Treina_LexIn
{
    partial class AdicionarSpan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdicionarSpan = new System.Windows.Forms.Button();
            this.txbTextoCampo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdicionarSpan
            // 
            this.btnAdicionarSpan.Location = new System.Drawing.Point(142, 38);
            this.btnAdicionarSpan.Name = "btnAdicionarSpan";
            this.btnAdicionarSpan.Size = new System.Drawing.Size(106, 23);
            this.btnAdicionarSpan.TabIndex = 1;
            this.btnAdicionarSpan.Text = "Adicionar Span";
            this.btnAdicionarSpan.UseVisualStyleBackColor = true;
            this.btnAdicionarSpan.Click += new System.EventHandler(this.btnAdicionarSpan_Click);
            // 
            // txbTextoCampo
            // 
            this.txbTextoCampo.Location = new System.Drawing.Point(104, 12);
            this.txbTextoCampo.Name = "txbTextoCampo";
            this.txbTextoCampo.Size = new System.Drawing.Size(144, 20);
            this.txbTextoCampo.TabIndex = 0;
            this.txbTextoCampo.TextChanged += new System.EventHandler(this.txbTextoCampo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto do Span:";
            // 
            // AdicionarSpan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 89);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTextoCampo);
            this.Controls.Add(this.btnAdicionarSpan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdicionarSpan";
            this.Text = "Adicionar Campo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarSpan;
        private System.Windows.Forms.TextBox txbTextoCampo;
        private System.Windows.Forms.Label label1;
    }
}