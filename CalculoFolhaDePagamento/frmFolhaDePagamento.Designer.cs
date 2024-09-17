
namespace CalculoFolhaDePagamento
{
    partial class frmFolhaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaPagamento));
            this.lblFolhaPagamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.rdb20d = new System.Windows.Forms.RadioButton();
            this.rdb10d = new System.Windows.Forms.RadioButton();
            this.rdb30d = new System.Windows.Forms.RadioButton();
            this.lblCooperativa = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtSalarioBrutoResultado = new System.Windows.Forms.TextBox();
            this.txtINSSResultado = new System.Windows.Forms.TextBox();
            this.lblSalarioBrutoResultado = new System.Windows.Forms.Label();
            this.lblINSSResultado = new System.Windows.Forms.Label();
            this.lblIRResultado = new System.Windows.Forms.Label();
            this.txtIRResultado = new System.Windows.Forms.TextBox();
            this.txtSalariolLiquidoResultado = new System.Windows.Forms.TextBox();
            this.lblSalarioLiquidoResultado = new System.Windows.Forms.Label();
            this.lblCooperativaResultado = new System.Windows.Forms.Label();
            this.rdb30 = new System.Windows.Forms.RadioButton();
            this.rdb10 = new System.Windows.Forms.RadioButton();
            this.rdb20 = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFolhaPagamento
            // 
            this.lblFolhaPagamento.AutoSize = true;
            this.lblFolhaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFolhaPagamento.ForeColor = System.Drawing.Color.Green;
            this.lblFolhaPagamento.Location = new System.Drawing.Point(303, 46);
            this.lblFolhaPagamento.Name = "lblFolhaPagamento";
            this.lblFolhaPagamento.Size = new System.Drawing.Size(193, 25);
            this.lblFolhaPagamento.TabIndex = 0;
            this.lblFolhaPagamento.Text = "Folha de Pagamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salário Bruto:";
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.rdb20d);
            this.gpbDados.Controls.Add(this.rdb10d);
            this.gpbDados.Controls.Add(this.rdb30d);
            this.gpbDados.Controls.Add(this.lblCooperativa);
            this.gpbDados.Controls.Add(this.btnCalcular);
            this.gpbDados.Controls.Add(this.txtSalarioBruto);
            this.gpbDados.Controls.Add(this.label1);
            this.gpbDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gpbDados.ForeColor = System.Drawing.Color.Green;
            this.gpbDados.Location = new System.Drawing.Point(36, 128);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(354, 265);
            this.gpbDados.TabIndex = 2;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados";
            // 
            // rdb20d
            // 
            this.rdb20d.AutoSize = true;
            this.rdb20d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdb20d.ForeColor = System.Drawing.Color.Green;
            this.rdb20d.Location = new System.Drawing.Point(17, 157);
            this.rdb20d.Name = "rdb20d";
            this.rdb20d.Size = new System.Drawing.Size(151, 24);
            this.rdb20d.TabIndex = 23;
            this.rdb20d.TabStop = true;
            this.rdb20d.Text = "20% de desconto";
            this.rdb20d.UseVisualStyleBackColor = true;
            // 
            // rdb10d
            // 
            this.rdb10d.AutoSize = true;
            this.rdb10d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdb10d.ForeColor = System.Drawing.Color.Green;
            this.rdb10d.Location = new System.Drawing.Point(17, 187);
            this.rdb10d.Name = "rdb10d";
            this.rdb10d.Size = new System.Drawing.Size(151, 24);
            this.rdb10d.TabIndex = 22;
            this.rdb10d.TabStop = true;
            this.rdb10d.Text = "10% de desconto";
            this.rdb10d.UseVisualStyleBackColor = true;
            // 
            // rdb30d
            // 
            this.rdb30d.AutoSize = true;
            this.rdb30d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdb30d.ForeColor = System.Drawing.Color.Green;
            this.rdb30d.Location = new System.Drawing.Point(17, 127);
            this.rdb30d.Name = "rdb30d";
            this.rdb30d.Size = new System.Drawing.Size(151, 24);
            this.rdb30d.TabIndex = 20;
            this.rdb30d.TabStop = true;
            this.rdb30d.Text = "30% de desconto";
            this.rdb30d.UseVisualStyleBackColor = true;
            // 
            // lblCooperativa
            // 
            this.lblCooperativa.AutoSize = true;
            this.lblCooperativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCooperativa.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCooperativa.Location = new System.Drawing.Point(13, 96);
            this.lblCooperativa.Name = "lblCooperativa";
            this.lblCooperativa.Size = new System.Drawing.Size(98, 20);
            this.lblCooperativa.TabIndex = 21;
            this.lblCooperativa.Text = "Cooperativa:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCalcular.Location = new System.Drawing.Point(249, 213);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 38);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSalarioBruto.Location = new System.Drawing.Point(107, 47);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(172, 23);
            this.txtSalarioBruto.TabIndex = 2;
            // 
            // txtSalarioBrutoResultado
            // 
            this.txtSalarioBrutoResultado.Enabled = false;
            this.txtSalarioBrutoResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSalarioBrutoResultado.Location = new System.Drawing.Point(413, 174);
            this.txtSalarioBrutoResultado.Name = "txtSalarioBrutoResultado";
            this.txtSalarioBrutoResultado.Size = new System.Drawing.Size(172, 23);
            this.txtSalarioBrutoResultado.TabIndex = 7;
            // 
            // txtINSSResultado
            // 
            this.txtINSSResultado.Enabled = false;
            this.txtINSSResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtINSSResultado.Location = new System.Drawing.Point(413, 234);
            this.txtINSSResultado.Name = "txtINSSResultado";
            this.txtINSSResultado.Size = new System.Drawing.Size(172, 23);
            this.txtINSSResultado.TabIndex = 8;
            // 
            // lblSalarioBrutoResultado
            // 
            this.lblSalarioBrutoResultado.AutoSize = true;
            this.lblSalarioBrutoResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSalarioBrutoResultado.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSalarioBrutoResultado.Location = new System.Drawing.Point(409, 151);
            this.lblSalarioBrutoResultado.Name = "lblSalarioBrutoResultado";
            this.lblSalarioBrutoResultado.Size = new System.Drawing.Size(105, 20);
            this.lblSalarioBrutoResultado.TabIndex = 7;
            this.lblSalarioBrutoResultado.Text = "Salário Bruto:";
            // 
            // lblINSSResultado
            // 
            this.lblINSSResultado.AutoSize = true;
            this.lblINSSResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblINSSResultado.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblINSSResultado.Location = new System.Drawing.Point(409, 211);
            this.lblINSSResultado.Name = "lblINSSResultado";
            this.lblINSSResultado.Size = new System.Drawing.Size(51, 20);
            this.lblINSSResultado.TabIndex = 9;
            this.lblINSSResultado.Text = "INSS:";
            // 
            // lblIRResultado
            // 
            this.lblIRResultado.AutoSize = true;
            this.lblIRResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblIRResultado.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblIRResultado.Location = new System.Drawing.Point(409, 271);
            this.lblIRResultado.Name = "lblIRResultado";
            this.lblIRResultado.Size = new System.Drawing.Size(30, 20);
            this.lblIRResultado.TabIndex = 10;
            this.lblIRResultado.Text = "IR:";
            // 
            // txtIRResultado
            // 
            this.txtIRResultado.Enabled = false;
            this.txtIRResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIRResultado.Location = new System.Drawing.Point(413, 294);
            this.txtIRResultado.Name = "txtIRResultado";
            this.txtIRResultado.Size = new System.Drawing.Size(172, 23);
            this.txtIRResultado.TabIndex = 11;
            // 
            // txtSalariolLiquidoResultado
            // 
            this.txtSalariolLiquidoResultado.Enabled = false;
            this.txtSalariolLiquidoResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSalariolLiquidoResultado.Location = new System.Drawing.Point(413, 345);
            this.txtSalariolLiquidoResultado.Name = "txtSalariolLiquidoResultado";
            this.txtSalariolLiquidoResultado.Size = new System.Drawing.Size(172, 23);
            this.txtSalariolLiquidoResultado.TabIndex = 13;
            // 
            // lblSalarioLiquidoResultado
            // 
            this.lblSalarioLiquidoResultado.AutoSize = true;
            this.lblSalarioLiquidoResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSalarioLiquidoResultado.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSalarioLiquidoResultado.Location = new System.Drawing.Point(409, 322);
            this.lblSalarioLiquidoResultado.Name = "lblSalarioLiquidoResultado";
            this.lblSalarioLiquidoResultado.Size = new System.Drawing.Size(117, 20);
            this.lblSalarioLiquidoResultado.TabIndex = 12;
            this.lblSalarioLiquidoResultado.Text = "Salário Liquido:";
            // 
            // lblCooperativaResultado
            // 
            this.lblCooperativaResultado.AutoSize = true;
            this.lblCooperativaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCooperativaResultado.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCooperativaResultado.Location = new System.Drawing.Point(600, 208);
            this.lblCooperativaResultado.Name = "lblCooperativaResultado";
            this.lblCooperativaResultado.Size = new System.Drawing.Size(98, 20);
            this.lblCooperativaResultado.TabIndex = 7;
            this.lblCooperativaResultado.Text = "Cooperativa:";
            // 
            // rdb30
            // 
            this.rdb30.AutoSize = true;
            this.rdb30.Enabled = false;
            this.rdb30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdb30.ForeColor = System.Drawing.Color.Green;
            this.rdb30.Location = new System.Drawing.Point(604, 239);
            this.rdb30.Name = "rdb30";
            this.rdb30.Size = new System.Drawing.Size(151, 24);
            this.rdb30.TabIndex = 7;
            this.rdb30.TabStop = true;
            this.rdb30.Text = "30% de desconto";
            this.rdb30.UseVisualStyleBackColor = true;
            // 
            // rdb10
            // 
            this.rdb10.AutoSize = true;
            this.rdb10.Enabled = false;
            this.rdb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdb10.ForeColor = System.Drawing.Color.Green;
            this.rdb10.Location = new System.Drawing.Point(604, 299);
            this.rdb10.Name = "rdb10";
            this.rdb10.Size = new System.Drawing.Size(151, 24);
            this.rdb10.TabIndex = 14;
            this.rdb10.TabStop = true;
            this.rdb10.Text = "10% de desconto";
            this.rdb10.UseVisualStyleBackColor = true;
            // 
            // rdb20
            // 
            this.rdb20.AutoSize = true;
            this.rdb20.Enabled = false;
            this.rdb20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdb20.ForeColor = System.Drawing.Color.Green;
            this.rdb20.Location = new System.Drawing.Point(604, 269);
            this.rdb20.Name = "rdb20";
            this.rdb20.Size = new System.Drawing.Size(151, 24);
            this.rdb20.TabIndex = 15;
            this.rdb20.TabStop = true;
            this.rdb20.Text = "20% de desconto";
            this.rdb20.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLimpar.ForeColor = System.Drawing.Color.Green;
            this.btnLimpar.Location = new System.Drawing.Point(241, 478);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(134, 71);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSair.ForeColor = System.Drawing.Color.Green;
            this.btnSair.Location = new System.Drawing.Point(412, 478);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(134, 71);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.rdb20);
            this.Controls.Add(this.rdb10);
            this.Controls.Add(this.rdb30);
            this.Controls.Add(this.lblCooperativaResultado);
            this.Controls.Add(this.txtSalariolLiquidoResultado);
            this.Controls.Add(this.lblSalarioLiquidoResultado);
            this.Controls.Add(this.txtIRResultado);
            this.Controls.Add(this.lblIRResultado);
            this.Controls.Add(this.lblINSSResultado);
            this.Controls.Add(this.lblSalarioBrutoResultado);
            this.Controls.Add(this.txtSalarioBrutoResultado);
            this.Controls.Add(this.txtINSSResultado);
            this.Controls.Add(this.gpbDados);
            this.Controls.Add(this.lblFolhaPagamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFolhaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FolhaPagamento";
            this.Load += new System.EventHandler(this.frmFolhaPagamento_Load);
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFolhaPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalarioBrutoResultado;
        private System.Windows.Forms.TextBox txtINSSResultado;
        private System.Windows.Forms.Label lblSalarioBrutoResultado;
        private System.Windows.Forms.Label lblINSSResultado;
        private System.Windows.Forms.Label lblIRResultado;
        private System.Windows.Forms.TextBox txtIRResultado;
        private System.Windows.Forms.TextBox txtSalariolLiquidoResultado;
        private System.Windows.Forms.Label lblSalarioLiquidoResultado;
        private System.Windows.Forms.Label lblCooperativaResultado;
        private System.Windows.Forms.RadioButton rdb30;
        private System.Windows.Forms.RadioButton rdb10;
        private System.Windows.Forms.RadioButton rdb20;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.RadioButton rdb20d;
        private System.Windows.Forms.RadioButton rdb10d;
        private System.Windows.Forms.RadioButton rdb30d;
        private System.Windows.Forms.Label lblCooperativa;
    }
}

