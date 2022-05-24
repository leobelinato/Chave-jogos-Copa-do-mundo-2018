using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelaDaCopa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            GRUPOA tabela = new GRUPOA();
            tabela.ShowDialog();
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            GRUPOBGAMBIS nome = new GRUPOBGAMBIS();
            nome.ShowDialog();
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            GRUPOCcs tabela = new GRUPOCcs();
            tabela.ShowDialog();
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            GRUPOD nome = new GRUPOD();
            nome.ShowDialog();
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            GRUPOE nome = new GRUPOE();
            nome.ShowDialog();
        }

        private void btn_f_Click(object sender, EventArgs e)
        {
            GRUPOF nome = new GRUPOF();
            nome.ShowDialog();
        }

        private void btn_g_Click(object sender, EventArgs e)
        {
            GRUPOG nome = new GRUPOG();
            nome.ShowDialog();
        }

        private void btn_h_Click(object sender, EventArgs e)
        {
            GRUPOH nome = new GRUPOH();
            nome.ShowDialog();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_creditos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvedor:\n\nLeonardo Belinato");

        }
    }
}
