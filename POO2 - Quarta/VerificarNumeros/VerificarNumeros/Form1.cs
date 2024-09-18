namespace VerificarNumeros
{
    public partial class FrmVerifica : Form
    {
        public FrmVerifica()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            int n = 0;
            n = int.Parse(txtnum.Text);
            if (n % 2 == 0)
            {
                lblresultado.Text = "O número " + n.ToString() + " é PAR";
            }

            else
            {
                lblresultado.Text = "O número " + n.ToString() + " é ÍMPAR";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            lblresultado.Text = "";
            txtnum.Focus();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do Programa?", "*** Finalizando ***",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button4)== DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtnum.Clear();
                lblresultado.Text = "";
                txtnum.Focus();
            }
        }
    }
}
