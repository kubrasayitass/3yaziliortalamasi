using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_yazılı_ortalaması
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void txtNot1_Click(object sender, EventArgs e)
        {

        }

        private void lblOrtalama_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int not1, not2, not3, sonuc;

            not1 = Convert.ToInt32(txtNot1.Text);
            not2 = Convert.ToInt32(txtNot2.Text);
            not3 = Convert.ToInt32(txtNot3.Text);

            sonuc = (not1 + not2 + not3) / 3;

            lblOrtalama.Text = sonuc.ToString();





        }
    }
}
