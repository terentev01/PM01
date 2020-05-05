using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6sem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
                b.Navigate(open.FileName);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OProg OP = new OProg();
            OP.Show();
        }

        private void X_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Y_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(X.Text);
            int y = Convert.ToInt32(Y.Text);

            if (6 > x && x > -6 && 0 > y && y > -6 || 0>x&&x>-6&&6>y&&y>0)
            {
                Res.Text ="В области" ;
            }
            
            else
            {
                Res.Text = "Вне области"; 
            }
        }
    }
}
