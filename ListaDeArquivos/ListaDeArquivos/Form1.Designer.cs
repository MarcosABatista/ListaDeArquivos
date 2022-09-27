namespace ListaDeArquivos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botao = new System.Windows.Forms.Button();
            this.arquivos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botao
            // 
            this.botao.Location = new System.Drawing.Point(12, 114);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(114, 25);
            this.botao.TabIndex = 0;
            this.botao.Text = "Selecionar pasta";
            this.botao.UseVisualStyleBackColor = true;
            this.botao.Click += new System.EventHandler(this.botao_Click);
            // 
            // arquivos
            // 
            this.arquivos.FormattingEnabled = true;
            this.arquivos.ItemHeight = 15;
            this.arquivos.Location = new System.Drawing.Point(12, 145);
            this.arquivos.Name = "arquivos";
            this.arquivos.Size = new System.Drawing.Size(421, 154);
            this.arquivos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arquivos);
            this.Controls.Add(this.botao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button botao;
        private ListBox arquivos;
        private Label label1;
    }
}