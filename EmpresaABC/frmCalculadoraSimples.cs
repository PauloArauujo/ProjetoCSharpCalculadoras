using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EmpresaABC
{
    public partial class frmCalculadoraSimples : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmCalculadoraSimples()
        {
            InitializeComponent();
            this.Hide();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void LimparCampos()
        {
            txtVariavel1.Clear();
            txtVariavel2.Clear();
            rdbAdicao.Checked = false;
            rdbDivisao.Checked = false;
            rdbMultiplicacao.Checked = false;
            rdbSubtracao.Checked = false;
            lblResposta.Text = ("");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtVariavel1.Focus();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;
            

            try
            {
                num1 = Convert.ToDouble(txtVariavel1.Text);
                num2 = Convert.ToDouble(txtVariavel2.Text);

                if (txtVariavel1.Text.Equals("") || txtVariavel2.Text.Equals(""))
                {
                    MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtVariavel1.Focus();
                }
                if (rdbAdicao.Checked.Equals(false) && rdbDivisao.Checked.Equals(false) && rdbMultiplicacao.Checked.Equals(false) && rdbSubtracao.Checked.Equals(false))
                {
                    MessageBox.Show("Selecione um operador","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); 
                }

                {
                    if (rdbAdicao.Checked)
                    {
                        resultado = num1 + num2;
                    }
                    else if (rdbSubtracao.Checked)
                    {
                        resultado = num1 - num2;
                    }
                    else if (rdbMultiplicacao.Checked)
                    {
                        resultado = num1 * num2;
                    }
                    else if (rdbDivisao.Checked)
                    {
                        if (num2 == 0)
                        {
                            MessageBox.Show("Não é possivel dividir por zero", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        resultado = num1 / num2;
                    }
                    lblResposta.Text = resultado.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtVariavel1.Focus();
            }
        }

        private void frmCalculadoraSimples_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void txtVariavel2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResposta_Click(object sender, EventArgs e)
        {

        }
    }
}
