namespace ControlLivraria
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
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            dgvUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            Senha = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnAdicionar = new Button();
            txbSenha = new TextBox();
            label3 = new Label();
            txbLogin = new TextBox();
            label2 = new Label();
            txbNome = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            groupBox3 = new GroupBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox5 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox6 = new GroupBox();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(663, 426);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(655, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Usuarios";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvUsuarios);
            groupBox2.Location = new Point(6, 97);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(640, 295);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Login, Senha });
            dgvUsuarios.Location = new Point(6, 17);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(628, 272);
            dgvUsuarios.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txbSenha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbLogin);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txbNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 85);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Image = Properties.Resources.import_csv_32px;
            button3.Location = new Point(549, 19);
            button3.Name = "button3";
            button3.Size = new Size(75, 57);
            button3.TabIndex = 9;
            button3.Text = "Imp. CSV";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Image = Properties.Resources.json_download_32px;
            button2.Location = new Point(468, 19);
            button2.Name = "button2";
            button2.Size = new Size(75, 57);
            button2.TabIndex = 8;
            button2.Text = "Exp. JSON";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Image = Properties.Resources.export_csv_32px;
            button1.Location = new Point(387, 19);
            button1.Name = "button1";
            button1.Size = new Size(75, 57);
            button1.TabIndex = 7;
            button1.Text = "Exp. CSV";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoSize = true;
            btnAdicionar.Image = Properties.Resources.usuario2;
            btnAdicionar.Location = new Point(306, 19);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 57);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(199, 48);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(96, 23);
            txbSenha.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 51);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            // 
            // txbLogin
            // 
            txbLogin.Location = new Point(49, 48);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(96, 23);
            txbLogin.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 51);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Login";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(49, 19);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(246, 23);
            txbNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 22);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox6);
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(655, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Livros";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(655, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Empréstimos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(3, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(640, 85);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Image = Properties.Resources.import_csv_32px;
            button4.Location = new Point(549, 19);
            button4.Name = "button4";
            button4.Size = new Size(75, 57);
            button4.TabIndex = 9;
            button4.Text = "Imp. CSV";
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Image = Properties.Resources.json_download_32px;
            button5.Location = new Point(468, 19);
            button5.Name = "button5";
            button5.Size = new Size(75, 57);
            button5.TabIndex = 8;
            button5.Text = "Exp. JSON";
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Image = Properties.Resources.export_csv_32px;
            button6.Location = new Point(387, 19);
            button6.Name = "button6";
            button6.Size = new Size(75, 57);
            button6.TabIndex = 7;
            button6.Text = "Exp. CSV";
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.Image = Properties.Resources.transfer_s32px;
            button7.Location = new Point(306, 19);
            button7.Name = "button7";
            button7.Size = new Size(75, 57);
            button7.TabIndex = 6;
            button7.Text = "Adicionar";
            button7.TextImageRelation = TextImageRelation.ImageAboveText;
            button7.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 22);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 0;
            label6.Text = "Usuarios";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(63, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 23);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(63, 48);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(232, 23);
            comboBox2.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 51);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "Livros";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(3, 97);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(640, 295);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(628, 272);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView2);
            groupBox5.Location = new Point(6, 100);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(640, 295);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 17);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(628, 272);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBox4);
            groupBox6.Controls.Add(label9);
            groupBox6.Controls.Add(button8);
            groupBox6.Controls.Add(button9);
            groupBox6.Controls.Add(button10);
            groupBox6.Controls.Add(button11);
            groupBox6.Controls.Add(textBox1);
            groupBox6.Controls.Add(label5);
            groupBox6.Controls.Add(textBox2);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(textBox3);
            groupBox6.Controls.Add(label8);
            groupBox6.Location = new Point(9, 9);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(640, 85);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            // 
            // button8
            // 
            button8.AutoSize = true;
            button8.Image = Properties.Resources.import_csv_32px;
            button8.Location = new Point(549, 19);
            button8.Name = "button8";
            button8.Size = new Size(75, 57);
            button8.TabIndex = 9;
            button8.Text = "Imp. CSV";
            button8.TextImageRelation = TextImageRelation.ImageAboveText;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.AutoSize = true;
            button9.Image = Properties.Resources.json_download_32px;
            button9.Location = new Point(468, 19);
            button9.Name = "button9";
            button9.Size = new Size(75, 57);
            button9.TabIndex = 8;
            button9.Text = "Exp. JSON";
            button9.TextImageRelation = TextImageRelation.ImageAboveText;
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.AutoSize = true;
            button10.Image = Properties.Resources.export_csv_32px;
            button10.Location = new Point(387, 19);
            button10.Name = "button10";
            button10.Size = new Size(75, 57);
            button10.TabIndex = 7;
            button10.Text = "Exp. CSV";
            button10.TextImageRelation = TextImageRelation.ImageAboveText;
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.AutoSize = true;
            button11.Image = Properties.Resources.book_32px;
            button11.Location = new Point(306, 19);
            button11.Name = "button11";
            button11.Size = new Size(75, 57);
            button11.TabIndex = 6;
            button11.Text = "Adicionar";
            button11.TextImageRelation = TextImageRelation.ImageAboveText;
            button11.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 48);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(39, 23);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 51);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 4;
            label5.Text = "Pgs";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(49, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(62, 23);
            textBox2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 51);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 2;
            label7.Text = "Cód";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(49, 19);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(246, 23);
            textBox3.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 22);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 0;
            label8.Text = "Livro";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(233, 48);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(62, 23);
            textBox4.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(194, 51);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 10;
            label9.Text = "Valor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 446);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Biblioteca";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBox2;
        private TextBox txbSenha;
        private Label label3;
        private TextBox txbLogin;
        private Label label2;
        private TextBox txbNome;
        private Label label1;
        private Button btnAdicionar;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn Senha;
        private Button button3;
        private Button button2;
        private Button button1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label6;
        private GroupBox groupBox6;
        private TextBox textBox4;
        private Label label9;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private GroupBox groupBox5;
        private DataGridView dataGridView2;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private Label label4;
    }
}