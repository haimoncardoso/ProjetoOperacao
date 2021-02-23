namespace ProjetoOperacao
{
    partial class FrmOperecao
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
            this.BtnAdicao = new System.Windows.Forms.Button();
            this.BtnMultiplicacao = new System.Windows.Forms.Button();
            this.BtnDivisao = new System.Windows.Forms.Button();
            this.BtnSubtracao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btnfechar = new System.Windows.Forms.Button();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtNumero1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAdicao
            // 
            this.BtnAdicao.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnAdicao.FlatAppearance.BorderSize = 0;
            this.BtnAdicao.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BtnAdicao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnAdicao.Location = new System.Drawing.Point(236, 263);
            this.BtnAdicao.Name = "BtnAdicao";
            this.BtnAdicao.Size = new System.Drawing.Size(150, 33);
            this.BtnAdicao.TabIndex = 0;
            this.BtnAdicao.Text = "+";
            this.BtnAdicao.UseVisualStyleBackColor = true;
            this.BtnAdicao.Click += new System.EventHandler(this.BtnAdicao_Click);
            // 
            // BtnMultiplicacao
            // 
            this.BtnMultiplicacao.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnMultiplicacao.FlatAppearance.BorderSize = 0;
            this.BtnMultiplicacao.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BtnMultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplicacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnMultiplicacao.Location = new System.Drawing.Point(236, 302);
            this.BtnMultiplicacao.Name = "BtnMultiplicacao";
            this.BtnMultiplicacao.Size = new System.Drawing.Size(150, 31);
            this.BtnMultiplicacao.TabIndex = 0;
            this.BtnMultiplicacao.Text = "/";
            this.BtnMultiplicacao.UseVisualStyleBackColor = true;
            this.BtnMultiplicacao.Click += new System.EventHandler(this.BtnMultiplicacao_Click);
            // 
            // BtnDivisao
            // 
            this.BtnDivisao.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnDivisao.FlatAppearance.BorderSize = 0;
            this.BtnDivisao.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BtnDivisao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivisao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnDivisao.Location = new System.Drawing.Point(392, 302);
            this.BtnDivisao.Name = "BtnDivisao";
            this.BtnDivisao.Size = new System.Drawing.Size(118, 31);
            this.BtnDivisao.TabIndex = 0;
            this.BtnDivisao.Text = "*";
            this.BtnDivisao.UseVisualStyleBackColor = true;
            this.BtnDivisao.Click += new System.EventHandler(this.BtnDivisao_Click);
            // 
            // BtnSubtracao
            // 
            this.BtnSubtracao.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnSubtracao.FlatAppearance.BorderSize = 0;
            this.BtnSubtracao.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BtnSubtracao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtracao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSubtracao.Location = new System.Drawing.Point(392, 263);
            this.BtnSubtracao.Name = "BtnSubtracao";
            this.BtnSubtracao.Size = new System.Drawing.Size(118, 33);
            this.BtnSubtracao.TabIndex = 0;
            this.BtnSubtracao.Text = "-";
            this.BtnSubtracao.UseVisualStyleBackColor = true;
            this.BtnSubtracao.Click += new System.EventHandler(this.BtnSubtracao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operações Aritmétricas";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(247, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "2°Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(247, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "1°Número";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btnfechar);
            this.panel1.Location = new System.Drawing.Point(72, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 100);
            this.panel1.TabIndex = 4;
            // 
            // Btnfechar
            // 
            this.Btnfechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btnfechar.FlatAppearance.BorderSize = 0;
            this.Btnfechar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnfechar.ForeColor = System.Drawing.Color.Red;
            this.Btnfechar.Location = new System.Drawing.Point(604, 3);
            this.Btnfechar.Name = "Btnfechar";
            this.Btnfechar.Size = new System.Drawing.Size(39, 33);
            this.Btnfechar.TabIndex = 0;
            this.Btnfechar.Text = "X";
            this.Btnfechar.UseVisualStyleBackColor = true;
            this.Btnfechar.Click += new System.EventHandler(this.Btnfechar_Click);
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(360, 172);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(100, 20);
            this.TxtNumero.TabIndex = 5;
            this.TxtNumero.TextChanged += new System.EventHandler(this.TxtNumero_TextChanged);
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // TxtNumero1
            // 
            this.TxtNumero1.Location = new System.Drawing.Point(360, 218);
            this.TxtNumero1.Name = "TxtNumero1";
            this.TxtNumero1.Size = new System.Drawing.Size(100, 20);
            this.TxtNumero1.TabIndex = 5;
            this.TxtNumero1.TextChanged += new System.EventHandler(this.TxtNumero1_TextChanged);
            this.TxtNumero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero1_KeyPress);
            // 
            // FrmOperecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(757, 365);
            this.Controls.Add(this.TxtNumero1);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSubtracao);
            this.Controls.Add(this.BtnDivisao);
            this.Controls.Add(this.BtnMultiplicacao);
            this.Controls.Add(this.BtnAdicao);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOperecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdicao;
        private System.Windows.Forms.Button BtnMultiplicacao;
        private System.Windows.Forms.Button BtnDivisao;
        private System.Windows.Forms.Button BtnSubtracao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtNumero1;
        private System.Windows.Forms.Button Btnfechar;
    }
}

