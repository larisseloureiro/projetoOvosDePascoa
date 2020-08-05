using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace ProjetoOvodePascoa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            string strconexao = ProjetoOvodePascoa.Properties.Settings.Default.Stringprojovos;

            SqlConnection objconexao = new SqlConnection();
            objconexao.ConnectionString = strconexao;
            objconexao.Open();

            string comandovalog = "select count(*) from TabLogSenha where Login ='" + textBoxUsuario.Text + "' and Senha= '" + textBoxSenha.Text + "' ";
            SqlCommand objcomando = new SqlCommand(comandovalog, objconexao);
            int valid = (int)objcomando.ExecuteScalar();
            if (valid == 1)
            {
                MessageBox.Show("Usuario conectado !");
                FormMenu formMenu = new FormMenu();
                formMenu.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos !");

            }

            objconexao.Close();

        }

        private void minLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBoxUsuario_Leave(object sender, EventArgs e)
        {

            if (textBoxUsuario.Text == "")
            {
                textBoxUsuario.Text = "USUÁRIO";
                textBoxUsuario.ForeColor = Color.DimGray;
            }

        }

        private void textBoxUsuario_Enter(object sender, EventArgs e)
        {

            if (textBoxUsuario.Text == "USUÁRIO")
            {
                textBoxUsuario.Text = "";
                textBoxUsuario.ForeColor = Color.DimGray;
            }

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_Leave(object sender, EventArgs e)
        {
            if (textBoxSenha.Text == "")
            {
                textBoxSenha.Text = "SENHA";
                textBoxSenha.ForeColor = Color.DimGray;
                textBoxSenha.UseSystemPasswordChar = false;
            }
        }

        private void textBoxSenha_Enter(object sender, EventArgs e)
        {
            if (textBoxSenha.Text == "SENHA")
            {
                textBoxSenha.Text = "";
                textBoxSenha.ForeColor = Color.DimGray;
                textBoxSenha.UseSystemPasswordChar = true;
            }
        }

        private void groupBoxLogin_Enter(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = string.Empty;
            textBoxSenha.Text = string.Empty;

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCadasUsuario_Click(object sender, EventArgs e)
        {
            try
            { 
            string strconexao = ProjetoOvodePascoa.Properties.Settings.Default.Stringprojovos;

            SqlConnection objconexao = new SqlConnection();
            objconexao.ConnectionString = strconexao;
            objconexao.Open();

            string comandocadastro = "insert into TabLogsenha (Login,Senha) values ('" + textBoxUsuario.Text + "','" + textBoxSenha.Text + "' )";
            SqlCommand objcomando = new SqlCommand(comandocadastro, objconexao);

            int valid = (int)objcomando.ExecuteNonQuery();
            if (valid >= 1)
            {
                MessageBox.Show("Usuario cadastrado !");

            }
            else
            {
                MessageBox.Show("Usuário não cadastrado !");

            }
                objconexao.Close();
        }
       catch(Exception) 
            {
                MessageBox.Show("Erro ao acessar o banco de dados !");
            }
        }
    }
}
