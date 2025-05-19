namespace GPSFrancisco
{
    partial class frmGerenciarUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarUsuarios));
            this.gpb1gerencia = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbUsuariosCadastrados = new System.Windows.Forms.ComboBox();
            this.btnnaoverificado = new System.Windows.Forms.Button();
            this.btn1checar = new System.Windows.Forms.Button();
            this.lbl4validasenha = new System.Windows.Forms.Label();
            this.lbl3senha = new System.Windows.Forms.Label();
            this.lbl2usuario = new System.Windows.Forms.Label();
            this.lbl1codigo = new System.Windows.Forms.Label();
            this.txtb3senha = new System.Windows.Forms.TextBox();
            this.txtb4validasenha = new System.Windows.Forms.TextBox();
            this.txtb2usuario = new System.Windows.Forms.TextBox();
            this.txtb1codigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pn1butoes = new System.Windows.Forms.Panel();
            this.btn7Voltar = new System.Windows.Forms.Button();
            this.btn6limpar = new System.Windows.Forms.Button();
            this.btn5pesquisar = new System.Windows.Forms.Button();
            this.btn4excluir = new System.Windows.Forms.Button();
            this.btn3alterar = new System.Windows.Forms.Button();
            this.btn2cadastrar = new System.Windows.Forms.Button();
            this.btn1novo = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.gpb1gerencia.SuspendLayout();
            this.pn1butoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb1gerencia
            // 
            this.gpb1gerencia.Controls.Add(this.label1);
            this.gpb1gerencia.Controls.Add(this.cbbUsuariosCadastrados);
            this.gpb1gerencia.Controls.Add(this.btnnaoverificado);
            this.gpb1gerencia.Controls.Add(this.btn1checar);
            this.gpb1gerencia.Controls.Add(this.lbl4validasenha);
            this.gpb1gerencia.Controls.Add(this.lbl3senha);
            this.gpb1gerencia.Controls.Add(this.lbl2usuario);
            this.gpb1gerencia.Controls.Add(this.lbl1codigo);
            this.gpb1gerencia.Controls.Add(this.txtb3senha);
            this.gpb1gerencia.Controls.Add(this.txtb4validasenha);
            this.gpb1gerencia.Controls.Add(this.txtb2usuario);
            this.gpb1gerencia.Controls.Add(this.txtb1codigo);
            this.gpb1gerencia.Location = new System.Drawing.Point(22, 29);
            this.gpb1gerencia.Name = "gpb1gerencia";
            this.gpb1gerencia.Size = new System.Drawing.Size(746, 301);
            this.gpb1gerencia.TabIndex = 0;
            this.gpb1gerencia.TabStop = false;
            this.gpb1gerencia.Text = "Informações do Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuários Cadastrados";
            // 
            // cbbUsuariosCadastrados
            // 
            this.cbbUsuariosCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUsuariosCadastrados.FormattingEnabled = true;
            this.cbbUsuariosCadastrados.Location = new System.Drawing.Point(525, 52);
            this.cbbUsuariosCadastrados.Name = "cbbUsuariosCadastrados";
            this.cbbUsuariosCadastrados.Size = new System.Drawing.Size(190, 24);
            this.cbbUsuariosCadastrados.TabIndex = 10;
            this.cbbUsuariosCadastrados.SelectedIndexChanged += new System.EventHandler(this.cbbUsuariosCadastrados_SelectedIndexChanged);
            // 
            // btnnaoverificado
            // 
            this.btnnaoverificado.FlatAppearance.BorderSize = 0;
            this.btnnaoverificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnaoverificado.Image = ((System.Drawing.Image)(resources.GetObject("btnnaoverificado.Image")));
            this.btnnaoverificado.Location = new System.Drawing.Point(462, 186);
            this.btnnaoverificado.Name = "btnnaoverificado";
            this.btnnaoverificado.Size = new System.Drawing.Size(37, 40);
            this.btnnaoverificado.TabIndex = 9;
            this.btnnaoverificado.UseVisualStyleBackColor = true;
            this.btnnaoverificado.Visible = false;
            // 
            // btn1checar
            // 
            this.btn1checar.FlatAppearance.BorderSize = 0;
            this.btn1checar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1checar.Image = ((System.Drawing.Image)(resources.GetObject("btn1checar.Image")));
            this.btn1checar.Location = new System.Drawing.Point(462, 194);
            this.btn1checar.Name = "btn1checar";
            this.btn1checar.Size = new System.Drawing.Size(37, 24);
            this.btn1checar.TabIndex = 8;
            this.btn1checar.UseVisualStyleBackColor = true;
            this.btn1checar.Visible = false;
            // 
            // lbl4validasenha
            // 
            this.lbl4validasenha.AutoSize = true;
            this.lbl4validasenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4validasenha.Location = new System.Drawing.Point(291, 182);
            this.lbl4validasenha.Name = "lbl4validasenha";
            this.lbl4validasenha.Size = new System.Drawing.Size(92, 16);
            this.lbl4validasenha.TabIndex = 7;
            this.lbl4validasenha.Text = "Validar Senha";
            // 
            // lbl3senha
            // 
            this.lbl3senha.AutoSize = true;
            this.lbl3senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3senha.Location = new System.Drawing.Point(23, 179);
            this.lbl3senha.Name = "lbl3senha";
            this.lbl3senha.Size = new System.Drawing.Size(46, 16);
            this.lbl3senha.TabIndex = 6;
            this.lbl3senha.Text = "Senha";
            // 
            // lbl2usuario
            // 
            this.lbl2usuario.AutoSize = true;
            this.lbl2usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2usuario.Location = new System.Drawing.Point(18, 98);
            this.lbl2usuario.Name = "lbl2usuario";
            this.lbl2usuario.Size = new System.Drawing.Size(54, 16);
            this.lbl2usuario.TabIndex = 5;
            this.lbl2usuario.Text = "Usuário";
            // 
            // lbl1codigo
            // 
            this.lbl1codigo.AutoSize = true;
            this.lbl1codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1codigo.Location = new System.Drawing.Point(18, 33);
            this.lbl1codigo.Name = "lbl1codigo";
            this.lbl1codigo.Size = new System.Drawing.Size(51, 16);
            this.lbl1codigo.TabIndex = 4;
            this.lbl1codigo.Text = "Código";
            // 
            // txtb3senha
            // 
            this.txtb3senha.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtb3senha.ForeColor = System.Drawing.Color.Black;
            this.txtb3senha.Location = new System.Drawing.Point(20, 198);
            this.txtb3senha.Name = "txtb3senha";
            this.txtb3senha.PasswordChar = 'l';
            this.txtb3senha.Size = new System.Drawing.Size(135, 20);
            this.txtb3senha.TabIndex = 3;
            // 
            // txtb4validasenha
            // 
            this.txtb4validasenha.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtb4validasenha.Location = new System.Drawing.Point(294, 198);
            this.txtb4validasenha.Name = "txtb4validasenha";
            this.txtb4validasenha.PasswordChar = 'l';
            this.txtb4validasenha.Size = new System.Drawing.Size(162, 20);
            this.txtb4validasenha.TabIndex = 2;
            this.txtb4validasenha.TextChanged += new System.EventHandler(this.txtb4validasenha_TextChanged);
            // 
            // txtb2usuario
            // 
            this.txtb2usuario.Location = new System.Drawing.Point(20, 117);
            this.txtb2usuario.Name = "txtb2usuario";
            this.txtb2usuario.Size = new System.Drawing.Size(135, 20);
            this.txtb2usuario.TabIndex = 1;
            // 
            // txtb1codigo
            // 
            this.txtb1codigo.Enabled = false;
            this.txtb1codigo.Location = new System.Drawing.Point(20, 52);
            this.txtb1codigo.Name = "txtb1codigo";
            this.txtb1codigo.Size = new System.Drawing.Size(100, 20);
            this.txtb1codigo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(774, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pn1butoes
            // 
            this.pn1butoes.Controls.Add(this.btn7Voltar);
            this.pn1butoes.Controls.Add(this.btn6limpar);
            this.pn1butoes.Controls.Add(this.btn5pesquisar);
            this.pn1butoes.Controls.Add(this.btn4excluir);
            this.pn1butoes.Controls.Add(this.btn3alterar);
            this.pn1butoes.Controls.Add(this.btn2cadastrar);
            this.pn1butoes.Controls.Add(this.btn1novo);
            this.pn1butoes.Location = new System.Drawing.Point(22, 410);
            this.pn1butoes.Name = "pn1butoes";
            this.pn1butoes.Size = new System.Drawing.Size(746, 118);
            this.pn1butoes.TabIndex = 2;
            // 
            // btn7Voltar
            // 
            this.btn7Voltar.Location = new System.Drawing.Point(639, 29);
            this.btn7Voltar.Name = "btn7Voltar";
            this.btn7Voltar.Size = new System.Drawing.Size(88, 53);
            this.btn7Voltar.TabIndex = 6;
            this.btn7Voltar.Text = "&Voltar";
            this.btn7Voltar.UseVisualStyleBackColor = true;
            this.btn7Voltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btn6limpar
            // 
            this.btn6limpar.Location = new System.Drawing.Point(536, 29);
            this.btn6limpar.Name = "btn6limpar";
            this.btn6limpar.Size = new System.Drawing.Size(88, 53);
            this.btn6limpar.TabIndex = 5;
            this.btn6limpar.Text = "&Limpar";
            this.btn6limpar.UseVisualStyleBackColor = true;
            // 
            // btn5pesquisar
            // 
            this.btn5pesquisar.Location = new System.Drawing.Point(429, 29);
            this.btn5pesquisar.Name = "btn5pesquisar";
            this.btn5pesquisar.Size = new System.Drawing.Size(88, 53);
            this.btn5pesquisar.TabIndex = 4;
            this.btn5pesquisar.Text = "&Pesquisar";
            this.btn5pesquisar.UseVisualStyleBackColor = true;
            this.btn5pesquisar.Click += new System.EventHandler(this.btn5pesquisar_Click);
            // 
            // btn4excluir
            // 
            this.btn4excluir.Location = new System.Drawing.Point(325, 29);
            this.btn4excluir.Name = "btn4excluir";
            this.btn4excluir.Size = new System.Drawing.Size(88, 53);
            this.btn4excluir.TabIndex = 3;
            this.btn4excluir.Text = "&Excluir";
            this.btn4excluir.UseVisualStyleBackColor = true;
            // 
            // btn3alterar
            // 
            this.btn3alterar.Location = new System.Drawing.Point(220, 29);
            this.btn3alterar.Name = "btn3alterar";
            this.btn3alterar.Size = new System.Drawing.Size(88, 53);
            this.btn3alterar.TabIndex = 2;
            this.btn3alterar.Text = "&Alterar";
            this.btn3alterar.UseVisualStyleBackColor = true;
            // 
            // btn2cadastrar
            // 
            this.btn2cadastrar.Location = new System.Drawing.Point(114, 29);
            this.btn2cadastrar.Name = "btn2cadastrar";
            this.btn2cadastrar.Size = new System.Drawing.Size(88, 53);
            this.btn2cadastrar.TabIndex = 1;
            this.btn2cadastrar.Text = "&Cadastrar";
            this.btn2cadastrar.UseVisualStyleBackColor = true;
            this.btn2cadastrar.Click += new System.EventHandler(this.btn2cadastrar_Click);
            // 
            // btn1novo
            // 
            this.btn1novo.Location = new System.Drawing.Point(11, 29);
            this.btn1novo.Name = "btn1novo";
            this.btn1novo.Size = new System.Drawing.Size(88, 53);
            this.btn1novo.TabIndex = 0;
            this.btn1novo.Text = "&Novo";
            this.btn1novo.UseVisualStyleBackColor = true;
            this.btn1novo.Click += new System.EventHandler(this.btn1novo_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // frmGerenciarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pn1butoes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpb1gerencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGerenciarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPSFrancisco - Gerenciar Usuários";
            this.gpb1gerencia.ResumeLayout(false);
            this.gpb1gerencia.PerformLayout();
            this.pn1butoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb1gerencia;
        private System.Windows.Forms.Label lbl2usuario;
        private System.Windows.Forms.Label lbl1codigo;
        private System.Windows.Forms.TextBox txtb3senha;
        private System.Windows.Forms.TextBox txtb4validasenha;
        private System.Windows.Forms.TextBox txtb2usuario;
        private System.Windows.Forms.TextBox txtb1codigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl4validasenha;
        private System.Windows.Forms.Label lbl3senha;
        private System.Windows.Forms.Panel pn1butoes;
        private System.Windows.Forms.Button btn1novo;
        private System.Windows.Forms.Button btn7Voltar;
        private System.Windows.Forms.Button btn6limpar;
        private System.Windows.Forms.Button btn5pesquisar;
        private System.Windows.Forms.Button btn4excluir;
        private System.Windows.Forms.Button btn3alterar;
        private System.Windows.Forms.Button btn2cadastrar;
        private System.Windows.Forms.Button btn1checar;
        private System.Windows.Forms.Button btnnaoverificado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbUsuariosCadastrados;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}