using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace ProjetoOvodePascoa
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        

        private void FormMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdprojovosDataSet2.TabCadOvos'. Você pode movê-la ou removê-la conforme necessário.
            this.tabCadOvosTableAdapter1.Fill(this.bdprojovosDataSet2.TabCadOvos);
            // TODO: esta linha de código carrega dados na tabela 'bdprojovosDataCardapio.TabCadOvos'. Você pode movê-la ou removê-la conforme necessário.
            this.tabCadOvosTableAdapter.Fill(this.bdprojovosDataCardapio.TabCadOvos);
            // TODO: esta linha de código carrega dados na tabela 'bdprojovosDataCardapio.TabCadOvos'. Você pode movê-la ou removê-la conforme necessário.
            this.tabCadOvosTableAdapter.Fill(this.bdprojovosDataCardapio.TabCadOvos);
            // TODO: esta linha de código carrega dados na tabela 'bdprojovosDataCardapio.TabCadOvos'. Você pode movê-la ou removê-la conforme necessário.
            this.tabCadOvosTableAdapter.Fill(this.bdprojovosDataCardapio.TabCadOvos);
            

        }

        private void bunifuFlatCadastroCl_Click(object sender, EventArgs e)
        {
            FormCadastroCliente formCadastrarCliente = new FormCadastroCliente();
            formCadastrarCliente.Show();
        }

        private void bunifuCadasPedido_Click(object sender, EventArgs e)
        {
            FormCadasPedido formCadasPedido = new FormCadasPedido();
            formCadasPedido.Show();
        }

        private void bunifuPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FormCadasOvo formCadasOvo = new FormCadasOvo();
            formCadasOvo.Show();
        }

        private void pctFecharMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            FormConsultarClientes formConsultarClientes = new FormConsultarClientes();
            formConsultarClientes.Show();
        }

        private void minMenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMinLogin_Click(object sender, EventArgs e)
        {
           
            this.WindowState = FormWindowState.Normal;
            picMinLogin.Visible = false;
            pctMaxMenu.Visible = true;

        }

        private void pctMaxMenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pctMaxMenu.Visible = false;
            picMinLogin.Visible = true;
        }

        private void button1Att_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void dataGridCardapio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            string conexao = ProjetoOvodePascoa.Properties.Settings.Default.Stringprojovos;
            SqlConnection objconexao = new SqlConnection(conexao);
            objconexao.Open();

            string consultasql = "select * from TabCadOvos sabor ";
            DataSet objdataset = new DataSet();
            SqlDataAdapter objdados = new SqlDataAdapter(consultasql,objconexao);

            objdados.Fill(objdataset);

            dataGridCardapio.DataSource = objdataset.Tables[0];

        }
    }
}
