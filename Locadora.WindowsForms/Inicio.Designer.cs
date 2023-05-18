namespace Locadora.WindowsForms
{
    partial class Inicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeGeneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.cadastroDeCategoriaToolStripMenuItem,
            this.cadastroDeGeneroToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(50, 20);
            this.Menu.Text = "Menu";
            this.Menu.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes";
            this.cadastroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
            // 
            // cadastroDeCategoriaToolStripMenuItem
            // 
            this.cadastroDeCategoriaToolStripMenuItem.Name = "cadastroDeCategoriaToolStripMenuItem";
            this.cadastroDeCategoriaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cadastroDeCategoriaToolStripMenuItem.Text = "Cadastro de Categoria";
            this.cadastroDeCategoriaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCategoriaToolStripMenuItem_Click);
            // 
            // cadastroDeGeneroToolStripMenuItem
            // 
            this.cadastroDeGeneroToolStripMenuItem.Name = "cadastroDeGeneroToolStripMenuItem";
            this.cadastroDeGeneroToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cadastroDeGeneroToolStripMenuItem.Text = "Cadastro de Genero";
            this.cadastroDeGeneroToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeGeneroToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 316);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeGeneroToolStripMenuItem;
    }
}