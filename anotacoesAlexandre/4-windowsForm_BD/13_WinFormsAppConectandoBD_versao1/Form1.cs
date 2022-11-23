using System.Configuration;
using Microsoft.Data.SqlClient;

namespace _13_WinFormsAppConectandoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string conexaoString = ConfigurationManager.ConnectionStrings["GlicemiaDBString"].ConnectionString;

        private void carregarListView()
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //sqlTexto -> comando -> leitor (select)
                string sqlTexto = "SELECT [MedidaGlicemia].idMedidaGlicemia, [MedidaGlicemia].valorGlicemia, [MedidaGlicemia].dataMedida, [Paciente].nome, [Paciente].idPaciente FROM MedidaGlicemia, Paciente WHERE[MedidaGlicemia].idPaciente = [Paciente].idPaciente";
                //string sqlTexto = "SELECT idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);

                listView_medidasGlicemias.Items.Clear();
                SqlDataReader leitor = comando.ExecuteReader();
                int i = 0;
                string[] vetorDados;
                while (leitor.Read())
                {
                    listView_medidasGlicemias.Items.Add(leitor["idMedidaGlicemia"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["valorGlicemia"].ToString());
                    vetorDados = leitor["dataMedida"].ToString().Split(' ');
                    listView_medidasGlicemias.Items[i].SubItems.Add(vetorDados[0]);
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["nome"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["idPaciente"].ToString());
                    i++;
                }
                conexao.Close();
                button_conectarBD.Enabled = false;
                //MessageBox.Show("Banco conectado com sucesso!", "Atenção");
            }
            catch (Exception e)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + e.ToString(), "Alerta");
            }
        }

        private void button_conectarBD_Click(object sender, EventArgs e)
        {
            carregarListView();
            button_cadastrar.Enabled = true;
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            panel_campos.Enabled = true;
            //pega o último idMedida da tabela e soma 1
            textBox_idMedida.Text = "" + (int.Parse(listView_medidasGlicemias.Items[listView_medidasGlicemias.Items.Count - 1].SubItems[0].Text) + 1);
            textBox_valorGlicemia.Text = "";
            textBox_dataMedicao.Text = "";
            textBox_idPaciente.Text = "";
        }

        private void button_gravar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //capturar valores das variáveis
                int idMedidaGlicemia = int.Parse(textBox_idMedida.Text);
                int valorGlicemia = int.Parse(textBox_valorGlicemia.Text);
                string dataMedida = textBox_dataMedicao.Text;
                int idPaciente = int.Parse(textBox_idPaciente.Text);

                //gerar sentença SQL update
                string sqlUpdate = "UPDATE MedidaGlicemia SET valorGlicemia = @valorGlicemia, dataMedida = @dataMedida, idPaciente = @idPaciente WHERE idMedidaGlicemia = @idMedidaGlicemia";
                SqlCommand comando = new SqlCommand(sqlUpdate, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                comando.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                comando.Parameters.AddWithValue("@dataMedida", dataMedida);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);

                int contadorLinhas = comando.ExecuteNonQuery();
                MessageBox.Show("feito");

                //executar sentença SQL                
                if (contadorLinhas < 1) //se rodou o update, não faz o select
                {
                    //gerar sentenças SQL select
                    string sqlTexto = "INSERT INTO MedidaGlicemia (idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente) VALUES(@idMedidaGlicemia, @valorGlicemia, @dataMedida, @idPaciente)";
                    comando = new SqlCommand(sqlTexto, conexao);
                    comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                    comando.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                    comando.Parameters.AddWithValue("@dataMedida", dataMedida);
                    comando.Parameters.AddWithValue("@idPaciente", idPaciente);
                    //executar sentença SQL
                    comando.ExecuteNonQuery();
                }
                conexao.Close();

                //recarregar ListView
                carregarListView();

                panel_campos.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + e.ToString(), "Alerta");
            }
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //MessageBox.Show(listView_medidasGlicemias.SelectedItems[0].Text);
                int idMedidaGlicemia = int.Parse(listView_medidasGlicemias.SelectedItems[0].Text);

                //gerar sentenças SQL
                string sqlTexto = "DELETE FROM MedidaGlicemia WHERE idMedidaGlicemia = @idMedidaGlicemia";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);

                //executar sentença SQL
                comando.ExecuteNonQuery();
                conexao.Close();

                //recarregar ListView
                carregarListView();

                button_cadastrar.Enabled = true;
                button_deletar.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + e.ToString(), "Alerta");
            }
        }

        private void listView_medidasGlicemias_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_deletar.Enabled = true;
            button_cadastrar.Enabled = false;
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            panel_campos.Enabled = true;    
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //MessageBox.Show(listView_medidasGlicemias.SelectedItems[0].Text);
                int idMedidaGlicemia = int.Parse(listView_medidasGlicemias.SelectedItems[0].Text);

                //gerar sentenças SQL
                string sqlTexto = "SELECT idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia WHERE idMedidaGlicemia = @idMedidaGlicemia";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);

                //executar sentença SQL
                SqlDataReader leitor = comando.ExecuteReader();

                leitor.Read();
                textBox_idMedida.Text = leitor["idMedidaGlicemia"].ToString();
                textBox_valorGlicemia.Text = leitor["valorGlicemia"].ToString();

                string[] vetorDados;
                vetorDados = leitor["dataMedida"].ToString().Split();
                textBox_dataMedicao.Text = vetorDados[0];
                textBox_idPaciente.Text = leitor["idPaciente"].ToString();

                conexao.Close();

                //recarregar ListView
                carregarListView();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + e.ToString(), "Alerta");
            }
        }
    }
}