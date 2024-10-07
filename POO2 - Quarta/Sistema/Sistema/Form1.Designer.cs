namespace Sistema
{
    partial class Sistema
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
            menuStrip1 = new MenuStrip();
            CadastroToolStripMenuItem = new ToolStripMenuItem();
            ProdutoToolStripMenuItem = new ToolStripMenuItem();
            ClienteToolStripMenuItem = new ToolStripMenuItem();
            FecharToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { CadastroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1117, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // CadastroToolStripMenuItem
            // 
            CadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ProdutoToolStripMenuItem, ClienteToolStripMenuItem, FecharToolStripMenuItem });
            CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem";
            CadastroToolStripMenuItem.Size = new Size(99, 24);
            CadastroToolStripMenuItem.Text = "CADASTRO";
            // 
            // ProdutoToolStripMenuItem
            // 
            ProdutoToolStripMenuItem.Name = "ProdutoToolStripMenuItem";
            ProdutoToolStripMenuItem.Size = new Size(224, 26);
            ProdutoToolStripMenuItem.Text = "Produto";
            ProdutoToolStripMenuItem.Click += ProdutoToolStripMenuItem_Click;
            // 
            // ClienteToolStripMenuItem
            // 
            ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem";
            ClienteToolStripMenuItem.Size = new Size(224, 26);
            ClienteToolStripMenuItem.Text = "Cliente";
            ClienteToolStripMenuItem.Click += ClienteToolStripMenuItem_Click;
            // 
            // FecharToolStripMenuItem
            // 
            FecharToolStripMenuItem.Name = "FecharToolStripMenuItem";
            FecharToolStripMenuItem.Size = new Size(224, 26);
            FecharToolStripMenuItem.Text = "Fechar";
            FecharToolStripMenuItem.Click += FecharToolStripMenuItem_Click;
            // 
            // Sistema
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 609);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Sistema";
            Text = "SISTEMA";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem CadastroToolStripMenuItem;
        private ToolStripMenuItem ProdutoToolStripMenuItem;
        private ToolStripMenuItem ClienteToolStripMenuItem;
        private ToolStripMenuItem FecharToolStripMenuItem;
    }
}
