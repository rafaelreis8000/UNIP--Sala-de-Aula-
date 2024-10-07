namespace VerificarNumeros
{
    partial class FrmVerifica
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
            label1 = new Label();
            txtnum = new TextBox();
            lblresultado = new Label();
            groupBox1 = new GroupBox();
            btnSair = new Button();
            btnCancela = new Button();
            btnVerifica = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(143, 16);
            label1.TabIndex = 0;
            label1.Text = "Digite um número";
            // 
            // txtnum
            // 
            txtnum.Location = new Point(174, 23);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(159, 26);
            txtnum.TabIndex = 1;
            txtnum.TextAlign = HorizontalAlignment.Center;
            // 
            // lblresultado
            // 
            lblresultado.BorderStyle = BorderStyle.FixedSingle;
            lblresultado.Location = new Point(25, 75);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(308, 25);
            lblresultado.TabIndex = 2;
            lblresultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSair);
            groupBox1.Controls.Add(btnCancela);
            groupBox1.Controls.Add(btnVerifica);
            groupBox1.Location = new Point(25, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 101);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(106, 25);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 29);
            btnSair.TabIndex = 2;
            btnSair.Text = "&Cancelar";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnCancela
            // 
            btnCancela.Location = new Point(206, 25);
            btnCancela.Name = "btnCancela";
            btnCancela.Size = new Size(94, 29);
            btnCancela.TabIndex = 1;
            btnCancela.Text = "&Sair";
            btnCancela.UseVisualStyleBackColor = true;
            btnCancela.Click += btnCancela_Click;
            // 
            // btnVerifica
            // 
            btnVerifica.Location = new Point(6, 25);
            btnVerifica.Name = "btnVerifica";
            btnVerifica.Size = new Size(94, 29);
            btnVerifica.TabIndex = 0;
            btnVerifica.Text = "&Verifica";
            btnVerifica.UseVisualStyleBackColor = true;
            btnVerifica.Click += btnVerifica_Click;
            // 
            // FrmVerifica
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 225);
            Controls.Add(groupBox1);
            Controls.Add(lblresultado);
            Controls.Add(txtnum);
            Controls.Add(label1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmVerifica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verificação de Números";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnum;
        private Label lblresultado;
        private GroupBox groupBox1;
        private Button btnSair;
        private Button btnCancela;
        private Button btnVerifica;
    }
}
