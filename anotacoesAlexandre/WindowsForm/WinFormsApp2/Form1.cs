namespace WinFormsApp2
{
    public partial class Form_principal : Form
    {

        List<string> listaNomes = new List<string>();

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
                //verificar se o nome já existe
                if (listaNomes.Contains(textBox_nomeCompleto.Text.ToUpper()))
                {
                    MessageBox.Show("Nome já cadastrado", "ATENÇÃO");
                }
                else
                {
                    listaNomes.Add(textBox_nomeCompleto.Text.ToUpper());

                    listaNomes.Sort();

                    //inserir o conteúdo da lista ordenado
                    atualizarTextBox_lista();

                    textBox_nomeCompleto.Text = String.Empty;
                }
            }
            textBox_nomeCompleto.Focus();
        }   
        
        private void atualizarTextBox_lista()
        {
            textBox_listaNomes.Text = String.Empty;

            foreach (var i in listaNomes)
            {
                textBox_listaNomes.Text += i + Environment.NewLine;
            }
        }
    }
}