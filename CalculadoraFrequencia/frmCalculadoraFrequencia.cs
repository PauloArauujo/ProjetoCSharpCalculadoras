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

namespace CalculadoraFrequencia
{
    public partial class frmCalculadoraFrequencia : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmCalculadoraFrequencia()
        {
            InitializeComponent();
        }

        private void frmCalculadoraFrequencia_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
        public void LimparCampos()
        {
            txtHorasTrabalhadas.Clear();
            txtTaxa.Clear();
            txtNumeroAcidentes.Clear();
            txtNumeroFuncionarios.Clear();
            txtParametros.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double numAcidentes, numFuncionarios, numHoras, htt, taxa = 0;
                string parametro = "";

                numAcidentes = Convert.ToDouble(txtNumeroAcidentes.Text);
                numFuncionarios = Convert.ToDouble(txtNumeroFuncionarios.Text);
                numHoras = Convert.ToDouble(txtHorasTrabalhadas.Text);

                htt = numFuncionarios * numHoras;
                taxa = (numAcidentes * 1000000) / htt;

                if (txtNumeroAcidentes.Text.Equals("") || txtHorasTrabalhadas.Text.Equals("") || txtNumeroFuncionarios.Text.Equals(""))
                { 
                    MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtNumeroAcidentes.Focus();
                }
                if (taxa <= 20)
                {
                    parametro = "Muito Bom";
                }
                if (taxa >= 20.01 && taxa <= 40)
                {
                    parametro = "Bom";
                }
                if (taxa >= 40.01 && taxa <= 60)
                {
                    parametro = "Ruim";
                }
                if (taxa > 60)
                {
                    parametro = "Péssima";
                }
                txtParametros.Text = string.Format("{0}", parametro);
                txtTaxa.Text = string.Format("{0:n1}", taxa);

    

            }
            catch (Exception)
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtNumeroAcidentes.Focus();
            }
        }
    }
}
