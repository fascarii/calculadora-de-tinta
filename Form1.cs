using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ativ08_projeto_calculadora_tinta
{
    public partial class frmCalculaTinta : Form
    {
        decimal rend;

        public frmCalculaTinta()
        {
            InitializeComponent();
        }

        //Este trecho impede que o usuário digite letras ou símbolos nos campos numéricos.
        private void txtLarg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtAlt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtRend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        //Botão "Calcular"
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Esse trecho verifica se todos os camos possuem algum valor digitado.


            //Largura da parede
            if (txtLarg.Text == "")
            {
                MessageBox.Show("Por favor, informe a largura da parede. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmb.Clear();
                txtLarg.Focus();
            }
            else if (Convert.ToDecimal(txtLarg.Text) < 1)
            {
                MessageBox.Show("Digite uma largura maior do que 0 (zero)", "Opa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmb.Clear();
                txtLarg.Focus();
            }

            //Altura da parede
            else if (txtAlt.Text == "")
            {
                MessageBox.Show("Parece que você não informou a altura da parede.", "Opa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmb.Clear();
                txtAlt.Focus();
            }
            else if (Convert.ToDecimal(txtAlt.Text) < 1)
            {
                MessageBox.Show("A altura deve se maior que  0 (zero).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmb.Clear();
                txtAlt.Focus();
            }

            //Rendimento por embalagem
            else if (txtRend.Text == "")
            {
                MessageBox.Show("Você deve informar o rendimento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmb.Clear();
                txtRend.Focus();
            }
            else if (Convert.ToDecimal(txtRend.Text) <= 1)
            {
                MessageBox.Show("O rendimento deve ser maior que 1 m²", "Opa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmb.Clear();
                txtRend.Focus();
            }

            //Cálculo
            else
            {
                rend = (Convert.ToDecimal(txtAlt.Text) * Convert.ToDecimal(txtLarg.Text) / Convert.ToDecimal(txtRend.Text) * nudDemaos.Value);
                txtEmb.Text = Math.Ceiling(rend).ToString();
            }
        }


        //Sub-rotina para limpar os campos do formulário reiniciar o numericUpDown
        void LimparCampos()
        {
            txtLarg.Clear();
            txtAlt.Clear();
            txtRend.Clear();
            txtEmb.Clear();
            nudDemaos.Value = 1;
        }

        //Botão "Limpar"
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtLarg.Focus();
        }

        //Botão "Sair"
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Este botão altera a cor de fundo
        private void cbxDark_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDark.Checked)
            {
                this.cbxDark.BackColor = Color.AliceBlue;
                this.BackColor = Color.Gray;
                this.lblLarg.ForeColor = Color.White;
                this.lblAlt.ForeColor = Color.White;
                this.lblRend.ForeColor = Color.White;
                this.lblDemaos.ForeColor = Color.White;
                this.lblEmb.ForeColor = Color.White;
            }
            else
            {
                this.cbxDark.BackColor = Color.Gray;
                this.BackColor = Color.AliceBlue;
                this.lblLarg.ForeColor = Color.Black;
                this.lblAlt.ForeColor = Color.Black;
                this.lblRend.ForeColor = Color.Black;
                this.lblDemaos.ForeColor = Color.Black;
                this.lblEmb.ForeColor = Color.Black;
            }
        }
    }
}
