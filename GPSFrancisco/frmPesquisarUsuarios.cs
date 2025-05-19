using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFrancisco
{
    public partial class frmPesquisarUsuarios : Form
    {
        public frmPesquisarUsuarios()
        {
            InitializeComponent();
        }

       

        

        public void limparcampos()
        {
            txtb1Descricao.Clear();
            lstPesquisar.Items.Clear();
           rb1Codigo.Checked = false;
            rb2Nome.Checked = false;
            txtb1Descricao.Focus();
        }

        //pesquisar por codigo

        public void PesquisarPorCodigo(int codUsu)
        {
            MySqlCommand comm = new MySqlCommand();
            comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where codUsu = @codUsu;";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@codusu",MySqlDbType.Int32).Value = codUsu;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            lstPesquisar.Items.Add(DR.GetString(1));

            Conexao.fecharConexao();

            //metodo pesquisar por nome

           
        }

        public void PesquisarPorNome(string usuarios)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbusuarios where nome like '%" + usuarios + "%';";
            comm.CommandType = CommandType.Text;
   
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            while ( DR.Read() )
            {
                lstPesquisar.Items.Add(DR.GetString(1));

            }

            Conexao.fecharConexao();

           

        }

        private void btn1Pesquisar_Click(object sender, EventArgs e)
        {
            if (rb1Codigo.Checked || rb2Nome.Checked)
            {
                if (rb1Codigo.Checked && !txtb1Descricao.Text.Equals(""))
                    try
                    {

                        PesquisarPorCodigo(Convert.ToInt32(txtb1Descricao.Text));
                        txtb1Descricao.Focus();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Favor isnerir somente numeros inteiros");
                        txtb1Descricao.Clear();
                        txtb1Descricao.Focus();
                    }
                else if (rb2Nome.Checked && !txtb1Descricao.Text.Equals(""))
                {
                    PesquisarPorNome(txtb1Descricao.Text);
                    txtb1Descricao.Focus();
                }


            }
            else
            {
                MessageBox.Show("Favor inserir um código ou nome");
                txtb1Descricao.Focus();
            }

           

        }

        private void lstPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = lstPesquisar.SelectedItem.ToString();


            frmGerenciarUsuarios abrir = new frmGerenciarUsuarios(nome);
            abrir.Show();
            this.Hide();

        }
    }
}
