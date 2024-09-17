
namespace CalculadoraFrequencia
{
    partial class frmCalculadoraFrequencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadoraFrequencia));
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.txtNumeroAcidentes = new System.Windows.Forms.TextBox();
            this.lblNumeroAcidentes = new System.Windows.Forms.Label();
            this.lblNumeroFuncionarios = new System.Windows.Forms.Label();
            this.txtNumeroFuncionarios = new System.Windows.Forms.TextBox();
            this.lblHorasTrabalhadas = new System.Windows.Forms.Label();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.txtParametros = new System.Windows.Forms.TextBox();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.lblHTT = new System.Windows.Forms.Label();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.grpDados.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.btnLimpar);
            this.grpDados.Controls.Add(this.btnCalcular);
            this.grpDados.Controls.Add(this.txtHorasTrabalhadas);
            this.grpDados.Controls.Add(this.lblHorasTrabalhadas);
            this.grpDados.Controls.Add(this.txtNumeroFuncionarios);
            this.grpDados.Controls.Add(this.lblNumeroFuncionarios);
            this.grpDados.Controls.Add(this.lblNumeroAcidentes);
            this.grpDados.Controls.Add(this.txtNumeroAcidentes);
            this.grpDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpDados.Location = new System.Drawing.Point(140, 42);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(495, 240);
            this.grpDados.TabIndex = 0;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados:";
            // 
            // txtNumeroAcidentes
            // 
            this.txtNumeroAcidentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNumeroAcidentes.Location = new System.Drawing.Point(15, 56);
            this.txtNumeroAcidentes.Name = "txtNumeroAcidentes";
            this.txtNumeroAcidentes.Size = new System.Drawing.Size(291, 30);
            this.txtNumeroAcidentes.TabIndex = 1;
            // 
            // lblNumeroAcidentes
            // 
            this.lblNumeroAcidentes.AutoSize = true;
            this.lblNumeroAcidentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumeroAcidentes.Location = new System.Drawing.Point(11, 33);
            this.lblNumeroAcidentes.Name = "lblNumeroAcidentes";
            this.lblNumeroAcidentes.Size = new System.Drawing.Size(147, 17);
            this.lblNumeroAcidentes.TabIndex = 1;
            this.lblNumeroAcidentes.Text = "Número de acidentes:";
            // 
            // lblNumeroFuncionarios
            // 
            this.lblNumeroFuncionarios.AutoSize = true;
            this.lblNumeroFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumeroFuncionarios.Location = new System.Drawing.Point(12, 100);
            this.lblNumeroFuncionarios.Name = "lblNumeroFuncionarios";
            this.lblNumeroFuncionarios.Size = new System.Drawing.Size(163, 17);
            this.lblNumeroFuncionarios.TabIndex = 2;
            this.lblNumeroFuncionarios.Text = "Número de funcionarios:";
            // 
            // txtNumeroFuncionarios
            // 
            this.txtNumeroFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNumeroFuncionarios.Location = new System.Drawing.Point(15, 120);
            this.txtNumeroFuncionarios.Name = "txtNumeroFuncionarios";
            this.txtNumeroFuncionarios.Size = new System.Drawing.Size(291, 30);
            this.txtNumeroFuncionarios.TabIndex = 2;
            // 
            // lblHorasTrabalhadas
            // 
            this.lblHorasTrabalhadas.AutoSize = true;
            this.lblHorasTrabalhadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHorasTrabalhadas.Location = new System.Drawing.Point(12, 167);
            this.lblHorasTrabalhadas.Name = "lblHorasTrabalhadas";
            this.lblHorasTrabalhadas.Size = new System.Drawing.Size(199, 17);
            this.lblHorasTrabalhadas.TabIndex = 4;
            this.lblHorasTrabalhadas.Text = "Horas individuais trabalhadas:";
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(14, 187);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(292, 30);
            this.txtHorasTrabalhadas.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalcular.Location = new System.Drawing.Point(359, 83);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(106, 48);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpar.Location = new System.Drawing.Point(359, 150);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 48);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSair.Location = new System.Drawing.Point(356, 59);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 48);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtTaxa
            // 
            this.txtTaxa.Enabled = false;
            this.txtTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtTaxa.Location = new System.Drawing.Point(23, 59);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(249, 30);
            this.txtTaxa.TabIndex = 2;
            // 
            // txtParametros
            // 
            this.txtParametros.Enabled = false;
            this.txtParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtParametros.Location = new System.Drawing.Point(23, 112);
            this.txtParametros.Name = "txtParametros";
            this.txtParametros.Size = new System.Drawing.Size(249, 30);
            this.txtParametros.TabIndex = 3;
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.lblTaxa);
            this.gpbResultado.Controls.Add(this.lblHTT);
            this.gpbResultado.Controls.Add(this.btnSair);
            this.gpbResultado.Controls.Add(this.txtTaxa);
            this.gpbResultado.Controls.Add(this.txtParametros);
            this.gpbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpbResultado.Location = new System.Drawing.Point(143, 306);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(491, 172);
            this.gpbResultado.TabIndex = 4;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado:";
            // 
            // lblHTT
            // 
            this.lblHTT.AutoSize = true;
            this.lblHTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHTT.Location = new System.Drawing.Point(20, 39);
            this.lblHTT.Name = "lblHTT";
            this.lblHTT.Size = new System.Drawing.Size(134, 17);
            this.lblHTT.TabIndex = 8;
            this.lblHTT.Text = "Taxa de frequência:";
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTaxa.Location = new System.Drawing.Point(20, 92);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(226, 17);
            this.lblTaxa.TabIndex = 9;
            this.lblTaxa.Text = "Parâmetros da taxa de frequência:";
            // 
            // frmCalculadoraFrequencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.grpDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalculadoraFrequencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frequência";
            this.Load += new System.EventHandler(this.frmCalculadoraFrequencia_Load);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            this.gpbResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.Label lblHorasTrabalhadas;
        private System.Windows.Forms.TextBox txtNumeroFuncionarios;
        private System.Windows.Forms.Label lblNumeroFuncionarios;
        private System.Windows.Forms.Label lblNumeroAcidentes;
        private System.Windows.Forms.TextBox txtNumeroAcidentes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.TextBox txtParametros;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.Label lblHTT;
    }
}

