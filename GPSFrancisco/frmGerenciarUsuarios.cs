using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GPSFrancisco
{
    public partial class frmGerenciarUsuarios : Form
    {
        public frmGerenciarUsuarios()
        {
            InitializeComponent();
            //executando o metodo desabilitar campos
            desabilitarCampos();

        }

        public frmGerenciarUsuarios(string nome)
        {
            InitializeComponent();
            //executando o metodo desabilitar campos
            desabilitarCampos();
            txtb2usuario.Text = nome;

        }



        //desabilitar campos

        public void desabilitarCampos()
        {
            txtb2usuario.Enabled = false;
            txtb3senha.Enabled = false;
            txtb4validasenha.Enabled = false;
            btn2cadastrar.Enabled = false;
            btn3alterar.Enabled = false;
            btn4excluir.Enabled = false;
            btn6limpar.Enabled = false;
            btn1novo.Enabled = true;
            txtb3senha.Clear();
            txtb4validasenha.Clear();
        }

        //habilitar campos
        public void habilitarCampos()
        {
            txtb2usuario.Enabled = true;
            txtb3senha.Enabled = true;
            txtb4validasenha.Enabled = true;
            btn2cadastrar.Enabled = true;
            btn3alterar.Enabled = false;
            btn4excluir.Enabled = false;
            btn6limpar.Enabled = true;
            btn1novo.Enabled = false;
            txtb2usuario.Focus();
        }

        //Limpar campos
        public void limparcampos()
        {
            txtb2usuario.Clear();
            txtb3senha.Clear();
            txtb4validasenha.Clear();
            txtb2usuario.Focus();
        }

        //desabilitar campos cadastrar

        public void desabilitarcadastrarCampos()
        {
            txtb2usuario.Enabled = false;
            txtb3senha.Enabled = false;
            txtb4validasenha.Enabled = false;
            btn2cadastrar.Enabled = false;
            btn3alterar.Enabled = false;
            btn4excluir.Enabled = false;
            btn6limpar.Enabled = false;
            btn1novo.Enabled = true;
            txtb2usuario.Clear();
            txtb3senha.Clear();
            txtb4validasenha.Clear();
        }




        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btn1novo_Click(object sender, EventArgs e)
        {
            habilitarCampos();

        }

        private void btn2cadastrar_Click(object sender, EventArgs e)
        {
            if (txtb2usuario.Text.Equals("") || txtb3senha.Text.Equals("") || txtb4validasenha.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores", "Mensagem do sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                limparcampos();
            }
            else
            {
                if (txtb3senha.Text.Length < 12 || txtb3senha.Text.Length < 12)
                {
                    MessageBox.Show("Digite uma senha com 12 caracteres", "Mensagem do sistema",
                   MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);


                }
                else
                {

                    if (txtb3senha.Text.Equals(txtb4validasenha.Text))
                    {
                        if (cadastrarUsuarios(txtb2usuario.Text, txtb3senha.Text) == 1)
                        {
                            MessageBox.Show("Cadastrado com sucesso", "Mensagem do sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            desabilitarcadastrarCampos();
                            buscarUsuariosCadastrados();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar",
                                "mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                        }

                    }
                    else
                    {
                        MessageBox.Show("A senha não é igual", "Mensagem do sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                        txtb3senha.Clear();
                        txtb4validasenha.Clear();
                        txtb3senha.Focus();

                    }
                }
            }
        }

        private void txtb4validasenha_TextChanged(object sender, EventArgs e)
        {
            if (txtb4validasenha == txtb3senha)
            {
                btn1checar.Visible = true;
            }
            else
            {
                if (txtb3senha != txtb4validasenha && txtb4validasenha.Text.Length == 12)
                {
                    btnnaoverificado.Enabled = false;
                }
            }
        }
        //Criando o crud da janela usuario

        //metodo cadastrar usuario

        public int cadastrarUsuarios(string usuario, string senha)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbUsuarios(nome,senha)values(@nome,@senha);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = usuario;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 12).Value = senha;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        public void buscarUsuariosCadastrados()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbusuarios order by nome asc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            while (DR.Read())
            {
                cbbUsuariosCadastrados.Items.Add(DR.GetString(0));
            }

            Conexao.fecharConexao();
        }

        

        //metodo alterar usuario

        public void alterarusuarios(){
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbUsuarios set nome = @nome, senha = @senha,where codUsu = @codUsu";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            //comm.Parameters.Add("@nome",mysql).Value =;

            comm.Connection = Conexao.obterConexao();
            Conexao.fecharConexao();
        }

        //busca usuarios por código

        public void buscarUsuariosCodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm = new MySqlCommand();
            comm.CommandText = "select * from tbusuarios where codUsu = 1;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            txtb1codigo.Text = DR.GetString(0);
            txtb2usuario.Text = DR.GetString(1);
            txtb3senha.Text = DR.GetString(2);


            Conexao.fecharConexao();

            
            
        }


        private void cbbUsuariosCadastrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscarUsuariosCadastrados();
        }

        private void btn5pesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarUsuarios abrir = new frmPesquisarUsuarios();
            abrir.Show();
            this.Hide();
        }
    }

   
}
            
