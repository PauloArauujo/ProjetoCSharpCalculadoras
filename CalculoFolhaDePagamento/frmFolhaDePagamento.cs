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


namespace CalculoFolhaDePagamento
{
    public partial class frmFolhaPagamento : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmFolhaPagamento()
        {
            InitializeComponent();
        }

        private void frmFolhaPagamento_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void LimparCampos()
        {
            txtSalarioBruto.Clear();
            txtINSSResultado.Clear();
            txtIRResultado.Clear();
            txtSalarioBrutoResultado.Clear();
            txtSalariolLiquidoResultado.Clear();
            rdb10d.Checked = false;
            rdb20d.Checked = false;
            rdb30d.Checked = false;
            rdb10.Checked = false;
            rdb20.Checked = false;
            rdb30.Checked = false;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtSalarioBruto.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {


                double salario, liquido, inss, ir, cooperativa = 0;

                salario = Convert.ToDouble(txtSalarioBruto.Text);

                cooperativa = salario;
                inss = salario;
                ir = salario;

                if (rdb10d.Checked.Equals(false) && rdb20d.Checked.Equals(false) && rdb30d.Checked.Equals(false))
                {
                    MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    rdb10.Focus();
                }

                if (rdb10d.Checked)
                {
                    cooperativa = salario * 0.10;
                    rdb10.Checked = true;
                }
                if (rdb20d.Checked)
                {
                    cooperativa = salario * 0.20;
                    rdb20.Checked = true;

                }
                if (rdb30d.Checked)
                {
                    cooperativa = salario * 0.30;
                    rdb30.Checked = true;
                }
                if (salario <= 2.112)
                {
                    ir = 0;
                }
                if (salario >= 2112.01 && salario <= 2826.65)
                {
                    ir = 158.40;
                }
                if (salario >= 2826.66 && salario <= 3751.05)
                {
                    ir = 158.40;
                }
                if (salario >= 3751.06 && salario <= 4663.68)
                {
                    ir = 651.73;
                }
                if (salario > 4663.68)
                {
                    ir = 884.96;
                }
                if (salario <= 1412)
                {
                    inss = 0;
                }
                if (salario >= 1412.01 && salario <= 2666.68)
                {
                    inss = 21.18;
                }
                if (salario >= 2666.69 && salario <= 4000.03)
                {
                    inss = 101.18;
                }
                if (salario >= 4000.04 && salario <= 7786.02)
                {
                    inss = 181.18;
                }

                liquido = salario - cooperativa - inss - ir;

                txtINSSResultado.Text = string.Format("{0}", inss);
                txtIRResultado.Text = string.Format("{0}", ir);
                txtSalarioBrutoResultado.Text = string.Format("{0}", salario);
                txtSalariolLiquidoResultado.Text = string.Format("{0}", liquido);
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtSalarioBruto.Focus();
            }
        }
    }
}
