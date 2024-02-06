using Livraria;
using System.Collections.Generic;
using System.Data;

namespace ControlLivraria
{
    public partial class Form1 : Form
    {
        ListaDeUsuarios usuarios;
        ListaDeLivros livros;
        ListaDeEmprestimos emprestimos;

        Livraria.Data.LivrariaContext contextDb;

        public Form1()
        {
            InitializeComponent();

            contextDb = new Livraria.Data.LivrariaContext();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (txbNome.Text != string.Empty && txbLogin.Text != string.Empty && txbSenha.Text != string.Empty)
            {
                Usuario novo = new Usuario(txbNome.Text, txbLogin.Text, txbSenha.Text);

                usuarios.AdicionaUsuarios(novo);
                contextDb.Usuarios.Add(novo);
                contextDb.SaveChanges();

                atualizaDGVUsuarios();
            }

            if (string.IsNullOrEmpty(txbNome.Text) || string.IsNullOrEmpty(txbLogin.Text) || string.IsNullOrEmpty(txbSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
            else
            {
                usuarios.AdicionaUsuarios(new Usuario(txbNome.Text, txbLogin.Text, txbSenha.Text));
                atualizaDGVUsuarios();
            }
        }

        private void btn_addLivro_Click(object sender, EventArgs e)
        {
            livros.CadastraLivro(new Livros(txtBoxLivro.Text, Convert.ToInt32(txtBoxPaginas.Text), Convert.ToInt32(txtBoxCod.Text), Convert.ToDecimal(txtBoxValor.Text)));

            atualizaDBLivros();

        }

        private void atualizaDBLivros()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = livros.Lista();
            dgvLivros.DataSource = bs;
            comboBoxLivros.DataSource = bs;
        }

        private void atualizaDGVUsuarios()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = usuarios.GetUsuarios();
            dgvUsuarios.DataSource = bs;
            comboBoxUsuario.DataSource = bs;

        }

        private void atualizaDGVEmprestimos()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = emprestimos.ListaEmprestimos;
            dgvEmprestimos.DataSource = bs;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            livros = new ListaDeLivros();
            usuarios = new ListaDeUsuarios();
            emprestimos = new ListaDeEmprestimos();


            var dadosUsuarios = contextDb.Usuarios.ToList();

            BindingSource bs2 = new BindingSource();
            bs2.DataSource = dadosUsuarios;
            dgvUsuarios.DataSource = bs2;

        }

        private void expCSVUser_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivos .CSV (*.csv)|*.csv";
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                string arquivo = saveFileDialog1.FileName;
                usuarios.SalvaLocalCSV(arquivo);
            }
        }

        private void importCSVUser_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivos .CSV (*.csv)|*.csv";

            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                string arquivo = openFileDialog1.FileName;
                usuarios.CarregaLocal(arquivo);
                atualizaDGVUsuarios();
            }
        }

        private void expJSONUser_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivos .JSON (*.json)|*.json";
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                string arquivo = saveFileDialog1.FileName;
                emprestimos.SalvaLocalJSON(arquivo);
            }
        }
    }
}