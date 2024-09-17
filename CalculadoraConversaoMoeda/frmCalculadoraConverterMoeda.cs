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


namespace CalculadoraConversaoMoeda
{
    public partial class frmCalculadoraConverterMoeda : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmCalculadoraConverterMoeda()
        {
            InitializeComponent();
        }
        private void frmCalculadoraConverterMoeda_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
        public void LimparCampos()
        {
            txtMoeda.Clear();
            txtResultado.Clear();
            txtValor.Clear();
            rdbDolar.Checked = (false);
            rdbEuro.Checked = (false);
            rdbIene.Checked = (false);
            rdbLibra.Checked = (false);
            rdbPeso.Checked = (false);
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
            double valor, resultado = 0;

            try
            {
                valor = Convert.ToDouble(txtValor);

                if (txtValor.Text.Equals(""))
                {
                    MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtValor.Focus();
                }
                if (rdbDolar.Checked.Equals(false) && rdbEuro.Checked.Equals(false) && rdbLibra.Checked.Equals(false) && rdbIene.Checked.Equals(false) && rdbPeso.Checked.Equals(false))
                {
                    MessageBox.Show("Selecione uma moeda", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                if (rdbDolar.Checked)
                {
                    resultado = valor * 5.50;
                }
                if (rdbEuro.Checked)
                {
                    resultado = valor * 6.12;
                }
                if (rdbIene.Checked)
                {
                    resultado = valor * 0.39;
                }
                if (rdbLibra.Checked)
                {
                    resultado = valor * 7.26;
                }
                if (rdbPeso.Checked)
                {
                    resultado = valor * 0.57;
                }
                txtResultado.Text = resultado.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);MessageBox.Show("Test");
                txtValor.Focus();
            }


        }
        }
    }
