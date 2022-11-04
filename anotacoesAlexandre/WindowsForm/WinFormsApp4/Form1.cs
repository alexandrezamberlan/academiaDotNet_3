namespace WinFormsApp4
{
    public partial class Form_principal : Form
    {
        List<string> listaNomes = new List<string>();
        string nomeArquivoDados = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "pessoas.csv");
        public Form_principal()
        {
            InitializeComponent();
            Modelo.lerArquivo(listaNomes, nomeArquivoDados);
            atualizarTextBox_listaNomes();
        }

        private void atualizarTextBox_listaNomes()
        {
            textBox_listaJogadores.Clear();
            foreach (var item in listaNomes)
            {
                textBox_listaJogadores.AppendText(item + Environment.NewLine);
            }
        }

        private void button_trocar_Click(object sender, EventArgs e)
        {
            label_titulo.BackColor = Color.Green;
        }

        private void button_paraMaiusculo_Click(object sender, EventArgs e)
        {
            if (textBox_nomeJogador.Text == "")
            {
                MessageBox.Show("Digite algo primeiro", "Alerta");
            } else
            {
                textBox_nomeJogador.Text = textBox_nomeJogador.Text.ToUpper();
            }
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_nomeJogador.Clear();
            textBox_listaJogadores.Clear();
            listaNomes.Clear();
            label_totalNomes.Text = "Total: 0";
        }

        private void button_inserir_Click(object sender, EventArgs e)
        {
            if (textBox_nomeJogador.Text == "")
            {
                MessageBox.Show("Digite algo primeiro", "Alerta");
            }
            else
            {
                textBox_nomeJogador.Text = textBox_nomeJogador.Text.ToUpper();
                if (listaNomes.Contains(textBox_nomeJogador.Text))
                {
                    MessageBox.Show("Nome já existente na lista", "Alerta");
                } else
                {
                    //guardando o nome na lista em memória
                    listaNomes.Add(textBox_nomeJogador.Text);
                    //ordenando a lista
                    listaNomes.Sort();

                    //colocando nome no front-end grafico a partir da lista
                    atualizarTextBox_listaNomes();

                    //persistir a lista na base de dados
                    Modelo.gravarLista(listaNomes,nomeArquivoDados);                    

                    //atualizando o total de nomes
                    label_totalNomes.Text = "Total: " + listaNomes.Count();
                }
                textBox_nomeJogador.Clear();
                textBox_nomeJogador.Focus();
            }
        }


    }
}