namespace GPSFrancisco
{
    partial class frmPesquisarUsuarios
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
            this.gpb1Pesquisarusuarios = new System.Windows.Forms.GroupBox();
            this.lstPesquisar = new System.Windows.Forms.ListBox();
            this.btn1Pesquisar = new System.Windows.Forms.Button();
            this.btn2Limparcampos = new System.Windows.Forms.Button();
            this.rb2Nome = new System.Windows.Forms.RadioButton();
            this.lbl1Descricao = new System.Windows.Forms.Label();
            this.txtb1Descricao = new System.Windows.Forms.TextBox();
            this.rb1Codigo = new System.Windows.Forms.RadioButton();
            this.gpb1Pesquisarusuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb1Pesquisarusuarios
            // 
            this.gpb1Pesquisarusuarios.Controls.Add(this.lstPesquisar);
            this.gpb1Pesquisarusuarios.Controls.Add(this.btn1Pesquisar);
            this.gpb1Pesquisarusuarios.Controls.Add(this.btn2Limparcampos);
            this.gpb1Pesquisarusuarios.Controls.Add(this.rb2Nome);
            this.gpb1Pesquisarusuarios.Controls.Add(this.lbl1Descricao);
            this.gpb1Pesquisarusuarios.Controls.Add(this.txtb1Descricao);
            this.gpb1Pesquisarusuarios.Controls.Add(this.rb1Codigo);
            this.gpb1Pesquisarusuarios.Location = new System.Drawing.Point(24, 25);
            this.gpb1Pesquisarusuarios.Name = "gpb1Pesquisarusuarios";
            this.gpb1Pesquisarusuarios.Size = new System.Drawing.Size(617, 265);
            this.gpb1Pesquisarusuarios.TabIndex = 0;
            this.gpb1Pesquisarusuarios.TabStop = false;
            this.gpb1Pesquisarusuarios.Text = "Pesquisar por";
            // 
            // lstPesquisar
            // 
            this.lstPesquisar.FormattingEnabled = true;
            this.lstPesquisar.ItemHeight = 16;
            this.lstPesquisar.Location = new System.Drawing.Point(24, 133);
            this.lstPesquisar.Name = "lstPesquisar";
            this.lstPesquisar.Size = new System.Drawing.Size(351, 100);
            this.lstPesquisar.TabIndex = 7;
            this.lstPesquisar.SelectedIndexChanged += new System.EventHandler(this.lstPesquisar_SelectedIndexChanged);
            // 
            // btn1Pesquisar
            // 
            this.btn1Pesquisar.Location = new System.Drawing.Point(444, 135);
            this.btn1Pesquisar.Name = "btn1Pesquisar";
            this.btn1Pesquisar.Size = new System.Drawing.Size(119, 80);
            this.btn1Pesquisar.TabIndex = 6;
            this.btn1Pesquisar.Text = "&Pesquisar";
            this.btn1Pesquisar.UseVisualStyleBackColor = true;
            this.btn1Pesquisar.Click += new System.EventHandler(this.btn1Pesquisar_Click);
            // 
            // btn2Limparcampos
            // 
            this.btn2Limparcampos.Location = new System.Drawing.Point(444, 38);
            this.btn2Limparcampos.Name = "btn2Limparcampos";
            this.btn2Limparcampos.Size = new System.Drawing.Size(119, 80);
            this.btn2Limparcampos.TabIndex = 5;
            this.btn2Limparcampos.Text = "&Limpar";
            this.btn2Limparcampos.UseVisualStyleBackColor = true;
            // 
            // rb2Nome
            // 
            this.rb2Nome.AutoSize = true;
            this.rb2Nome.Location = new System.Drawing.Point(265, 43);
            this.rb2Nome.Name = "rb2Nome";
            this.rb2Nome.Size = new System.Drawing.Size(62, 20);
            this.rb2Nome.TabIndex = 2;
            this.rb2Nome.Text = "Nome";
            this.rb2Nome.UseVisualStyleBackColor = true;
            // 
            // lbl1Descricao
            // 
            this.lbl1Descricao.AutoSize = true;
            this.lbl1Descricao.Location = new System.Drawing.Point(24, 77);
            this.lbl1Descricao.Name = "lbl1Descricao";
            this.lbl1Descricao.Size = new System.Drawing.Size(69, 16);
            this.lbl1Descricao.TabIndex = 3;
            this.lbl1Descricao.Text = "Descrição";
            // 
            // txtb1Descricao
            // 
            this.txtb1Descricao.Location = new System.Drawing.Point(27, 96);
            this.txtb1Descricao.MaxLength = 50;
            this.txtb1Descricao.Name = "txtb1Descricao";
            this.txtb1Descricao.Size = new System.Drawing.Size(317, 22);
            this.txtb1Descricao.TabIndex = 3;
            // 
            // rb1Codigo
            // 
            this.rb1Codigo.AutoSize = true;
            this.rb1Codigo.Location = new System.Drawing.Point(27, 43);
            this.rb1Codigo.Name = "rb1Codigo";
            this.rb1Codigo.Size = new System.Drawing.Size(69, 20);
            this.rb1Codigo.TabIndex = 1;
            this.rb1Codigo.Text = "Código";
            this.rb1Codigo.UseVisualStyleBackColor = true;
            // 
            // frmPesquisarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpb1Pesquisarusuarios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPesquisarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Usuarios";
            this.gpb1Pesquisarusuarios.ResumeLayout(false);
            this.gpb1Pesquisarusuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb1Pesquisarusuarios;
        private System.Windows.Forms.RadioButton rb2Nome;
        private System.Windows.Forms.RadioButton rb1Codigo;
        private System.Windows.Forms.Button btn1Pesquisar;
        private System.Windows.Forms.Button btn2Limparcampos;
        private System.Windows.Forms.Label lbl1Descricao;
        private System.Windows.Forms.TextBox txtb1Descricao;
        private System.Windows.Forms.ListBox lstPesquisar;
    }
}