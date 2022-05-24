using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TabelaDaCopa
{
    public partial class GRUPOCcs : TabelaDaCopa.GRUPOA
    {
        public GRUPOCcs()
        {
            InitializeComponent();
        }

        private void GRUPOCcs_Load(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
