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
    public partial class CriarPremio : Form
    {
        public CriarPremio()
        {
            InitializeComponent();
        }

        private void pocentagemLabel_Click(object sender, EventArgs e)
        {

        }

        private void CriarPremio_Load(object sender, EventArgs e)
        {

        }

        private bool ValidarForm()
        {
            if (nomeTextBox.Text.Length == 0)
            {
                return false;
            }
            if (numeroTextBox.Text.Length == 0)
            {
                return false;
            }
            if (premioTextBox.Text.Length == 0)
            {
                return false;
            }
            if (porcentagemTextBox.Text.Length == 0)
            {
                return false;
            }

            return true;

        }

        private void premioButton_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                /*ModeloPremio modelo = new ModeloPremio(
                    nomeTextBox.Text,
                    numeroTextBox.Text,
                    premioTextBox.Text,
                    porcentagemTextBox.Text

                    );

                nomeTextBox.Text = "";
                numeroTextBox.Text = "";
                premioTextBox.Text = "0";
                porcentagemTextBox.Text = "0";*/

            }
            else
            {
                MessageBox.Show("Informacao invalida, digite novamente");
            }
        }
    }
}
