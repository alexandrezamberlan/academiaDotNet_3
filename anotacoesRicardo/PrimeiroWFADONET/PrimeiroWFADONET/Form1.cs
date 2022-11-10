using WinFormsADONet;

namespace PrimeiroWFADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departamento d = new Departamento(txb_NomeDPTO.Text, txb_LocalizacaoDPTO.Text, txb_OrcamentoDPTO.Text);
            /* bool sucesso = d.gravarDepartamento();
             if (sucesso == true)
                 MessageBox.Show("Salvo com sucesso!", "Atenção");
             else
                 MessageBox.Show("Erro ao salvar Departamento!", "Erro!");*/
            if (d.gravarDepartamento())
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            else
                MessageBox.Show("Erro ao salvar Departamento!", "Erro!");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}