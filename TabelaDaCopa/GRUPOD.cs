using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TabelaDaCopa
{
    public partial class GRUPOD : TabelaDaCopa.GRUPOA
    {
        public GRUPOD()
        {
            InitializeComponent();
        }

        private void GRUPOD_Load(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
