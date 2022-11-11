using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using Microsoft.Data.SqlClient;

namespace WinFormsAppBancoExemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   
        private string conexaoString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=glicemia_db;TrustServerCertificate=True;Integrated Security=True";

        private void limparCampos()
        {
            textBox_idPaciente.Text = "";
            textBox_nome.Text = "";
            textBox_email.Text = "";
        }
        
        private void carregarListView()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(conexaoString);
                conexao.Open();

                string sqlTexto = "SELECT idPaciente, nome, email FROM Paciente";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                SqlDataReader leitor = comando.ExecuteReader();

                listView_pacientes.Items.Clear();
                int i = 0;
                while (leitor.Read())
                {
                    listView_pacientes.Items.Add(leitor["idPaciente"].ToString());
                    listView_pacientes.Items[i].SubItems.Add(leitor["nome"].ToString());
                    listView_pacientes.Items[i].SubItems.Add(leitor["email"].ToString());
                    i++;
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas de Conexão com o Banco " + ex.Message, "Alerta");
            }
        }
        private void button_conectar_Click(object sender, EventArgs e)
        {
            this.carregarListView();
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            panel_campos.Enabled = true;
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //capturar valores das variáveis
                int idPaciente = int.Parse(textBox_idPaciente.Text);
                string nome = textBox_nome.Text;
                string email = textBox_email.Text;

                //gerar sentença SQL update
                string sqlUpdate = "UPDATE Paciente SET nome = @nome, email = @email WHERE idPaciente = @idPaciente";
                SqlCommand comando = new SqlCommand(sqlUpdate, conexao);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@email", email);

                int contadorLinhas = comando.ExecuteNonQuery();              

                //executar sentença SQL                
                if (contadorLinhas < 1) { //se rodou o update, não faz o 
                    //gerar sentenças SQL
                    string sqlTexto = "INSERT INTO Paciente (idPaciente, nome, email) VALUES (@idPaciente, @nome, @email)";
                    comando = new SqlCommand(sqlTexto, conexao);
                    comando.Parameters.AddWithValue("@idPaciente", idPaciente);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@email", email);

                    //executar sentença SQL
                    comando.ExecuteNonQuery();
                }
                conexao.Close();
                //recarregar ListView
                this.carregarListView();
                this.limparCampos();
                panel_campos.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas de Conexão com o Banco " + ex.Message, "Alerta");
            }           
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //MessageBox.Show(listView_medidasGlicemias.SelectedItems[0].Text);
                int idPaciente = int.Parse(listView_pacientes.SelectedItems[0].Text);

                //gerar sentenças SQL
                string sqlTexto = "DELETE FROM Paciente WHERE idPaciente = @idPaciente";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);

                //executar sentença SQL
                comando.ExecuteNonQuery();
                conexao.Close();
                this.limparCampos();
                //recarregar ListView
                this.carregarListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas de Conexão com o Banco " + ex.Message, "Alerta");
            }            
        }

        private void listView_pacientes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                textBox_idPaciente.Text = listView_pacientes.SelectedItems[0].Text;
                textBox_nome.Text = listView_pacientes.SelectedItems[0].SubItems[1].Text;
                textBox_email.Text = listView_pacientes.SelectedItems[0].SubItems[2].Text;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro na seleção do list view " + ex.Message,"Alerta");
            }
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            panel_campos.Enabled = false;
            this.limparCampos();
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            try
            {
                panel_campos.Enabled = true;
                textBox_idPaciente.Text = listView_pacientes.SelectedItems[0].Text;
                textBox_nome.Text = listView_pacientes.SelectedItems[0].SubItems[1].Text;
                textBox_email.Text = listView_pacientes.SelectedItems[0].SubItems[2].Text; ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Primeiro conecte ao banco" + ex.Message, "Alerta");
            }
        }
    }
}
