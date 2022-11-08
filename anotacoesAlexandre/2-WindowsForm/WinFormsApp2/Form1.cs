namespace WinFormsApp2
{
    public partial class Form_principal : Form
    {

        List<Pessoa> listaPessoas = new List<Pessoa>();

        public Form_principal()
        {
            InitializeComponent();
        }

        //metodo que trata evento de um componente
        private void button_adicionarLista_Click(object sender, EventArgs e)
        {
            if (textBox_nomeCompleto.Text.Length == 0 || textBox_email.Text.Length == 0)
            {
                MessageBox.Show("É necessário informar os dois campos", "ATENÇÃO");
            } else
            {
                Pessoa pessoa = new Pessoa(textBox_nomeCompleto.Text, textBox_email.Text);
                listaPessoas.Add(pessoa);
                atualizarTextBox_listaNomes();
                limparCampos();
            }
        }
        private void limparCampos()
        {
            textBox_nomeCompleto.Clear();
            textBox_email.Clear();
        }

        
        
        
        private void atualizarTextBox_listaNomes()
        {
            textBox_listaNomes.Text = String.Empty;

            foreach (var i in listaPessoas)
            {
                textBox_listaNomes.Text += i.Nome + Environment.NewLine;
            }
        }
    }
}