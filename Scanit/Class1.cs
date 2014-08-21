using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;


namespace Scanit
{
    class Class1
    {

        public void Hashgen() //http://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings-in-c
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 50)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            Properties.Settings.Default.Hashgen = (result);
        }

        public void MkFileFTP()
        {
            WebRequest request = WebRequest.Create("ftp://localhost/Ebay/ZoneComputers/images");
            request.Method = WebRequestMethods.Ftp.MakeDirectory;
            request.Credentials = new NetworkCredential("user", "pass");
            using (var resp = (FtpWebResponse)request.GetResponse())
            {
                Console.WriteLine(resp.StatusCode);
            }
        }


        public void sdkl(){
            string imageLocalNess = Properties.Settings.Default.imageTemp;
            string HashGen = Properties.Settings.Default.Hashgen;
            string FTPurl = (Properties.Settings.Default.FTPURL);
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + FTPurl + "/Ebay/ZoneComputers/images/" + HashGen + ".jpeg" );
            request.Method = WebRequestMethods.Ftp.UploadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential("user", "pass");

            // Copy the contents of the file to the request stream.
            byte[] fileData = File.ReadAllBytes(imageLocalNess);

            request.ContentLength = fileData.Length;
            Stream reqStream = request.GetRequestStream();
            reqStream.Write(fileData, 0, fileData.Length);
            reqStream.Close();

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Console.WriteLine("Upload File Complete, status {0}", response.StatusDescription);

            response.Close();

        }

        public void pullImageFromFTP()
        {
            var request = WebRequest.Create("http://localhost/Ebay/ZoneComputers/Images/" + Properties.Settings.Default.Hashgen + ".jpeg");
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                //pictureBox1.BackgroundImage = Bitmap.FromStream(stream);
            }
        }
    }
}
