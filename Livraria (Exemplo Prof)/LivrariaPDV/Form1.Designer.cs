﻿namespace LivrariaPDV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tbUsuarios = new TabPage();
            panel2 = new Panel();
            dgUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            Senha = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            txbSenha = new TextBox();
            label2 = new Label();
            txbUsuario = new TextBox();
            label1 = new Label();
            txbNomeUsuario = new TextBox();
            btnAddUsuario = new Button();
            tbLivros = new TabPage();
            panel4 = new Panel();
            dgLivros = new DataGridView();
            panel3 = new Panel();
            label7 = new Label();
            txbValor = new TextBox();
            label4 = new Label();
            txbCod = new TextBox();
            label5 = new Label();
            txbPg = new TextBox();
            label6 = new Label();
            txbLivro = new TextBox();
            btnAdLivro = new Button();
            tbEmprestimo = new TabPage();
            panel6 = new Panel();
            dgEmprestimos = new DataGridView();
            Livro = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            button4 = new Button();
            cbLivros = new ComboBox();
            cbUsuarios = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            btnAdEmprestimo = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tbUsuarios.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            panel1.SuspendLayout();
            tbLivros.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLivros).BeginInit();
            panel3.SuspendLayout();
            tbEmprestimo.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgEmprestimos).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbUsuarios);
            tabControl1.Controls.Add(tbLivros);
            tabControl1.Controls.Add(tbEmprestimo);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(641, 433);
            tabControl1.TabIndex = 4;
            // 
            // tbUsuarios
            // 
            tbUsuarios.Controls.Add(panel2);
            tbUsuarios.Controls.Add(panel1);
            tbUsuarios.Location = new Point(4, 24);
            tbUsuarios.Name = "tbUsuarios";
            tbUsuarios.Padding = new Padding(3);
            tbUsuarios.Size = new Size(633, 405);
            tbUsuarios.TabIndex = 0;
            tbUsuarios.Text = "Usuarios";
            tbUsuarios.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgUsuarios);
            panel2.Location = new Point(6, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(617, 324);
            panel2.TabIndex = 2;
            // 
            // dgUsuarios
            // 
            dgUsuarios.AllowUserToAddRows = false;
            dgUsuarios.AllowUserToDeleteRows = false;
            dgUsuarios.AllowUserToOrderColumns = true;
            dgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Login, Senha });
            dgUsuarios.Dock = DockStyle.Fill;
            dgUsuarios.Location = new Point(0, 0);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.ReadOnly = true;
            dgUsuarios.RowHeadersVisible = false;
            dgUsuarios.RowTemplate.Height = 25;
            dgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsuarios.Size = new Size(617, 324);
            dgUsuarios.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 24;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Usuario";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Login
            // 
            Login.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Login.DataPropertyName = "Login";
            Login.HeaderText = "Login";
            Login.Name = "Login";
            Login.ReadOnly = true;
            // 
            // Senha
            // 
            Senha.DataPropertyName = "Senha";
            Senha.HeaderText = "Senha";
            Senha.Name = "Senha";
            Senha.ReadOnly = true;
            Senha.Visible = false;
            Senha.Width = 64;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbSenha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbUsuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txbNomeUsuario);
            panel1.Controls.Add(btnAddUsuario);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 71);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Image = Properties.Resources.import_csv_32px;
            button3.Location = new Point(536, 6);
            button3.Name = "button3";
            button3.Size = new Size(70, 57);
            button3.TabIndex = 11;
            button3.Text = "Importar";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Image = Properties.Resources.export_csv_32px;
            button2.Location = new Point(460, 6);
            button2.Name = "button2";
            button2.Size = new Size(70, 57);
            button2.TabIndex = 10;
            button2.Text = "Exportar";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Image = Properties.Resources.json_download_32px;
            button1.Location = new Point(386, 5);
            button1.Name = "button1";
            button1.Size = new Size(70, 57);
            button1.TabIndex = 9;
            button1.Text = "Exportar";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 43);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Senha";
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(202, 35);
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(102, 23);
            txbSenha.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 43);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 5;
            label2.Text = "Login";
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(49, 35);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(102, 23);
            txbUsuario.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // txbNomeUsuario
            // 
            txbNomeUsuario.Location = new Point(49, 6);
            txbNomeUsuario.Name = "txbNomeUsuario";
            txbNomeUsuario.Size = new Size(255, 23);
            txbNomeUsuario.TabIndex = 4;
            // 
            // btnAddUsuario
            // 
            btnAddUsuario.AutoSize = true;
            btnAddUsuario.Image = Properties.Resources.add_user_male_30px;
            btnAddUsuario.Location = new Point(310, 5);
            btnAddUsuario.Name = "btnAddUsuario";
            btnAddUsuario.Size = new Size(70, 57);
            btnAddUsuario.TabIndex = 3;
            btnAddUsuario.Text = "Adicionar";
            btnAddUsuario.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddUsuario.UseVisualStyleBackColor = true;
            btnAddUsuario.Click += button4_Click;
            // 
            // tbLivros
            // 
            tbLivros.Controls.Add(panel4);
            tbLivros.Controls.Add(panel3);
            tbLivros.Location = new Point(4, 24);
            tbLivros.Name = "tbLivros";
            tbLivros.Padding = new Padding(3);
            tbLivros.Size = new Size(633, 405);
            tbLivros.TabIndex = 1;
            tbLivros.Text = "Livros";
            tbLivros.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgLivros);
            panel4.Location = new Point(6, 75);
            panel4.Name = "panel4";
            panel4.Size = new Size(406, 324);
            panel4.TabIndex = 3;
            // 
            // dgLivros
            // 
            dgLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLivros.Dock = DockStyle.Fill;
            dgLivros.Location = new Point(0, 0);
            dgLivros.Name = "dgLivros";
            dgLivros.RowTemplate.Height = 25;
            dgLivros.Size = new Size(406, 324);
            dgLivros.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txbValor);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txbCod);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txbPg);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txbLivro);
            panel3.Controls.Add(btnAdLivro);
            panel3.Location = new Point(6, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(404, 63);
            panel3.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(196, 43);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 9;
            label7.Text = "Valor";
            // 
            // txbValor
            // 
            txbValor.Location = new Point(235, 35);
            txbValor.Name = "txbValor";
            txbValor.Size = new Size(83, 23);
            txbValor.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 43);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 7;
            label4.Text = "Cód";
            // 
            // txbCod
            // 
            txbCod.Location = new Point(144, 35);
            txbCod.Name = "txbCod";
            txbCod.Size = new Size(46, 23);
            txbCod.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 43);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 5;
            label5.Text = "Paginas";
            // 
            // txbPg
            // 
            txbPg.Location = new Point(49, 35);
            txbPg.Name = "txbPg";
            txbPg.Size = new Size(46, 23);
            txbPg.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 14);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 3;
            label6.Text = "Livro";
            // 
            // txbLivro
            // 
            txbLivro.Location = new Point(49, 6);
            txbLivro.Name = "txbLivro";
            txbLivro.Size = new Size(269, 23);
            txbLivro.TabIndex = 4;
            // 
            // btnAdLivro
            // 
            btnAdLivro.AutoSize = true;
            btnAdLivro.Image = Properties.Resources.add_book_30px;
            btnAdLivro.Location = new Point(327, 3);
            btnAdLivro.Name = "btnAdLivro";
            btnAdLivro.Size = new Size(68, 55);
            btnAdLivro.TabIndex = 3;
            btnAdLivro.Text = "Adicionar";
            btnAdLivro.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdLivro.UseVisualStyleBackColor = true;
            btnAdLivro.Click += btnAdLivro_Click;
            // 
            // tbEmprestimo
            // 
            tbEmprestimo.Controls.Add(panel6);
            tbEmprestimo.Controls.Add(panel5);
            tbEmprestimo.Location = new Point(4, 24);
            tbEmprestimo.Name = "tbEmprestimo";
            tbEmprestimo.Size = new Size(633, 405);
            tbEmprestimo.TabIndex = 2;
            tbEmprestimo.Text = "Empréstimos";
            tbEmprestimo.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(dgEmprestimos);
            panel6.Location = new Point(3, 72);
            panel6.Name = "panel6";
            panel6.Size = new Size(412, 324);
            panel6.TabIndex = 4;
            // 
            // dgEmprestimos
            // 
            dgEmprestimos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmprestimos.Columns.AddRange(new DataGridViewColumn[] { Livro, Usuario });
            dgEmprestimos.Dock = DockStyle.Fill;
            dgEmprestimos.Location = new Point(0, 0);
            dgEmprestimos.Name = "dgEmprestimos";
            dgEmprestimos.RowTemplate.Height = 25;
            dgEmprestimos.Size = new Size(412, 324);
            dgEmprestimos.TabIndex = 0;
            // 
            // Livro
            // 
            Livro.DataPropertyName = "Livros";
            Livro.HeaderText = "Livro";
            Livro.Name = "Livro";
            // 
            // Usuario
            // 
            Usuario.DataPropertyName = "Usuario";
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Controls.Add(cbLivros);
            panel5.Controls.Add(cbUsuarios);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(btnAdEmprestimo);
            panel5.Location = new Point(6, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(420, 63);
            panel5.TabIndex = 3;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Image = Properties.Resources.json_download_32px;
            button4.Location = new Point(317, 3);
            button4.Name = "button4";
            button4.Size = new Size(70, 57);
            button4.TabIndex = 13;
            button4.Text = "Exportar";
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // cbLivros
            // 
            cbLivros.DisplayMember = "Livro";
            cbLivros.FormattingEnabled = true;
            cbLivros.Location = new Point(57, 35);
            cbLivros.Name = "cbLivros";
            cbLivros.Size = new Size(172, 23);
            cbLivros.TabIndex = 12;
            cbLivros.ValueMember = "Livro";
            // 
            // cbUsuarios
            // 
            cbUsuarios.DisplayMember = "Nome";
            cbUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUsuarios.FormattingEnabled = true;
            cbUsuarios.Location = new Point(57, 6);
            cbUsuarios.Name = "cbUsuarios";
            cbUsuarios.Size = new Size(172, 23);
            cbUsuarios.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 43);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 5;
            label10.Text = "Livro";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 14);
            label11.Name = "label11";
            label11.Size = new Size(47, 15);
            label11.TabIndex = 3;
            label11.Text = "Usuario";
            // 
            // btnAdEmprestimo
            // 
            btnAdEmprestimo.AutoSize = true;
            btnAdEmprestimo.Image = (Image)resources.GetObject("btnAdEmprestimo.Image");
            btnAdEmprestimo.Location = new Point(243, 3);
            btnAdEmprestimo.Name = "btnAdEmprestimo";
            btnAdEmprestimo.Size = new Size(68, 57);
            btnAdEmprestimo.TabIndex = 3;
            btnAdEmprestimo.Text = "Adicionar";
            btnAdEmprestimo.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdEmprestimo.UseVisualStyleBackColor = true;
            btnAdEmprestimo.Click += btnAdEmprestimo_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 453);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Livros";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tbUsuarios.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tbLivros.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgLivros).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tbEmprestimo.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgEmprestimos).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tbUsuarios;
        private TabPage tbLivros;
        private TabPage tbEmprestimo;
        private Panel panel1;
        private Button btnAddUsuario;
        private DataGridView dgUsuarios;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private DataGridView dgLivros;
        private Panel panel3;
        private Label label4;
        private TextBox txbCod;
        private Label label5;
        private TextBox txbPg;
        private Label label6;
        private TextBox txbLivro;
        private Button btnAdLivro;
        private Label label7;
        private TextBox txbValor;
        private Panel panel6;
        private DataGridView dgEmprestimos;
        private Panel panel5;
        private Label label10;
        private Label label11;
        private Button btnAdEmprestimo;
        private Label label3;
        private TextBox txbSenha;
        private TextBox txbUsuario;
        private TextBox txbNomeUsuario;
        private ComboBox cbLivros;
        private ComboBox cbUsuarios;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn Senha;
        private DataGridViewTextBoxColumn Livro;
        private DataGridViewTextBoxColumn Usuario;
        private Button button1;
        private SaveFileDialog saveFileDialog1;
        private Button button2;
        private Button button3;
        private OpenFileDialog openFileDialog1;
        private Button button4;
    }
}