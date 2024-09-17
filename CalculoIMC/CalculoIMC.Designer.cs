
namespace CalculoIMC
{
    partial class CalculoIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculoIMC));
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbIMC = new System.Windows.Forms.GroupBox();
            this.ptbIMC = new System.Windows.Forms.PictureBox();
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.lblResultadoIMC = new System.Windows.Forms.Label();
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblGrau = new System.Windows.Forms.Label();
            this.lblResultadoGrau = new System.Windows.Forms.Label();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.lblResultadoClass = new System.Windows.Forms.Label();
            this.gpbIMC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIMC)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(78, 91);
            this.txtPeso.MaxLength = 5;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(150, 20);
            this.txtPeso.TabIndex = 1;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPeso.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPeso.Location = new System.Drawing.Point(22, 92);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(50, 17);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "PESO:";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTamanho.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTamanho.Location = new System.Drawing.Point(22, 133);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(67, 17);
            this.lblTamanho.TabIndex = 4;
            this.lblTamanho.Text = "ALTURA:";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(109, 132);
            this.txtTamanho.MaxLength = 5;
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(119, 20);
            this.txtTamanho.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalcular.Location = new System.Drawing.Point(594, 264);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(166, 50);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpar.Location = new System.Drawing.Point(594, 332);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(166, 50);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSair.Location = new System.Drawing.Point(594, 402);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(166, 50);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gpbIMC
            // 
            this.gpbIMC.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gpbIMC.Controls.Add(this.ptbIMC);
            this.gpbIMC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpbIMC.Location = new System.Drawing.Point(12, 245);
            this.gpbIMC.Name = "gpbIMC";
            this.gpbIMC.Size = new System.Drawing.Size(563, 207);
            this.gpbIMC.TabIndex = 13;
            this.gpbIMC.TabStop = false;
            this.gpbIMC.Text = "IMC";
            // 
            // ptbIMC
            // 
            this.ptbIMC.Image = ((System.Drawing.Image)(resources.GetObject("ptbIMC.Image")));
            this.ptbIMC.Location = new System.Drawing.Point(0, 19);
            this.ptbIMC.Name = "ptbIMC";
            this.ptbIMC.Size = new System.Drawing.Size(563, 200);
            this.ptbIMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbIMC.TabIndex = 0;
            this.ptbIMC.TabStop = false;
            // 
            // lblCalculadora
            // 
            this.lblCalculadora.AutoSize = true;
            this.lblCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCalculadora.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCalculadora.Location = new System.Drawing.Point(12, 34);
            this.lblCalculadora.Name = "lblCalculadora";
            this.lblCalculadora.Size = new System.Drawing.Size(186, 25);
            this.lblCalculadora.TabIndex = 14;
            this.lblCalculadora.Text = "Calculadora de IMC";
            // 
            // lblResultadoIMC
            // 
            this.lblResultadoIMC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResultadoIMC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoIMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResultadoIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultadoIMC.Location = new System.Drawing.Point(262, 88);
            this.lblResultadoIMC.Name = "lblResultadoIMC";
            this.lblResultadoIMC.Size = new System.Drawing.Size(165, 107);
            this.lblResultadoIMC.TabIndex = 15;
            this.lblResultadoIMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIMC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblIMC.Location = new System.Drawing.Point(259, 62);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(35, 17);
            this.lblIMC.TabIndex = 16;
            this.lblIMC.Text = "IMC:";
            // 
            // lblGrau
            // 
            this.lblGrau.AutoSize = true;
            this.lblGrau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGrau.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGrau.Location = new System.Drawing.Point(601, 62);
            this.lblGrau.Name = "lblGrau";
            this.lblGrau.Size = new System.Drawing.Size(52, 17);
            this.lblGrau.TabIndex = 18;
            this.lblGrau.Text = "GRAU:";
            // 
            // lblResultadoGrau
            // 
            this.lblResultadoGrau.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResultadoGrau.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoGrau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResultadoGrau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultadoGrau.Location = new System.Drawing.Point(604, 87);
            this.lblResultadoGrau.Name = "lblResultadoGrau";
            this.lblResultadoGrau.Size = new System.Drawing.Size(165, 107);
            this.lblResultadoGrau.TabIndex = 17;
            this.lblResultadoGrau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblClassificacao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblClassificacao.Location = new System.Drawing.Point(442, 61);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(113, 17);
            this.lblClassificacao.TabIndex = 20;
            this.lblClassificacao.Text = "CLASSIFICAÇÃO";
            // 
            // lblResultadoClass
            // 
            this.lblResultadoClass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResultadoClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResultadoClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultadoClass.Location = new System.Drawing.Point(433, 87);
            this.lblResultadoClass.Name = "lblResultadoClass";
            this.lblResultadoClass.Size = new System.Drawing.Size(165, 107);
            this.lblResultadoClass.TabIndex = 19;
            this.lblResultadoClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculoIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 485);
            this.Controls.Add(this.lblClassificacao);
            this.Controls.Add(this.lblResultadoClass);
            this.Controls.Add(this.lblGrau);
            this.Controls.Add(this.lblResultadoGrau);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.lblResultadoIMC);
            this.Controls.Add(this.lblCalculadora);
            this.Controls.Add(this.gpbIMC);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtPeso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculoIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculoIMC";
            this.Load += new System.EventHandler(this.CalculoIMC_Load);
            this.gpbIMC.ResumeLayout(false);
            this.gpbIMC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIMC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gpbIMC;
        private System.Windows.Forms.PictureBox ptbIMC;
        private System.Windows.Forms.Label lblCalculadora;
        private System.Windows.Forms.Label lblResultadoIMC;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblGrau;
        private System.Windows.Forms.Label lblResultadoGrau;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.Label lblResultadoClass;
    }
}

