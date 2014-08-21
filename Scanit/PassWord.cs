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
    public partial class PassWord : Form
    {
        public PassWord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Type Your Password");
            }
            else if (textBox1.Text == ("password"))
            {
                Administrator AdminForm = new Administrator();
                AdminForm.Show();
                Close();
            }
            else if (textBox1.Text == ("sandbox"))
            {
                Sandbox SandBoX = new Sandbox();
                SandBoX.Show();
                Close();
            }

          else { MessageBox.Show("Wrong Password" + "\n" + "Please Try Again"); }
        }
    }
}
