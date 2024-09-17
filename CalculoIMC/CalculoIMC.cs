using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace CalculoIMC
{
    public partial class CalculoIMC : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public CalculoIMC()
        {
            InitializeComponent();
        }

        private void CalculoIMC_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double peso, altura, imc = 0;
                string classificacao = "";
                int grau = 0;


                peso = Convert.ToDouble(txtPeso.Text);
                altura = Convert.ToDouble(txtTamanho.Text);

                imc = peso / (altura * altura);

                if (imc <= 18.5)
                {
                    grau = 0;
                    classificacao = "Magreza";
                }
                if (imc >= 18.5 && imc <= 24.9)
                { 
                    grau = 0;
                    classificacao = "Normal";
                }
                if (imc >= 25 && imc <= 29.9)
                {
                    grau = 1;
                    classificacao = "Sobrepeso";
                }
                if (imc >= 30 && imc <= 39.9)
                {
                    grau = 2;
                    classificacao = "Obesidade";
                }
                if (imc >= 40)
                {
                    grau = 3;
                    classificacao = "Obesidade Grave";
                }

                lblResultadoIMC.Text = string.Format("{0:n1}", imc);
                lblResultadoGrau.Text = string.Format("{0:n1}", grau);
                lblResultadoClass.Text = string.Format(classificacao);
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtPeso.Focus();
            }           
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void LimparCampos()
        {
            txtPeso.Clear();
            txtTamanho.Clear();
            lblResultadoIMC.Text = ("");
            lblResultadoClass.Text = ("");
            lblResultadoGrau.Text = ("");
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtPeso.Focus();
        }
    }
}
