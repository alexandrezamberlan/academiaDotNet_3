using System.Data;

namespace AulaBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txbNome.Text;
            p.peso = float.Parse(txbPeso.Text);

            if(p.gravar())
            {
                MessageBox.Show("Pessoa inserida com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao inserir a Pessoa!");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from pessoas");

            dataGridView1.DataSource = dt;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from pessoas " +
                "where nome = '" + txbFiltro.Text + "'");

            dataGridView1.DataSource = dt;
        }
    }
}