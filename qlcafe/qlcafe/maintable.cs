using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlcafe
{
    public partial class maintable : Form
    {
        public maintable()
        {
            InitializeComponent();
        }

        private void btnpay_Click(object sender, EventArgs e)
        {

        }

        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void tHongTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faccout f= new faccout();
            f.ShowDialog();
        }

        private void adiminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            a.ShowDialog();
        }
    }
}
