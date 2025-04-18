namespace CalculadoraDeJuros
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
            this.CalJuros = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.txtMontante = new System.Windows.Forms.TextBox();
            this.MontText = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.Captext = new System.Windows.Forms.Label();
            this.TaxaText = new System.Windows.Forms.Label();
            this.TempoText = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.JurosText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalJuros
            // 
            this.CalJuros.AutoSize = true;
            this.CalJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalJuros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CalJuros.Location = new System.Drawing.Point(239, 9);
            this.CalJuros.Name = "CalJuros";
            this.CalJuros.Size = new System.Drawing.Size(316, 33);
            this.CalJuros.TabIndex = 0;
            this.CalJuros.Text = "Calculadora De Juros";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(94, 102);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(280, 24);
            this.text1.TabIndex = 1;
            this.text1.Text = "Selecione o que deseja calcular";
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOpcoes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpcoes.FormattingEnabled = true;
            this.cbOpcoes.Items.AddRange(new object[] {
            "Montante",
            "Capital",
            "Taxa ",
            "Tempo",
            "Juros"});
            this.cbOpcoes.Location = new System.Drawing.Point(98, 129);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(259, 24);
            this.cbOpcoes.TabIndex = 2;
            // 
            // txtMontante
            // 
            this.txtMontante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontante.Location = new System.Drawing.Point(120, 197);
            this.txtMontante.Name = "txtMontante";
            this.txtMontante.Size = new System.Drawing.Size(234, 26);
            this.txtMontante.TabIndex = 3;
            // 
            // MontText
            // 
            this.MontText.AutoSize = true;
            this.MontText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontText.Location = new System.Drawing.Point(12, 197);
            this.MontText.Name = "MontText";
            this.MontText.Size = new System.Drawing.Size(102, 24);
            this.MontText.TabIndex = 7;
            this.MontText.Text = "Montante:";
            // 
            // txtCapital
            // 
            this.txtCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapital.Location = new System.Drawing.Point(120, 250);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(234, 26);
            this.txtCapital.TabIndex = 8;
            // 
            // txtTaxa
            // 
            this.txtTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxa.Location = new System.Drawing.Point(120, 314);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(234, 26);
            this.txtTaxa.TabIndex = 9;
            // 
            // txtTempo
            // 
            this.txtTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempo.Location = new System.Drawing.Point(120, 374);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(234, 26);
            this.txtTempo.TabIndex = 10;
            // 
            // Captext
            // 
            this.Captext.AutoSize = true;
            this.Captext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Captext.Location = new System.Drawing.Point(12, 252);
            this.Captext.Name = "Captext";
            this.Captext.Size = new System.Drawing.Size(79, 24);
            this.Captext.TabIndex = 11;
            this.Captext.Text = "Capital:";
            // 
            // TaxaText
            // 
            this.TaxaText.AutoSize = true;
            this.TaxaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxaText.Location = new System.Drawing.Point(12, 316);
            this.TaxaText.Name = "TaxaText";
            this.TaxaText.Size = new System.Drawing.Size(62, 24);
            this.TaxaText.TabIndex = 12;
            this.TaxaText.Text = "Taxa:";
            // 
            // TempoText
            // 
            this.TempoText.AutoSize = true;
            this.TempoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempoText.Location = new System.Drawing.Point(12, 376);
            this.TempoText.Name = "TempoText";
            this.TempoText.Size = new System.Drawing.Size(82, 24);
            this.TempoText.TabIndex = 13;
            this.TempoText.Text = "Tempo:";
            // 
            // txtJuros
            // 
            this.txtJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJuros.Location = new System.Drawing.Point(120, 439);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(234, 26);
            this.txtJuros.TabIndex = 14;
            // 
            // JurosText
            // 
            this.JurosText.AutoSize = true;
            this.JurosText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JurosText.Location = new System.Drawing.Point(12, 441);
            this.JurosText.Name = "JurosText";
            this.JurosText.Size = new System.Drawing.Size(67, 24);
            this.JurosText.TabIndex = 15;
            this.JurosText.Text = "Juros:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Yellow;
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(98, 494);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(113, 36);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.LightGreen;
            this.btnNovo.ForeColor = System.Drawing.Color.Black;
            this.btnNovo.Location = new System.Drawing.Point(241, 494);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(113, 36);
            this.btnNovo.TabIndex = 18;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 555);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.JurosText);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.TempoText);
            this.Controls.Add(this.TaxaText);
            this.Controls.Add(this.Captext);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.MontText);
            this.Controls.Add(this.txtMontante);
            this.Controls.Add(this.cbOpcoes);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.CalJuros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CalJuros;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.TextBox txtMontante;
        private System.Windows.Forms.Label MontText;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label Captext;
        private System.Windows.Forms.Label TaxaText;
        private System.Windows.Forms.Label TempoText;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label JurosText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNovo;
    }
}

