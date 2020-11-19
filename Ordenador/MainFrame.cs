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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbDigite_TextChanged(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void tbDigite_KeyDown(object sender, KeyEventArgs e)
        {

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
