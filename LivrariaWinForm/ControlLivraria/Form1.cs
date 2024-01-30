
using Livraria;

namespace ControlLivraria
{
    public partial class Form1 : Form
    {
        ListaDeUsuarios LUsuarios;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbNome.Text) || string.IsNullOrEmpty(txbLogin.Text) || string.IsNullOrEmpty(txbSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
            else
            {
                LUsuarios.AdicionaUsuarios(new Usuario(txbNome.Text, txbLogin.Text, txbSenha.Text));
                atualizaDGVUsuarios();
            }
        }

        private void atualizaDGVUsuarios()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = LUsuarios.GetUsuarios();
            dgvUsuarios.DataSource = bs;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LUsuarios = new ListaDeUsuarios();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivo .CSV (.csv) | *.csv";
            string nomeArquivo;
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                nomeArquivo = saveFileDialog1.FileName;

                LUsuarios.SalvaLocalCSV(nomeArquivo);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivo .JSON (.json) | *.json";
            string nomeArquivo;
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                nomeArquivo = saveFileDialog1.FileName;

                LUsuarios.SalvaLocalJSON(nomeArquivo);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Arquivo .CSV (.csv) | *.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LUsuarios.CarregaLocal(openFileDialog1.FileName);
            }

            atualizaDGVUsuarios();
        }
    }
}