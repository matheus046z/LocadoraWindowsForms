namespace Locadora.WindowsForms
{
    partial class CadastroGenero
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
            this.txtNomeGenero = new System.Windows.Forms.TextBox();
            this.btnCadastrarGenero = new System.Windows.Forms.Button();
            this.txtGenero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeGenero
            // 
            this.txtNomeGenero.Location = new System.Drawing.Point(83, 61);
            this.txtNomeGenero.Name = "txtNomeGenero";
            this.txtNomeGenero.Size = new System.Drawing.Size(100, 20);
            this.txtNomeGenero.TabIndex = 0;
            // 
            // btnCadastrarGenero
            // 
            this.btnCadastrarGenero.Location = new System.Drawing.Point(83, 97);
            this.btnCadastrarGenero.Name = "btnCadastrarGenero";
            this.btnCadastrarGenero.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarGenero.TabIndex = 1;
            this.btnCadastrarGenero.Text = "Cadastrar";
            this.btnCadastrarGenero.UseVisualStyleBackColor = true;
            this.btnCadastrarGenero.Click += new System.EventHandler(this.btnCadastrarGenero_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.AutoSize = true;
            this.txtGenero.Location = new System.Drawing.Point(80, 45);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(86, 13);
            this.txtGenero.TabIndex = 2;
            this.txtGenero.Text = "Nome do gênero";
            // 
            // CadastroGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 168);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.btnCadastrarGenero);
            this.Controls.Add(this.txtNomeGenero);
            this.Name = "CadastroGenero";
            this.Text = "Cadastro de Genero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeGenero;
        private System.Windows.Forms.Button btnCadastrarGenero;
        private System.Windows.Forms.Label txtGenero;
    }
}