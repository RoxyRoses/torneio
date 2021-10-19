using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using torneio.BiliotecaTorneio;

namespace torneio
{
    public partial class CriarTime : Form
    {
        public CriarTime()
        {
            InitializeComponent();
        }

        private void CriarTime_Load(object sender, EventArgs e)
        {

        }


        private bool ValidarForm()
        {
            if(nomeTextBox.Text.Length == 0)
            {
                return false;
            }
            if (sobrenomeTextBox.Text.Length == 0)
            {
                return false;
            }
            if (emailTextBox.Text.Length == 0)
            {
                return false;
            }
            if (celularTextBox.Text.Length == 0)
            {
                return false;
            }

            return true;

        }

        private void criarMembroButton_Click(object sender, EventArgs e)
        {
            if(ValidarForm())
            {
                Pessoa p = new Pessoa();

                p.primeiroNome = nomeTextBox.Text;
                p.ultimoNome = sobrenomeTextBox.Text;
                p.email = emailTextBox.Text;
                p.celular = celularTextBox.Text;

            }
            else
            {
                MessageBox.Show("Digite todos os valores");
            }
        }
    }
}
