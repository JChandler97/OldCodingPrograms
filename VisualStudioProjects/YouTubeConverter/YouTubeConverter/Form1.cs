using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace YouTubeConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string url = textBox1.Text;
            // Put into method later
            /* var youtube = YouTube.Default;
            var video = youtube.GetVideo(); */
            if (url.Contains("youtube.com/watch?v=") || url.Contains("youtu.be/"))
            {
                labelCheck.ForeColor = Color.Green;
                labelCheck.MaximumSize = new Size(200, 0);
                labelCheck.Text = "Link works! Proceed to download!";
                labelCheck.Visible = true;
                button2.Visible = true;
            }
            else
            {
                labelCheck.ForeColor = Color.Red;
                labelCheck.MaximumSize = new Size(100, 0);
                labelCheck.AutoSize = true;
                labelCheck.Text = "Link does not work! Please try again!";
                labelCheck.Visible = true;
                button2.Visible = false;
            }

        }

        private void folderPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.label2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string url = textBox1.Text;
            axShockwaveFlash1.Visible = true;
            label1.Visible = true;
            // https://youtu.be/62ZidB9RgXs dis a good song doe
            if (url.Contains("watch?v="))
            {
                string youtubeUrl = url.Replace("watch?v=", "v/");
                axShockwaveFlash1.Movie = youtubeUrl;
                axShockwaveFlash1.Play();
            }

            if (url.Contains("youtu.be/"))
            {
                string youtubeUrl = url.Replace("youtu.be/", "www.youtube.com/v/");
                axShockwaveFlash1.Movie = youtubeUrl;
                axShockwaveFlash1.Play();
            }
        }
    }
}
