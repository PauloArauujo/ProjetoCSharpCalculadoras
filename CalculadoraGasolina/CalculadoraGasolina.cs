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


namespace CalculadoraGasolina
{
    public partial class CalculadoraGasolina : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public CalculadoraGasolina()
        {
            InitializeComponent();
        }

        private void CalculadoraGasolina_Load(object sender, EventArgs e)
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
            txtKm.Clear();
            txtLitro.Clear();
            txtPreco.Clear();
            lblResultadoPreco.Text = ("");
            lblResultadoKm.Text = ("");
            lblResultadoConsumo.Text = ("");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtKm.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double km, litro, preco, consumo, precototal, distancia = 0;

                km = Convert.ToDouble(txtKm.Text);
                litro = Convert.ToDouble(txtLitro.Text);
                preco = Convert.ToDouble(txtPreco.Text);

                distancia = km;
                consumo = km / litro;
                precototal = consumo * preco;

                lblResultadoPreco.Text = string.Format("{0:n1}", precototal);
                lblResultadoConsumo.Text = string.Format("{0:n1}", consumo);
                lblResultadoKm.Text = string.Format("{0:n1}", distancia);

            }
            catch (Exception)
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLitro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
