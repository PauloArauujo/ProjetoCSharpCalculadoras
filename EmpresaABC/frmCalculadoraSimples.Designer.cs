
namespace EmpresaABC
{
    partial class frmCalculadoraSimples
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadoraSimples));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblVariavel1 = new System.Windows.Forms.Label();
            this.lblVariavel2 = new System.Windows.Forms.Label();
            this.gpbOperador = new System.Windows.Forms.GroupBox();
            this.rdbDivisao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdbSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbAdicao = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtVariavel1 = new System.Windows.Forms.TextBox();
            this.txtVariavel2 = new System.Windows.Forms.TextBox();
            this.gpbOperador.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcular.Location = new System.Drawing.Point(594, 227);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(147, 76);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(594, 309);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(147, 76);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSair.BackColor = System.Drawing.Color.DarkRed;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(594, 391);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(147, 76);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResposta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblResposta.Location = new System.Drawing.Point(582, 108);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(172, 90);
            this.lblResposta.TabIndex = 5;
            this.lblResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResposta.Click += new System.EventHandler(this.lblResposta_Click);
            // 
            // lblVariavel1
            // 
            this.lblVariavel1.AutoSize = true;
            this.lblVariavel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblVariavel1.Location = new System.Drawing.Point(30, 79);
            this.lblVariavel1.Name = "lblVariavel1";
            this.lblVariavel1.Size = new System.Drawing.Size(99, 25);
            this.lblVariavel1.TabIndex = 6;
            this.lblVariavel1.Text = "Variável 1";
            // 
            // lblVariavel2
            // 
            this.lblVariavel2.AutoSize = true;
            this.lblVariavel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblVariavel2.Location = new System.Drawing.Point(30, 152);
            this.lblVariavel2.Name = "lblVariavel2";
            this.lblVariavel2.Size = new System.Drawing.Size(99, 25);
            this.lblVariavel2.TabIndex = 7;
            this.lblVariavel2.Text = "Variável 2";
            // 
            // gpbOperador
            // 
            this.gpbOperador.Controls.Add(this.rdbDivisao);
            this.gpbOperador.Controls.Add(this.rdbMultiplicacao);
            this.gpbOperador.Controls.Add(this.rdbSubtracao);
            this.gpbOperador.Controls.Add(this.rdbAdicao);
            this.gpbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpbOperador.Location = new System.Drawing.Point(312, 133);
            this.gpbOperador.Name = "gpbOperador";
            this.gpbOperador.Size = new System.Drawing.Size(215, 252);
            this.gpbOperador.TabIndex = 8;
            this.gpbOperador.TabStop = false;
            this.gpbOperador.Text = "Operador";
            // 
            // rdbDivisao
            // 
            this.rdbDivisao.AutoSize = true;
            this.rdbDivisao.Location = new System.Drawing.Point(15, 202);
            this.rdbDivisao.Name = "rdbDivisao";
            this.rdbDivisao.Size = new System.Drawing.Size(92, 24);
            this.rdbDivisao.TabIndex = 5;
            this.rdbDivisao.TabStop = true;
            this.rdbDivisao.Text = "Divisão(/)";
            this.rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            this.rdbMultiplicacao.AutoSize = true;
            this.rdbMultiplicacao.Location = new System.Drawing.Point(15, 146);
            this.rdbMultiplicacao.Name = "rdbMultiplicacao";
            this.rdbMultiplicacao.Size = new System.Drawing.Size(134, 24);
            this.rdbMultiplicacao.TabIndex = 4;
            this.rdbMultiplicacao.TabStop = true;
            this.rdbMultiplicacao.Text = "Multiplicação(*)";
            this.rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            this.rdbSubtracao.AutoSize = true;
            this.rdbSubtracao.Location = new System.Drawing.Point(15, 94);
            this.rdbSubtracao.Name = "rdbSubtracao";
            this.rdbSubtracao.Size = new System.Drawing.Size(116, 24);
            this.rdbSubtracao.TabIndex = 3;
            this.rdbSubtracao.TabStop = true;
            this.rdbSubtracao.Text = "Subtração(-)";
            this.rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbAdicao
            // 
            this.rdbAdicao.AutoSize = true;
            this.rdbAdicao.Location = new System.Drawing.Point(15, 41);
            this.rdbAdicao.Name = "rdbAdicao";
            this.rdbAdicao.Size = new System.Drawing.Size(95, 24);
            this.rdbAdicao.TabIndex = 2;
            this.rdbAdicao.TabStop = true;
            this.rdbAdicao.Text = "Adição(+)";
            this.rdbAdicao.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResultado.Location = new System.Drawing.Point(578, 79);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado";
            // 
            // txtVariavel1
            // 
            this.txtVariavel1.Location = new System.Drawing.Point(135, 85);
            this.txtVariavel1.MaxLength = 5;
            this.txtVariavel1.Name = "txtVariavel1";
            this.txtVariavel1.Size = new System.Drawing.Size(137, 20);
            this.txtVariavel1.TabIndex = 0;
            this.txtVariavel1.Text = "4";
            // 
            // txtVariavel2
            // 
            this.txtVariavel2.Location = new System.Drawing.Point(135, 157);
            this.txtVariavel2.MaxLength = 5;
            this.txtVariavel2.Name = "txtVariavel2";
            this.txtVariavel2.Size = new System.Drawing.Size(137, 20);
            this.txtVariavel2.TabIndex = 1;
            this.txtVariavel2.TextChanged += new System.EventHandler(this.txtVariavel2_TextChanged);
            // 
            // frmCalculadoraSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtVariavel2);
            this.Controls.Add(this.txtVariavel1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.gpbOperador);
            this.Controls.Add(this.lblVariavel2);
            this.Controls.Add(this.lblVariavel1);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalculadoraSimples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Simples";
            this.Load += new System.EventHandler(this.frmCalculadoraSimples_Load);
            this.gpbOperador.ResumeLayout(false);
            this.gpbOperador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label lblVariavel1;
        private System.Windows.Forms.Label lblVariavel2;
        private System.Windows.Forms.GroupBox gpbOperador;
        private System.Windows.Forms.RadioButton rdbDivisao;
        private System.Windows.Forms.RadioButton rdbMultiplicacao;
        private System.Windows.Forms.RadioButton rdbSubtracao;
        private System.Windows.Forms.RadioButton rdbAdicao;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtVariavel1;
        private System.Windows.Forms.TextBox txtVariavel2;
    }
}

