using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class frmQuanLyKho : Form
    {
        public frmQuanLyKho()
        {
            InitializeComponent();
        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapKho f = new frmNhapKho();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXuatKho f = new frmXuatKho();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTonKho f = new frmTonKho();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
