using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ProjetoOvodePascoa
{
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxFecharCadasCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minCadastroCl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
           
                SqlConnection objconexao = new SqlConnection();
                 objconexao.ConnectionString = ProjetoOvodePascoa.Properties.Settings.Default.Stringprojovos;

                string comandoCadastrarClientes = "INSERT INTO TabCadclientes(cpf, nome, endereco, cep, cidade, estado, email, telefone, celular) values(@cpf,@nome, @endereco, @cep, @cidade,@estado,@email,@telefone,@celular)";
              
            try
            {
                SqlCommand c = new SqlCommand(comandoCadastrarClientes, objconexao);
                c.Parameters.Add(new SqlParameter("@cpf", this.mskdCPF.Text));
                c.Parameters.Add(new SqlParameter("@nome", this.txtNome.Text));
                c.Parameters.Add(new SqlParameter("@endereco", this.txtEnd.Text));
                c.Parameters.Add(new SqlParameter("@cep", this.maskedTextBox1.Text));
                c.Parameters.Add(new SqlParameter("@cidade", this.cmbCidade.Text));
                c.Parameters.Add(new SqlParameter("@estado", this.cmbEstado.Text));
                c.Parameters.Add(new SqlParameter("@email", this.textBox1Email.Text));
                c.Parameters.Add(new SqlParameter("@telefone", this.mskdTel.Text));
                c.Parameters.Add(new SqlParameter("@celular", this.msdkCel.Text));
                //string ordem = "select* from TabCadClientes order by nome asc";
                objconexao.Open();


                int retor = (int)c.ExecuteNonQuery();
                //c.ExecuteNonQuery();
                
                objconexao.Close();

                MessageBox.Show("Cadastrado com sucesso!");
                


            }
            catch (SqlException erro)
            {
                MessageBox.Show("\n\tErro de acesso ao banco de dados!\n\t" +  erro);
            }
            finally
            {
                txtNome.Text = string.Empty;
                mskdCPF.Text = string.Empty;
                msdkCel.Text = string.Empty;
                mskdTel.Text = string.Empty;
                mskdAniver.Text = string.Empty;
                textBox1Email.Text = string.Empty;
                maskedTextBox1.Text = string.Empty;
                cmbCidade.Text = string.Empty;
                cmbEstado.Text = string.Empty;
                txtEnd.Text = string.Empty;
                objconexao.Close();
            }


        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            mskdCPF.Text = string.Empty;
            msdkCel.Text = string.Empty;
            mskdTel.Text = string.Empty;
            mskdAniver.Text = string.Empty;
            textBox1Email.Text = string.Empty;
            maskedTextBox1.Text = string.Empty;
            cmbCidade.Text = string.Empty;
            cmbEstado.Text = string.Empty;
            txtEnd.Text = string.Empty;
        }

        private void button1Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mskdCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
