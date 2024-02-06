using Livraria;

namespace LivrariaPDV
{
    public partial class Form1 : Form
    {

        ListaDeLivros livros;
        ListaDeUsuarios usuarios;
        ListaDeEmprestimos emprestimos;

        Livraria.Data.LivrariaContext contextoDB;

        public Form1()
        {
            InitializeComponent();

            contextoDB = new Livraria.Data.LivrariaContext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txbNomeUsuario.Text != string.Empty && txbUsuario.Text != string.Empty && txbSenha.Text != string.Empty)
            {
                Usuario novo = new Usuario(txbNomeUsuario.Text, txbUsuario.Text, txbSenha.Text);

                usuarios.AdicionaUsuarios(novo);

                contextoDB.Usuarios.Add(novo);

                contextoDB.SaveChanges();


                atualizaDGUsuarios();

            }
        }

        private void atualizaDGUsuarios()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = usuarios.GetUsuarios();
            dgUsuarios.DataSource = bs;
            //dgUsuarios.DataSource = usuarios.GetUsuarios();
            cbUsuarios.DataSource = bs;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            livros = new ListaDeLivros();
            usuarios = new ListaDeUsuarios();
            emprestimos = new ListaDeEmprestimos();


            var dadosUsuarios = contextoDB.Usuarios.ToList();

            BindingSource bs2 = new BindingSource();
            bs2.DataSource = dadosUsuarios;
            dgUsuarios.DataSource = bs2;

        }

        private void btnAdLivro_Click(object sender, EventArgs e)
        {
            livros.CadastraLivro(new Livros(txbLivro.Text, Convert.ToInt32(txbPg.Text), Convert.ToInt32(txbCod.Text), Convert.ToDecimal(txbValor.Text)));

            atualizaDBLivros();

        }

        private void atualizaDBLivros()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = livros.Lista();
            dgLivros.DataSource = bs;
            cbLivros.DataSource = bs;
        }

        private void btnAdEmprestimo_Click(object sender, EventArgs e)
        {
            emprestimos.AdicionaEmprestimo((Usuario)cbUsuarios.SelectedItem, (Livros)cbLivros.SelectedItem);

            atualizaDGEmprestimos();
        }

        private void atualizaDGEmprestimos()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = emprestimos.ListaEmprestimos;
            dgEmprestimos.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivos .JSON (*.json)|*.json";
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                string arquivo = saveFileDialog1.FileName;
                usuarios.SalvaLocalJSON(arquivo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivos .CSV (*.csv)|*.csv";
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                string arquivo = saveFileDialog1.FileName;
                usuarios.SalvaLocalCSV(arquivo);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivos .CSV (*.csv)|*.csv";

            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                string arquivo = openFileDialog1.FileName;
                usuarios.CarregaLocal(arquivo);
                atualizaDGUsuarios();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
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