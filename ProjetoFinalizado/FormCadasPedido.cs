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

namespace ProjetoOvodePascoa
{
    public partial class FormCadasPedido : Form
    {
        public FormCadasPedido()
        {
            InitializeComponent();
        }

        
        private void FormCadasPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdprojovosDataSetOvos2.TabCadOvos'. Você pode movê-la ou removê-la conforme necessário.
            this.tabCadOvosTableAdapter1.Fill(this.bdprojovosDataSetOvos2.TabCadOvos);
            // TODO: esta linha de código carrega dados na tabela 'bdprojovosDataSet3.TabCadOvos'. Você pode movê-la ou removê-la conforme necessário.
            this.tabCadOvosTableAdapter.Fill(this.bdprojovosDataSet3.TabCadOvos);
            // TODO: esta linha de código carrega dados na tabela 'bdprojovosDataSet.TabCadclientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tabCadclientesTableAdapter.Fill(this.bdprojovosDataSet.TabCadclientes);

        }

        private void pictureBoxFecharLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            
            comboBox2nome.Text= string.Empty;
            //mskdCPF.Text = string.Empty;
           // msdkCel.Text= string.Empty;
            comboSabor.Text= string.Empty;
            comboBoxSabor2.Text= string.Empty;
            maskedTextBox1.Text= string.Empty;
            comboKG.Text= string.Empty;
            comboBox1.Text= string.Empty;
            txtObs.Text= string.Empty;
        }

        private void button1Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mskdCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
           
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            


         SqlConnection objconexao = new SqlConnection();
            objconexao.ConnectionString = ProjetoOvodePascoa.Properties.Settings.Default.Stringprojovos;
            objconexao.Open();
            
            
            string comandoCadastrarPedidos = "INSERT INTO TabCadPedido(cpf,nome,celular, sabor, sabor2, tamanho,quantidade,valor,data,observaçao) values(@cpf,@nome,@celular, @sabor, @sabor2, @tamanho,@quantidade,@valor,@data,@observaçao) ";                 

            try
             {
                 SqlCommand cc = new SqlCommand(comandoCadastrarPedidos, objconexao);

                cc.Parameters.Add(new SqlParameter("@cpf", this.comboBox2nome.Text));
                cc.Parameters.Add(new SqlParameter("@nome", this.comboBox2nome.Text));
                cc.Parameters.Add(new SqlParameter("@celular", this.comboBox2nome.Text));
                cc.Parameters.Add(new SqlParameter("@sabor", this.comboSabor.Text));
                 cc.Parameters.Add(new SqlParameter("@sabor2", this.comboBoxSabor2.Text));
                 cc.Parameters.Add(new SqlParameter("@tamanho", this.comboKG.Text));
                 cc.Parameters.Add(new SqlParameter("@quantidade", this.comboBox1.Text));
                 cc.Parameters.Add(new SqlParameter("@valor", this.maskedTextBox1.Text));
                cc.Parameters.Add(new SqlParameter("@data", this.maskedDataP.Text));
                cc.Parameters.Add(new SqlParameter("@observaçao", this.txtObs.Text));



                int retor = (int)cc.ExecuteNonQuery();
                //c.ExecuteNonQuery();

                objconexao.Close();

                 MessageBox.Show("Cadastrado com sucesso!");



             }
             catch (SqlException erro)
             {
                 MessageBox.Show("\n\tErro de acesso ao banco de dados!\n\t" + erro);
             }
             finally
             {
                 comboBox2nome.Text = string.Empty;
                 comboSabor.Text = string.Empty;
                 comboBoxSabor2.Text = string.Empty;
                 comboKG.Text = string.Empty;
                 comboBox1.Text = string.Empty;
                 maskedTextBox1.Text = string.Empty;
                 maskedDataP.Text = string.Empty;
                 txtObs.Text = string.Empty;


                 objconexao.Close();
             }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboSabor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxCadasPedido_Enter(object sender, EventArgs e)
        {

        }
    }
}
