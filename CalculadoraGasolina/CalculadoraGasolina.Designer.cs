
namespace CalculadoraGasolina
{
    partial class CalculadoraGasolina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraGasolina));
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpbCalcule = new System.Windows.Forms.GroupBox();
            this.lblResultadoKm = new System.Windows.Forms.Label();
            this.lblResultadoConsumo = new System.Windows.Forms.Label();
            this.lblResultadoPreco = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtLitro = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblDistanciaKm = new System.Windows.Forms.Label();
            this.lblConsumoLitro = new System.Windows.Forms.Label();
            this.lblPrecoCombustivel = new System.Windows.Forms.Label();
            this.gpbCalcule.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCombustivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCombustivel.Location = new System.Drawing.Point(12, 9);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(218, 25);
            this.lblCombustivel.TabIndex = 0;
            this.lblCombustivel.Text = "Cálculo do Combustível";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(622, 479);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 70);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "&SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 479);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 70);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "&CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(335, 479);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 70);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "&LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gpbCalcule
            // 
            this.gpbCalcule.Controls.Add(this.lblPrecoCombustivel);
            this.gpbCalcule.Controls.Add(this.lblConsumoLitro);
            this.gpbCalcule.Controls.Add(this.lblDistanciaKm);
            this.gpbCalcule.Controls.Add(this.txtPreco);
            this.gpbCalcule.Controls.Add(this.txtLitro);
            this.gpbCalcule.Controls.Add(this.txtKm);
            this.gpbCalcule.Location = new System.Drawing.Point(18, 46);
            this.gpbCalcule.Name = "gpbCalcule";
            this.gpbCalcule.Size = new System.Drawing.Size(585, 405);
            this.gpbCalcule.TabIndex = 4;
            this.gpbCalcule.TabStop = false;
            this.gpbCalcule.Text = "Calcule";
            // 
            // lblResultadoKm
            // 
            this.lblResultadoKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoKm.Location = new System.Drawing.Point(622, 90);
            this.lblResultadoKm.Name = "lblResultadoKm";
            this.lblResultadoKm.Size = new System.Drawing.Size(150, 68);
            this.lblResultadoKm.TabIndex = 5;
            this.lblResultadoKm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultadoConsumo
            // 
            this.lblResultadoConsumo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoConsumo.Location = new System.Drawing.Point(622, 194);
            this.lblResultadoConsumo.Name = "lblResultadoConsumo";
            this.lblResultadoConsumo.Size = new System.Drawing.Size(150, 68);
            this.lblResultadoConsumo.TabIndex = 6;
            this.lblResultadoConsumo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultadoPreco
            // 
            this.lblResultadoPreco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoPreco.Location = new System.Drawing.Point(622, 309);
            this.lblResultadoPreco.Name = "lblResultadoPreco";
            this.lblResultadoPreco.Size = new System.Drawing.Size(150, 68);
            this.lblResultadoPreco.TabIndex = 7;
            this.lblResultadoPreco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResultado.Location = new System.Drawing.Point(659, 32);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblConsumo.Location = new System.Drawing.Point(619, 177);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(67, 17);
            this.lblConsumo.TabIndex = 9;
            this.lblConsumo.Text = "Consumo";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKm.Location = new System.Drawing.Point(619, 73);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(28, 17);
            this.lblKm.TabIndex = 10;
            this.lblKm.Text = "Km";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPreco.Location = new System.Drawing.Point(619, 292);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(45, 17);
            this.lblPreco.TabIndex = 11;
            this.lblPreco.Text = "Preço";
            // 
            // txtKm
            // 
            this.txtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtKm.Location = new System.Drawing.Point(20, 63);
            this.txtKm.MaxLength = 10;
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(331, 23);
            this.txtKm.TabIndex = 1;
            this.txtKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKm_KeyPress);
            // 
            // txtLitro
            // 
            this.txtLitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLitro.Location = new System.Drawing.Point(20, 182);
            this.txtLitro.MaxLength = 10;
            this.txtLitro.Name = "txtLitro";
            this.txtLitro.Size = new System.Drawing.Size(331, 23);
            this.txtLitro.TabIndex = 2;
            this.txtLitro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLitro_KeyPress);
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPreco.Location = new System.Drawing.Point(20, 297);
            this.txtPreco.MaxLength = 10;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(331, 23);
            this.txtPreco.TabIndex = 3;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // lblDistanciaKm
            // 
            this.lblDistanciaKm.AutoSize = true;
            this.lblDistanciaKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDistanciaKm.Location = new System.Drawing.Point(16, 40);
            this.lblDistanciaKm.Name = "lblDistanciaKm";
            this.lblDistanciaKm.Size = new System.Drawing.Size(336, 20);
            this.lblDistanciaKm.TabIndex = 5;
            this.lblDistanciaKm.Text = "Insira a distância que irá ser percorrida em km:";
            // 
            // lblConsumoLitro
            // 
            this.lblConsumoLitro.AutoSize = true;
            this.lblConsumoLitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblConsumoLitro.Location = new System.Drawing.Point(16, 159);
            this.lblConsumoLitro.Name = "lblConsumoLitro";
            this.lblConsumoLitro.Size = new System.Drawing.Size(264, 20);
            this.lblConsumoLitro.TabIndex = 6;
            this.lblConsumoLitro.Text = "Insira o consumo do veículo por litro:";
            // 
            // lblPrecoCombustivel
            // 
            this.lblPrecoCombustivel.AutoSize = true;
            this.lblPrecoCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrecoCombustivel.Location = new System.Drawing.Point(16, 274);
            this.lblPrecoCombustivel.Name = "lblPrecoCombustivel";
            this.lblPrecoCombustivel.Size = new System.Drawing.Size(222, 20);
            this.lblPrecoCombustivel.TabIndex = 7;
            this.lblPrecoCombustivel.Text = "Insira o preço do combustivel: ";
            // 
            // CalculadoraGasolina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblResultadoPreco);
            this.Controls.Add(this.lblResultadoConsumo);
            this.Controls.Add(this.lblResultadoKm);
            this.Controls.Add(this.gpbCalcule);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblCombustivel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculadoraGasolina";
            this.Text = "CalculadoraCombustível";
            this.Load += new System.EventHandler(this.CalculadoraGasolina_Load);
            this.gpbCalcule.ResumeLayout(false);
            this.gpbCalcule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gpbCalcule;
        private System.Windows.Forms.Label lblResultadoKm;
        private System.Windows.Forms.Label lblResultadoConsumo;
        private System.Windows.Forms.Label lblResultadoPreco;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblPrecoCombustivel;
        private System.Windows.Forms.Label lblConsumoLitro;
        private System.Windows.Forms.Label lblDistanciaKm;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtLitro;
        private System.Windows.Forms.TextBox txtKm;
    }
}

