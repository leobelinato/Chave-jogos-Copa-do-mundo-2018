using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TabelaDaCopa
{
    public partial class GRUPOH : TabelaDaCopa.GRUPOA
    {
        public GRUPOH()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
