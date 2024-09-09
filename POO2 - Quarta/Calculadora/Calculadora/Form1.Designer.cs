namespace Calculadora
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.texto_resultado = new System.Windows.Forms.TextBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.btn_porcentagem = new System.Windows.Forms.Button();
            this.btn_1porX = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.btn_subtrair = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_virgula = new System.Windows.Forms.Button();
            this.btn_invert = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_um = new System.Windows.Forms.Button();
            this.btn_dois = new System.Windows.Forms.Button();
            this.btn_tres = new System.Windows.Forms.Button();
            this.btn_quatro = new System.Windows.Forms.Button();
            this.btn_cinco = new System.Windows.Forms.Button();
            this.btn_seis = new System.Windows.Forms.Button();
            this.btn_sete = new System.Windows.Forms.Button();
            this.btn_oito = new System.Windows.Forms.Button();
            this.btn_nove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto_resultado
            // 
            this.texto_resultado.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_resultado.Location = new System.Drawing.Point(12, 12);
            this.texto_resultado.Multiline = true;
            this.texto_resultado.Name = "texto_resultado";
            this.texto_resultado.Size = new System.Drawing.Size(318, 52);
            this.texto_resultado.TabIndex = 2;
            this.texto_resultado.TextChanged += new System.EventHandler(this.texto_resultado_TextChanged);
            // 
            // bt_clear
            // 
            this.bt_clear.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clear.ForeColor = System.Drawing.Color.Crimson;
            this.bt_clear.Location = new System.Drawing.Point(12, 70);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 52);
            this.bt_clear.TabIndex = 3;
            this.bt_clear.Text = "C";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // btn_porcentagem
            // 
            this.btn_porcentagem.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_porcentagem.ForeColor = System.Drawing.Color.Crimson;
            this.btn_porcentagem.Location = new System.Drawing.Point(93, 70);
            this.btn_porcentagem.Name = "btn_porcentagem";
            this.btn_porcentagem.Size = new System.Drawing.Size(75, 52);
            this.btn_porcentagem.TabIndex = 4;
            this.btn_porcentagem.Text = "%";
            this.btn_porcentagem.UseVisualStyleBackColor = true;
            this.btn_porcentagem.Click += new System.EventHandler(this.btn_porcentagem_Click);
            // 
            // btn_1porX
            // 
            this.btn_1porX.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1porX.ForeColor = System.Drawing.Color.Crimson;
            this.btn_1porX.Location = new System.Drawing.Point(174, 70);
            this.btn_1porX.Name = "btn_1porX";
            this.btn_1porX.Size = new System.Drawing.Size(75, 52);
            this.btn_1porX.TabIndex = 5;
            this.btn_1porX.Text = "1/X";
            this.btn_1porX.UseVisualStyleBackColor = true;
            this.btn_1porX.Click += new System.EventHandler(this.btn_1porX_Click);
            // 
            // btn_dividir
            // 
            this.btn_dividir.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dividir.ForeColor = System.Drawing.Color.Crimson;
            this.btn_dividir.Location = new System.Drawing.Point(255, 70);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(75, 52);
            this.btn_dividir.TabIndex = 6;
            this.btn_dividir.Text = "/";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplicar.ForeColor = System.Drawing.Color.Crimson;
            this.btn_multiplicar.Location = new System.Drawing.Point(255, 128);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(75, 52);
            this.btn_multiplicar.TabIndex = 7;
            this.btn_multiplicar.Text = "*";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicar_Click);
            // 
            // btn_subtrair
            // 
            this.btn_subtrair.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtrair.ForeColor = System.Drawing.Color.Crimson;
            this.btn_subtrair.Location = new System.Drawing.Point(255, 186);
            this.btn_subtrair.Name = "btn_subtrair";
            this.btn_subtrair.Size = new System.Drawing.Size(75, 52);
            this.btn_subtrair.TabIndex = 8;
            this.btn_subtrair.Text = "-";
            this.btn_subtrair.UseVisualStyleBackColor = true;
            this.btn_subtrair.Click += new System.EventHandler(this.btn_subtrair_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.Color.Crimson;
            this.btn_adicionar.Location = new System.Drawing.Point(255, 244);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 52);
            this.btn_adicionar.TabIndex = 9;
            this.btn_adicionar.Text = "+";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_igual.ForeColor = System.Drawing.Color.Crimson;
            this.btn_igual.Location = new System.Drawing.Point(255, 302);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(75, 52);
            this.btn_igual.TabIndex = 10;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = true;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_virgula
            // 
            this.btn_virgula.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_virgula.ForeColor = System.Drawing.Color.Crimson;
            this.btn_virgula.Location = new System.Drawing.Point(174, 302);
            this.btn_virgula.Name = "btn_virgula";
            this.btn_virgula.Size = new System.Drawing.Size(75, 52);
            this.btn_virgula.TabIndex = 11;
            this.btn_virgula.Text = ",";
            this.btn_virgula.UseVisualStyleBackColor = true;
            this.btn_virgula.Click += new System.EventHandler(this.btn_virgula_Click);
            // 
            // btn_invert
            // 
            this.btn_invert.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invert.ForeColor = System.Drawing.Color.Crimson;
            this.btn_invert.Location = new System.Drawing.Point(12, 302);
            this.btn_invert.Name = "btn_invert";
            this.btn_invert.Size = new System.Drawing.Size(75, 52);
            this.btn_invert.TabIndex = 12;
            this.btn_invert.Text = "+-";
            this.btn_invert.UseVisualStyleBackColor = true;
            this.btn_invert.Click += new System.EventHandler(this.btn_invert_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zero.ForeColor = System.Drawing.Color.Crimson;
            this.btn_zero.Location = new System.Drawing.Point(93, 302);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(75, 52);
            this.btn_zero.TabIndex = 13;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // btn_um
            // 
            this.btn_um.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_um.ForeColor = System.Drawing.Color.Crimson;
            this.btn_um.Location = new System.Drawing.Point(12, 244);
            this.btn_um.Name = "btn_um";
            this.btn_um.Size = new System.Drawing.Size(75, 52);
            this.btn_um.TabIndex = 14;
            this.btn_um.Text = "1";
            this.btn_um.UseVisualStyleBackColor = true;
            this.btn_um.Click += new System.EventHandler(this.btn_um_Click);
            // 
            // btn_dois
            // 
            this.btn_dois.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dois.ForeColor = System.Drawing.Color.Crimson;
            this.btn_dois.Location = new System.Drawing.Point(93, 244);
            this.btn_dois.Name = "btn_dois";
            this.btn_dois.Size = new System.Drawing.Size(75, 52);
            this.btn_dois.TabIndex = 15;
            this.btn_dois.Text = "2";
            this.btn_dois.UseVisualStyleBackColor = true;
            this.btn_dois.Click += new System.EventHandler(this.btn_dois_Click);
            // 
            // btn_tres
            // 
            this.btn_tres.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tres.ForeColor = System.Drawing.Color.Crimson;
            this.btn_tres.Location = new System.Drawing.Point(174, 244);
            this.btn_tres.Name = "btn_tres";
            this.btn_tres.Size = new System.Drawing.Size(75, 52);
            this.btn_tres.TabIndex = 16;
            this.btn_tres.Text = "3";
            this.btn_tres.UseVisualStyleBackColor = true;
            this.btn_tres.Click += new System.EventHandler(this.btn_tres_Click);
            // 
            // btn_quatro
            // 
            this.btn_quatro.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quatro.ForeColor = System.Drawing.Color.Crimson;
            this.btn_quatro.Location = new System.Drawing.Point(12, 186);
            this.btn_quatro.Name = "btn_quatro";
            this.btn_quatro.Size = new System.Drawing.Size(75, 52);
            this.btn_quatro.TabIndex = 17;
            this.btn_quatro.Text = "4";
            this.btn_quatro.UseVisualStyleBackColor = true;
            this.btn_quatro.Click += new System.EventHandler(this.btn_quatro_Click);
            // 
            // btn_cinco
            // 
            this.btn_cinco.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cinco.ForeColor = System.Drawing.Color.Crimson;
            this.btn_cinco.Location = new System.Drawing.Point(93, 186);
            this.btn_cinco.Name = "btn_cinco";
            this.btn_cinco.Size = new System.Drawing.Size(75, 52);
            this.btn_cinco.TabIndex = 18;
            this.btn_cinco.Text = "5";
            this.btn_cinco.UseVisualStyleBackColor = true;
            this.btn_cinco.Click += new System.EventHandler(this.btn_cinco_Click);
            // 
            // btn_seis
            // 
            this.btn_seis.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seis.ForeColor = System.Drawing.Color.Crimson;
            this.btn_seis.Location = new System.Drawing.Point(174, 186);
            this.btn_seis.Name = "btn_seis";
            this.btn_seis.Size = new System.Drawing.Size(75, 52);
            this.btn_seis.TabIndex = 19;
            this.btn_seis.Text = "6";
            this.btn_seis.UseVisualStyleBackColor = true;
            this.btn_seis.Click += new System.EventHandler(this.btn_seis_Click);
            // 
            // btn_sete
            // 
            this.btn_sete.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sete.ForeColor = System.Drawing.Color.Crimson;
            this.btn_sete.Location = new System.Drawing.Point(12, 128);
            this.btn_sete.Name = "btn_sete";
            this.btn_sete.Size = new System.Drawing.Size(75, 52);
            this.btn_sete.TabIndex = 20;
            this.btn_sete.Text = "7";
            this.btn_sete.UseVisualStyleBackColor = true;
            this.btn_sete.Click += new System.EventHandler(this.btn_sete_Click);
            // 
            // btn_oito
            // 
            this.btn_oito.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_oito.ForeColor = System.Drawing.Color.Crimson;
            this.btn_oito.Location = new System.Drawing.Point(93, 128);
            this.btn_oito.Name = "btn_oito";
            this.btn_oito.Size = new System.Drawing.Size(75, 52);
            this.btn_oito.TabIndex = 21;
            this.btn_oito.Text = "8";
            this.btn_oito.UseVisualStyleBackColor = true;
            this.btn_oito.Click += new System.EventHandler(this.btn_oito_Click);
            // 
            // btn_nove
            // 
            this.btn_nove.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nove.ForeColor = System.Drawing.Color.Crimson;
            this.btn_nove.Location = new System.Drawing.Point(174, 128);
            this.btn_nove.Name = "btn_nove";
            this.btn_nove.Size = new System.Drawing.Size(75, 52);
            this.btn_nove.TabIndex = 22;
            this.btn_nove.Text = "9";
            this.btn_nove.UseVisualStyleBackColor = true;
            this.btn_nove.Click += new System.EventHandler(this.btn_nove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(345, 362);
            this.Controls.Add(this.btn_nove);
            this.Controls.Add(this.btn_oito);
            this.Controls.Add(this.btn_sete);
            this.Controls.Add(this.btn_seis);
            this.Controls.Add(this.btn_cinco);
            this.Controls.Add(this.btn_quatro);
            this.Controls.Add(this.btn_tres);
            this.Controls.Add(this.btn_dois);
            this.Controls.Add(this.btn_um);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_invert);
            this.Controls.Add(this.btn_virgula);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_subtrair);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.btn_1porX);
            this.Controls.Add(this.btn_porcentagem);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.texto_resultado);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texto_resultado;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button btn_porcentagem;
        private System.Windows.Forms.Button btn_1porX;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.Button btn_subtrair;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_virgula;
        private System.Windows.Forms.Button btn_invert;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_um;
        private System.Windows.Forms.Button btn_dois;
        private System.Windows.Forms.Button btn_tres;
        private System.Windows.Forms.Button btn_quatro;
        private System.Windows.Forms.Button btn_cinco;
        private System.Windows.Forms.Button btn_seis;
        private System.Windows.Forms.Button btn_sete;
        private System.Windows.Forms.Button btn_oito;
        private System.Windows.Forms.Button btn_nove;
    }
}

