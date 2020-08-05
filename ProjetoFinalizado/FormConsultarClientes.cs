using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOvodePascoa
{
    public partial class FormConsultarClientes : Form
    {
        public FormConsultarClientes()
        {
            InitializeComponent();
        }

        private void pictureFecharConClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureMinConClientes_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormConsultarClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdprojovosDataSet.TabCadclientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tabCadclientesTableAdapter.Fill(this.bdprojovosDataSet.TabCadclientes);
            // TODO: esta linha de código carrega dados na tabela 'bdprojovosDataSet.TabCadclientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tabCadclientesTableAdapter.Fill(this.bdprojovosDataSet.TabCadclientes);
            // TODO: esta linha de código carrega dados na tabela 'bdprojovosDataSet.TabCadclientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tabCadclientesTableAdapter.Fill(this.bdprojovosDataSet.TabCadclientes);

        }

        private void groupBoxClientes_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
