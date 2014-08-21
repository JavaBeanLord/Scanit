using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scanit
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }


        #region FTPLink Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            string ftpurl = (textBox1.Text);
            Properties.Settings.Default.FTPURL = (ftpurl);
            textBox1.Text = (ftpurl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ftpurl = ("");
            Properties.Settings.Default.FTPURL = (ftpurl);
            textBox1.Text = (ftpurl);
        }

        #endregion

        private void Administrator_Load(object sender, EventArgs e)
        {
            textBox1.Text = (Properties.Settings.Default.FTPURL);
        }
    }
}
