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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("ff")){

            }else{
                label1.Text = ("Could Not Find Item..");
                DialogResult dialogResult = MessageBox.Show("Could not find item. " + "\n" + 
                                                            "Would you like to add item to database?",
                                                            "Core Help", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    tabControl1.SelectTab(tabPage2);
                    label1.Text = ("Scan Item");
                }
                else if (dialogResult == DialogResult.No)
                {
                    label1.Text = ("Scan Item");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = ("Scan Item");
        }

     
    }
}
