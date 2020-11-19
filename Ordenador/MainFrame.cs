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

        private List<int> array = new List<int>();

        public fOrdenador()
        {
            InitializeComponent();
        }

        private void tbDigite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(lErro, "Digite um número inteiro.");
                lErro.Text = "Digite um número inteiro.";
                return;
            }
            
            errorProvider1.SetError(lErro, "");
            lErro.Text = "";
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            if(tbDigite.Text.Length == 0)
            {
                lErro.Text = "Digite um número inteiro.";
                tbDigite.Clear();
                tbDigite.Focus();
                return;
            }
            
            int temp = 0;
            tbLista.Text = "";
            array.Add(Convert.ToInt32(tbDigite.Text));
            for (int j=0; j < array.Count; j++)
            {
                for(int i= j+1; i < array.Count; i++)
                {
                    if (array[j] > array[i])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
                tbLista.Text = tbLista.Text + array[j].ToString() + ", ";
            }
            tbLista.Text = tbLista.Text + "(...)";


            int soma = Convert.ToInt32(tbSoma.Text) + Convert.ToInt32(tbDigite.Text);
            tbSoma.Text = soma.ToString();

            tbDigite.Clear();
            tbDigite.Focus();
        }

        private void bLimpar_Click(object sender, EventArgs e)
        {
            array = new List<int>();
            tbSoma.Text = "0";
            tbLista.Clear();
            tbDigite.Clear();
            tbDigite.Focus();
        }
    }
}
