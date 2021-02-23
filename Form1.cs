using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProjetoOperacao
{
    public partial class FrmOperecao : Form
    {
        double n1, n2; //variavel----------------------------

        public FrmOperecao()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdicao_Click(object sender, EventArgs e)
        {
            {
                if ((TxtNumero.Text != ",") && (TxtNumero1.Text != ",") && (TxtNumero.Text != "") && (TxtNumero1.Text != ""))
                {
                    n1 = double.Parse(TxtNumero.Text);
                    n2 = double.Parse(TxtNumero1.Text);
                    MessageBox.Show("A soma é: " + (n1 + n2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Somente Números com ou sem virgulas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNumero.Focus();
            }
        }
    


        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {

            {
                if ((TxtNumero.Text != ",") && (TxtNumero1.Text != ",") && (TxtNumero.Text != "") && (TxtNumero1.Text != ""))
                {
                    n1 = double.Parse(TxtNumero.Text);
                    n2 = double.Parse(TxtNumero1.Text);
                    MessageBox.Show("A Subtração é:" + (n1 - n2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Somente Números com ou sem virgulas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            {

                if ((TxtNumero.Text != ",") && (TxtNumero1.Text != ",") && (TxtNumero.Text != "") && (TxtNumero1.Text != ""))
                {
                    n1 = double.Parse(TxtNumero.Text);
                    n2 = double.Parse(TxtNumero1.Text);
                    MessageBox.Show(" A Multiplicação é:" + (n1 / n2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Somente Números com ou sem virgulas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
        }

        private void Btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && (e.KeyChar!=44))
            {
                e.Handled = true;
                MessageBox.Show("Somente Virgulas e Números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void TxtNumero1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && (e.KeyChar != 44))
            {
                e.Handled = true;
                MessageBox.Show("Somente Virgulas e Números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            {
                if ((TxtNumero.Text != ",") && (TxtNumero1.Text != ",") && (TxtNumero.Text != "") && (TxtNumero1.Text != ""))
                {
                    n1 = double.Parse(TxtNumero.Text);
                    n2 = double.Parse(TxtNumero1.Text);
                    MessageBox.Show("A Divisão é:" + (n1 * n2), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Somente Números com ou sem Virgulas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
