using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media = default(double);

            if(!double.TryParse(txtNota1.Text, out n1))
                MessageBox.Show("Erro!");

            if(!double.TryParse(txtNota2.Text, out n2))
                MessageBox.Show("Erro!");

            if(!double.TryParse(txtNota3.Text, out n3))
                MessageBox.Show("Erro!");

            media = (n1 + n2 + n3) / 3.0;                         
           
            txtMedia.Text = media.ToString();
            
            if (media < 5)
                MessageBox.Show("Aluno foi reprovado!!");
            else if (media >= 7)
                MessageBox.Show("Aluno foi aprovado!!");
            else 
                MessageBox.Show("Aluno em recuperação!!");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtMedia.Text = "";
            txtNota1.Focus();
        }
        private void KeyPress_Allow_Only_Numbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
