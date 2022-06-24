using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LopPTUD2022_Sang
{
    public partial class frmMAIN : Form
    {
        public frmMAIN()
        {
            InitializeComponent();
        }

        private void hệThôgsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMAIN_Load(object sender, EventArgs e)
        {

        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status1.Text = "Hello World!";
            Form1 f = new Form1();
            f.ShowDialog();
            Status1.Text = "San sang nhan lenh";
        }

        private void tínhTổngSốChẵnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ltCoban f = new ltCoban();
            f.Show();
        }

        private void kếtThúcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngNhậpLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form1 f = new Form1();
            f.Show();
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Status2.Text = System.DateTime.Now.ToString();

        }

        private void danhMụcHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDMHH f = new FrmDMHH();
            f.Show();
        }
    }
}
