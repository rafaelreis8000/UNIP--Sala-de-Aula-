namespace Sistema
{
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
        }
        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e) //botão Produto
        {
            bool IsOpen = false; //cria uma checagem se a aba está aberta
            foreach (Form f in Application.OpenForms)
            {

                if (f.Text == "Form2")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }

            }

            if (IsOpen == false)
            {
                Form2 f2 = new Form2();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e) //botão cliente
        {
            Form f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e) //botão fechar
        {
            foreach (Form mdiChildForm in MdiChildren)
            {
                mdiChildForm.Close();
            }
        }
    }
}
