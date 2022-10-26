namespace WinFormsApp2
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }

        //metodo que trata evento de um componente
        private void button_adicionarLista_Click(object sender, EventArgs e)
        {
            inserirTextBox_lista();
        }

        private void textBox_nomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                inserirTextBox_lista();
            }
        }

        private void inserirTextBox_lista()
        {
            if (textBox_nomeCompleto.Text.Length == 0)
            {
                MessageBox.Show("Para adicionar nome, é preciso digitar algo", "ATENÇÃO");
            }
            else
            {
                textBox_listaNomes.Text += textBox_nomeCompleto.Text.ToUpper() + Environment.NewLine;
                textBox_nomeCompleto.Text = String.Empty;
            }
            textBox_nomeCompleto.Focus();
        }
    }
}