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
    public partial class FormCadasOvo : Form
    {
        public FormCadasOvo()
        {
            InitializeComponent();
        }

        private void pictureBoxFecharCadasOvo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctMinCadasOvo_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxSabor.Text = string.Empty;
            textBoxChoc.Text = string.Empty;
            textBoxKKg.Text = string.Empty;
            maskedTextBox1.Text = string.Empty;
        }

        private void button1Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection objconexao = new SqlConnection();
            objconexao.ConnectionString = ProjetoOvodePascoa.Properties.Settings.Default.Stringprojovos;

            string comandoCadastrarOvos = "INSERT INTO TabCadOvos(sabor, chocolate, preço, kg) values(@sabor, @chocolate, @preço, @kg)";

            try
            {
                SqlCommand c = new SqlCommand(comandoCadastrarOvos, objconexao);

                
                c.Parameters.Add(new SqlParameter("@sabor", this.textBoxSabor.Text));
                c.Parameters.Add(new SqlParameter("@chocolate", this.textBoxChoc.Text));
                c.Parameters.Add(new SqlParameter("@preço", this.maskedTextBox1.Text));
                c.Parameters.Add(new SqlParameter("@kg", this.textBoxKKg.Text));
                

                objconexao.Open();


                

                int retor = (int)c.ExecuteNonQuery();
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
                
                textBoxSabor.Text = string.Empty;
                textBoxChoc.Text = string.Empty;
                maskedTextBox1.Text = string.Empty;
                textBoxKKg.Text = string.Empty;
                
                objconexao.Close();
            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /* BOTAO RESTAURAR E MAXIMIZAR
         private void pctRestaurarCadasOvos_Click(object sender, EventArgs e)
         {
             this.WindowState = FormWindowState.Normal;
             pctRestaurarCadasOvos.Visible = false;
             pctMaxCadasOvo.Visible = true;
         }

         private void pctMaxCadasOvo_Click(object sender, EventArgs e)
         {
              this.WindowState = FormWindowState.Maximized;
             pctMaxCadasOvo.Visible = false;
             pctRestaurarCadasOvos.Visible = true;
         }*/
    }
}
