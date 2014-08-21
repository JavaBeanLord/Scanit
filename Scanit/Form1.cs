using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


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
            #region ScrollBar Auto Load Values
            vScrollBar1.Minimum = 3;
            vScrollBar1.Maximum = 255;
            vScrollBar1.Value = 3;
            panel4.Location = new Point(608, -vScrollBar1.Value);
            #endregion
        }


        #region MainImageUpload
        private void button2_Click(object sender, EventArgs e)
        {
            string UsErNaMe = Environment.UserName;
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Set filter options and filter index.
            openFileDialog1.Filter = "JPEG Files (.jpg, jpeg, jpe, jfif)|*.jpg;*jpeg;*jpe;*jfif";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.InitialDirectory = (@"C:\Users\" +UsErNaMe + @"\Desktop");
            //if user clicks ok run commands
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //store local image location in string
                string imageLocal = openFileDialog1.FileName;
                //send local image location to settings for safe keeping
                Properties.Settings.Default.imageTemp = (imageLocal);

                //call on class file
                var upy = new Class1();
                upy.Hashgen();
                upy.sdkl();
                //set image URL
                string imageURL = ("http://localhost/Ebay/ZoneComputers/Images/" + Properties.Settings.Default.Hashgen + ".jpeg");
                Properties.Settings.Default.main_image_url = (imageURL);
             
                //grab image from webserver
                var request = WebRequest.Create(imageURL);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    //display image from webserver.
                    pictureBox1.BackgroundImage = Bitmap.FromStream(stream);
                }
            }
        }
        #endregion

        #region ImageScroll Scroll Tool For Side Bar
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //scroll image view up & down.
            panel4.Location = new Point(608, -vScrollBar1.Value);
        }
        #endregion

        #region image2Upload
        private void button3_Click(object sender, EventArgs e)
        {
            string UsErNaMe = Environment.UserName;
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Set filter options and filter index.
            openFileDialog1.Filter = "JPEG Files (.jpg, jpeg, jpe, jfif)|*.jpg;*jpeg;*jpe;*jfif";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.InitialDirectory = (@"C:\Users\" + UsErNaMe + @"\Desktop");
            //if user clicks ok run commands
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //store local image location in string
                string imageLocal = openFileDialog1.FileName;
                //send local image location to settings for safe keeping
                Properties.Settings.Default.imageTemp = (imageLocal);

                //call on class file
                var upy = new Class1();
                upy.Hashgen();
                upy.sdkl();
                //set image URL
                string imageURL = ("http://localhost/Ebay/ZoneComputers/Images/" + Properties.Settings.Default.Hashgen + ".jpeg");
                Properties.Settings.Default.image2_url = (imageURL);
               
                //grab image from webserver
                var request = WebRequest.Create(imageURL);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    //display image from webserver.
                    pictureBox2.BackgroundImage = Bitmap.FromStream(stream);
                }
            }
        }
        #endregion
        #region image3Upload
        private void button4_Click(object sender, EventArgs e)
        {
            string UsErNaMe = Environment.UserName;
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Set filter options and filter index.
            openFileDialog1.Filter = "JPEG Files (.jpg, jpeg, jpe, jfif)|*.jpg;*jpeg;*jpe;*jfif";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.InitialDirectory = (@"C:\Users\" + UsErNaMe + @"\Desktop");
            //if user clicks ok run commands
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //store local image location in string
                string imageLocal = openFileDialog1.FileName;
                //send local image location to settings for safe keeping
                Properties.Settings.Default.imageTemp = (imageLocal);

                //call on class file
                var upy = new Class1();
                upy.Hashgen();
                upy.sdkl();
                //set image URL
                string imageURL = ("http://localhost/Ebay/ZoneComputers/Images/" + Properties.Settings.Default.Hashgen + ".jpeg");
                Properties.Settings.Default.image3_url = (imageURL);
              
                //grab image from webserver
                var request = WebRequest.Create(imageURL);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    //display image from webserver.
                    pictureBox3.BackgroundImage = Bitmap.FromStream(stream);
                }
            }
        }
        #endregion
        #region image4Upload
        private void button5_Click(object sender, EventArgs e)
        {
            string UsErNaMe = Environment.UserName;
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Set filter options and filter index.
            openFileDialog1.Filter = "JPEG Files (.jpg, jpeg, jpe, jfif)|*.jpg;*jpeg;*jpe;*jfif";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.InitialDirectory = (@"C:\Users\" + UsErNaMe + @"\Desktop");
            //if user clicks ok run commands
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //store local image location in string
                string imageLocal = openFileDialog1.FileName;
                //send local image location to settings for safe keeping
                Properties.Settings.Default.imageTemp = (imageLocal);

                //call on class file
                var upy = new Class1();
                upy.Hashgen();
                upy.sdkl();
                //set image URL
                string imageURL = ("http://localhost/Ebay/ZoneComputers/Images/" + Properties.Settings.Default.Hashgen + ".jpeg");
                Properties.Settings.Default.image4_url = (imageURL);
              
                //grab image from webserver
                var request = WebRequest.Create(imageURL);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    //display image from webserver.
                    pictureBox4.BackgroundImage = Bitmap.FromStream(stream);
                }
            }
        }
        #endregion
        #region image5Upload
        private void button6_Click(object sender, EventArgs e)
        {
            string UsErNaMe = Environment.UserName;
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Set filter options and filter index.
            openFileDialog1.Filter = "JPEG Files (.jpg, jpeg, jpe, jfif)|*.jpg;*jpeg;*jpe;*jfif";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.InitialDirectory = (@"C:\Users\" + UsErNaMe + @"\Desktop");
            //if user clicks ok run commands
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //store local image location in string
                string imageLocal = openFileDialog1.FileName;
                //send local image location to settings for safe keeping
                Properties.Settings.Default.imageTemp = (imageLocal);

                //call on class file
                var upy = new Class1();
                upy.Hashgen();
                upy.sdkl();
                //set image URL
                string imageURL = ("http://localhost/Ebay/ZoneComputers/Images/" + Properties.Settings.Default.Hashgen + ".jpeg");
                Properties.Settings.Default.image5_url = (imageURL);
      
                //grab image from webserver
                var request = WebRequest.Create(imageURL);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    //display image from webserver.
                    pictureBox5.BackgroundImage = Bitmap.FromStream(stream);
                }
            }
        }
        #endregion
        #region imageHashKey
        private void button8_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.main_image_url))
            {
                imageHash.Text = (Properties.Settings.Default.main_image_url + 
                                  "|" + Properties.Settings.Default.image2_url +
                                  "|" + Properties.Settings.Default.image3_url +
                                  "|" + Properties.Settings.Default.image4_url + 
                                  "|" + Properties.Settings.Default.image5_url);
            }else { MessageBox.Show("Please Add Main Image...");}
        }
        #endregion


    }
}
