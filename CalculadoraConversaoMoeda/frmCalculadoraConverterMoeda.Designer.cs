
namespace CalculadoraConversaoMoeda
{
    partial class frmCalculadoraConverterMoeda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadoraConverterMoeda));
            this.gpbMoeda = new System.Windows.Forms.GroupBox();
            this.rdbIene = new System.Windows.Forms.RadioButton();
            this.rdbPeso = new System.Windows.Forms.RadioButton();
            this.rdbEuro = new System.Windows.Forms.RadioButton();
            this.rdbLibra = new System.Windows.Forms.RadioButton();
            this.rdbDolar = new System.Windows.Forms.RadioButton();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.gpbConversor = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtMoeda = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbMoeda.SuspendLayout();
            this.gpbConversor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbMoeda
            // 
            this.gpbMoeda.Controls.Add(this.rdbIene);
            this.gpbMoeda.Controls.Add(this.rdbPeso);
            this.gpbMoeda.Controls.Add(this.rdbEuro);
            this.gpbMoeda.Controls.Add(this.rdbLibra);
            this.gpbMoeda.Controls.Add(this.rdbDolar);
            this.gpbMoeda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpbMoeda.Location = new System.Drawing.Point(39, 136);
            this.gpbMoeda.Name = "gpbMoeda";
            this.gpbMoeda.Size = new System.Drawing.Size(78, 180);
            this.gpbMoeda.TabIndex = 0;
            this.gpbMoeda.TabStop = false;
            this.gpbMoeda.Text = "Moeda";
            // 
            // rdbIene
            // 
            this.rdbIene.AutoSize = true;
            this.rdbIene.Location = new System.Drawing.Point(6, 145);
            this.rdbIene.Name = "rdbIene";
            this.rdbIene.Size = new System.Drawing.Size(59, 24);
            this.rdbIene.TabIndex = 6;
            this.rdbIene.TabStop = true;
            this.rdbIene.Text = "Iene";
            this.rdbIene.UseVisualStyleBackColor = true;
            // 
            // rdbPeso
            // 
            this.rdbPeso.AutoSize = true;
            this.rdbPeso.Location = new System.Drawing.Point(6, 115);
            this.rdbPeso.Name = "rdbPeso";
            this.rdbPeso.Size = new System.Drawing.Size(63, 24);
            this.rdbPeso.TabIndex = 5;
            this.rdbPeso.TabStop = true;
            this.rdbPeso.Text = "Peso";
            this.rdbPeso.UseVisualStyleBackColor = true;
            // 
            // rdbEuro
            // 
            this.rdbEuro.AutoSize = true;
            this.rdbEuro.Location = new System.Drawing.Point(6, 55);
            this.rdbEuro.Name = "rdbEuro";
            this.rdbEuro.Size = new System.Drawing.Size(61, 24);
            this.rdbEuro.TabIndex = 4;
            this.rdbEuro.TabStop = true;
            this.rdbEuro.Text = "Euro";
            this.rdbEuro.UseVisualStyleBackColor = true;
            // 
            // rdbLibra
            // 
            this.rdbLibra.AutoSize = true;
            this.rdbLibra.Location = new System.Drawing.Point(6, 85);
            this.rdbLibra.Name = "rdbLibra";
            this.rdbLibra.Size = new System.Drawing.Size(62, 24);
            this.rdbLibra.TabIndex = 3;
            this.rdbLibra.TabStop = true;
            this.rdbLibra.Text = "Libra";
            this.rdbLibra.UseVisualStyleBackColor = true;
            // 
            // rdbDolar
            // 
            this.rdbDolar.AutoSize = true;
            this.rdbDolar.Location = new System.Drawing.Point(6, 25);
            this.rdbDolar.Name = "rdbDolar";
            this.rdbDolar.Size = new System.Drawing.Size(65, 24);
            this.rdbDolar.TabIndex = 2;
            this.rdbDolar.TabStop = true;
            this.rdbDolar.Text = "Dólar";
            this.rdbDolar.UseVisualStyleBackColor = true;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblValor.Location = new System.Drawing.Point(21, 68);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(50, 20);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(25, 91);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(111, 30);
            this.txtValor.TabIndex = 1;
            // 
            // gpbConversor
            // 
            this.gpbConversor.Controls.Add(this.btnLimpar);
            this.gpbConversor.Controls.Add(this.btnCalcular);
            this.gpbConversor.Controls.Add(this.txtMoeda);
            this.gpbConversor.Controls.Add(this.lblResultado);
            this.gpbConversor.Controls.Add(this.lblMoeda);
            this.gpbConversor.Controls.Add(this.txtResultado);
            this.gpbConversor.Controls.Add(this.gpbMoeda);
            this.gpbConversor.Controls.Add(this.txtValor);
            this.gpbConversor.Controls.Add(this.lblValor);
            this.gpbConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gpbConversor.Location = new System.Drawing.Point(212, 85);
            this.gpbConversor.Name = "gpbConversor";
            this.gpbConversor.Size = new System.Drawing.Size(361, 365);
            this.gpbConversor.TabIndex = 2;
            this.gpbConversor.TabStop = false;
            this.gpbConversor.Text = "Conversor de Moeda";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpar.Location = new System.Drawing.Point(194, 207);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 38);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalcular.Location = new System.Drawing.Point(194, 154);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(82, 38);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtMoeda
            // 
            this.txtMoeda.Location = new System.Drawing.Point(194, 91);
            this.txtMoeda.Name = "txtMoeda";
            this.txtMoeda.Size = new System.Drawing.Size(111, 30);
            this.txtMoeda.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResultado.Location = new System.Drawing.Point(190, 263);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(86, 20);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMoeda.Location = new System.Drawing.Point(190, 68);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(62, 20);
            this.lblMoeda.TabIndex = 5;
            this.lblMoeda.Text = "Moeda:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(194, 286);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(111, 30);
            this.txtResultado.TabIndex = 4;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSair.Location = new System.Drawing.Point(660, 500);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 49);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCalculadoraConverterMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gpbConversor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculadoraConverterMoeda";
            this.Text = "Conversor de moeda";
            this.Load += new System.EventHandler(this.frmCalculadoraConverterMoeda_Load);
            this.gpbMoeda.ResumeLayout(false);
            this.gpbMoeda.PerformLayout();
            this.gpbConversor.ResumeLayout(false);
            this.gpbConversor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbMoeda;
        private System.Windows.Forms.RadioButton rdbIene;
        private System.Windows.Forms.RadioButton rdbPeso;
        private System.Windows.Forms.RadioButton rdbEuro;
        private System.Windows.Forms.RadioButton rdbLibra;
        private System.Windows.Forms.RadioButton rdbDolar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.GroupBox gpbConversor;
        private System.Windows.Forms.Label lblMoeda;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtMoeda;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSair;
    }
}

