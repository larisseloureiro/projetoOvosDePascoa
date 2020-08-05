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
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();
        }


        private void FormPedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdprojovosDataSet1.TabCadPedido'. Você pode movê-la ou removê-la conforme necessário.
            this.tabCadPedidoTableAdapter.Fill(this.bdprojovosDataSet1.TabCadPedido);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minPedidos_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
