using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenador
{
    public partial class fOrdenador : Form
    {

        private List<double> array = new List<double>();

        public fOrdenador()
        {
            InitializeComponent();
        }

        private void tbDigite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-')) 
                || (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                || ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1)))
            {
                e.Handled = true;
                errorProvider1.SetError(lErro, "Digite um número.");
                lErro.Text = "Digite um número.";
                return;
            }

            errorProvider1.SetError(lErro, "");
            lErro.Text = "";
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            if(tbDigite.Text.Length == 0 
                || tbDigite.Text.EndsWith("-") 
                || tbDigite.Text.EndsWith(","))
            {
                errorProvider1.SetError(lErro, "Digite um número.");
                lErro.Text = "Digite um número.";
                tbDigite.Clear();
                tbDigite.Focus();
                return;
            }

            atualizarLista();
            somar();
            
            tbDigite.Clear();
            tbDigite.Focus();
        }

        private void bLimpar_Click(object sender, EventArgs e)
        {
            array = new List<double>();
            tbSoma.Text = "0";
            tbLista.Clear();
            tbDigite.Clear();
            tbDigite.Focus();
        }

        private void atualizarLista()
        {
            array.Add(Convert.ToDouble(tbDigite.Text));
            double temp = 0;
            tbLista.Text = "";
            for (int j = 0; j < array.Count; j++)
            {
                for (int i = j + 1; i < array.Count; i++)
                {
                    if (array[j] > array[i])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
                tbLista.Text = tbLista.Text + array[j].ToString() + "; ";
            }
            tbLista.Text = tbLista.Text + "(...)";
        }

        private void somar()
        {
            double soma = Convert.ToDouble(tbSoma.Text) + Convert.ToDouble(tbDigite.Text);
            tbSoma.Text = soma.ToString();
        }
    }
}
