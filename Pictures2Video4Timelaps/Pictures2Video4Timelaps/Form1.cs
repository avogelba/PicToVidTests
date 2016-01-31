using AForge.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Picture2Video
// 
namespace Pictures2Video4Timelaps
{
    public partial class Form1 : Form
    {
        //private FolderBrowserDialog folderBrowserDialog1;
        //private string folderName;
        private int width, height, fps, secs, videoType; //0 = mp4 , 1 = avi;
        //List<String> filesFound = new List<String>();
        private string myFileName, myFolderName, myOutputName, myText;



        public Form1()
        {
            InitializeComponent();
           /* this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            // Set the help text description for the FolderBrowserDialog.
            this.folderBrowserDialog1.Description =
                "Select the directory that you want to use as the default.";

            // Do not allow the user to create new files via the FolderBrowserDialog.
            this.folderBrowserDialog1.ShowNewFolderButton = false;

            // Default to the My Documents folder.
            this.folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Personal;
            */
            StartApp();
        }

        public void StartApp()
        {
            videoType = 0;
            //width = 1024;
            width = 800;
            //height = 768;
            height =600;
            fps = 25;
            textBoxFPS.Text = fps.ToString();
            secs = 5;
            textBoxSec.Text = secs.ToString();
            buttonMakeVideo.Enabled = false;
            linkLabel1.Links.Add(0, 14, "https://github.com/avogelba");
            labelFPSHint.Text = "Frames/Sec";
            labelSecHint.Text = "Runtime in seconds/Frame";
            initialValues();
        }
        public void initialValues()
        {
            progressBar1.Value = 0;
            toolStripStatusLabel1.Text = "Ready...";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOutFormat.Checked == true)
            {
                checkBoxOutFormat.Text = "AVI";
                videoType = 1;
            }
            else
            {
                checkBoxOutFormat.Text = "MP4";
                videoType = 0;
            }
            initialValues();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar);
            //Console.WriteLine("Char: " + (int)e.KeyChar);
            //return;
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 13);
            initialValues();

        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int parsedInt = 0;
                if (Int32.TryParse(textBoxHNew.Text, out parsedInt))
                {
                    if (parsedInt > 0 && parsedInt < 1080)
                    {
                        Bitmap imageRead = Bitmap.FromFile(myFileName) as Bitmap;
                        Bitmap imageReadResized = ResizeIt(imageRead, width, height, "");
                        textBoxHNew.Text = imageReadResized.Height.ToString();
                        textBoxWNew.Text = imageReadResized.Width.ToString();
                        width = imageReadResized.Width;
                        height = imageReadResized.Height;
                        if (width % 2 != 0)
                        {
                            width += 1;
                        }
                        if (height % 2 != 0)
                        {
                            height += 1;
                        }
                        imageRead.Dispose();
                        imageReadResized.Dispose();
                    }
                }
            }
            initialValues();
        }

        private void textBoxHightNew_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHightNew_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxWNew.BackColor = Color.Red;
            if (e.KeyCode == Keys.Enter)
            {
                int parsedInt = 0;
                if (Int32.TryParse(textBoxWNew.Text, out parsedInt))
                {
                    if (parsedInt > 0 )//&& parsedInt <= 1080)
                    {
                        Bitmap imageRead = Bitmap.FromFile(myFileName) as Bitmap;
                        Bitmap imageReadResized = ResizeIt(imageRead, parsedInt, height, "");
                        //textBoxHNew.Text = imageReadResized.Height.ToString();
                        //textBoxWNew.Text = imageReadResized.Width.ToString();
                        width = imageReadResized.Width;
                        height = imageReadResized.Height;
                        if (width % 2 != 0)
                        {
                            width += 1;
                        }
                        if (height % 2 != 0)
                        {
                            height += 1;
                        }
                        textBoxHNew.Text = height.ToString();
                        textBoxWNew.Text = width.ToString();
                        imageRead.Dispose();
                        imageReadResized.Dispose();
                        textBoxWNew.BackColor = Color.White;
                    }
                }
            }
            initialValues();
        }

        private void textBoxHightNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar);
            //Console.WriteLine("Char: " + (int)e.KeyChar);
            //return;
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 13);
            initialValues();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            initialValues();
        }

        private void textBoxFPS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 13);
            initialValues();
        }

        private void textBoxFPS_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxFPS.BackColor = Color.Red;
            labelFPSHint.Text = "Allowed values: 1 - 30";

            if (e.KeyCode == Keys.Enter)
            {
                int parsedInt = 0;
                if (Int32.TryParse(textBoxFPS.Text, out parsedInt))
                {
                    if (parsedInt > 0 && parsedInt <= 30)
                    {
                        fps = parsedInt;
                        textBoxFPS.BackColor = Color.White;
                        labelFPSHint.Text = "Frames/Sec";
                        
                    }
                }
            }
            initialValues();
        }

        private void textBoxSec_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxSec.BackColor = Color.Red;
            labelSecHint.Text = "Allowed values: 1 - 600";
            if (e.KeyCode == Keys.Enter)
            {
                int parsedInt = 0;
                if (Int32.TryParse(textBoxSec.Text, out parsedInt))
                {
                    if (parsedInt > 0 && parsedInt <= 600)
                    {
                        secs = parsedInt;
                        textBoxSec.BackColor = Color.White;
                        labelSecHint.Text = "Runtime in seconds/Frame";
                    }
                }
            }
            initialValues();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int width = 640;
            int height = 480;

            VideoFileWriter writer = new VideoFileWriter();
            writer.Open(myFolderName + "\\" + "test_video.avi", width, height, 25, VideoCodec.MPEG4, 1000000);

            Bitmap image = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(image);
            g.FillRectangle(Brushes.Black, 0, 0, width, height);
            Brush[] brushList = new Brush[] { Brushes.Green, Brushes.Red, Brushes.Yellow, Brushes.Pink, Brushes.LimeGreen };
            Random rnd = new Random();

            for (int i = 0; i < 250; i++)
            {
                int rndTmp = rnd.Next(1, 3);
                Application.DoEvents();
                g.FillRectangle(brushList[i % 5], (i % width) * 2, (i % height) * 0.5f, i % 30, i % 30);
                g.FillRectangle(brushList[i % 5], (i % width) * 2, (i % height) * 2, i % 30, i % 30);
                g.FillRectangle(brushList[i % 5], (i % width) * 0.5f, (i % height) * 2, i % 30, i % 30);
                g.Save();
                writer.WriteVideoFrame(image);
            }

            g.DrawString("(c) 2016 - Test Video", new System.Drawing.Font("Calibri", 30), Brushes.White, 80, 240);
            g.Save();
            for (int i = 0; i < 125; i++)
            {
                writer.WriteVideoFrame(image);
            }

            writer.Close();
       
    }


        private void textBoxSec_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 13);
            initialValues();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var files = new List<string>();
            /*
            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                
                 if (folderName == null)
                {
                    return;
                }
            }
            try {
                filesFound = Directory.GetFiles(folderName, "*.jpg", SearchOption.AllDirectories)
                    .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("INFO: Cannot enumerate file in folder: {0}. Error: {1}", folderName, ex.Message);
            }
            */
            initialValues();
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                myFileName = file.FileName;
                myFolderName = Path.GetDirectoryName(myFileName);
            }
                           
            //if ( filesFound.Count > 0)
            if (File.Exists(myFileName))
            {
                buttonMakeVideo.Enabled = true;
                //textBox1.Text = filesFound[0];
                textBox1.Text = myFileName;
                textBox1.Visible = true;
                //Bitmap imageRead = Bitmap.FromFile(filesFound[0]) as Bitmap;
                Bitmap imageRead = Bitmap.FromFile(myFileName) as Bitmap;
                textBoxHOriginal.Text = imageRead.Height.ToString();
                textBoxWOriginal.Text = imageRead.Width.ToString();
                
                Bitmap imageReadResized = ResizeIt(imageRead, width, height, "");
                 textBoxHNew.Text = imageReadResized.Height.ToString();
                textBoxWNew.Text = imageReadResized.Width.ToString();
                width = imageReadResized.Width;
                height = imageReadResized.Height;
      
                pictureBox1.Image = Image.FromFile(myFileName);
                imageRead.Dispose();
                imageReadResized.Dispose();
            }
            else
            {
                buttonMakeVideo.Enabled = false;
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {


            myOutputName = Path.GetFileName(myFileName) + ((videoType == 0) ? ".mp4" : ".avi");

            using (var videoWriter = new VideoFileWriter())
            {
                int maxI = 1, progrB=0;
                progrB = maxI * secs * fps;
                progressBar1.Maximum = progrB;
                progressBar1.Step = 1;
                progressBar1.Value = 0;
                toolStripStatusLabel1.Text = "Running...";

                /*
                Supported Formats:
                    Raw	        Raw (uncompressed) video.
	                MPEG2	    MPEG-2 part 2.
	                FLV1	    Flash Video (FLV) / Sorenson Spark / Sorenson H.263.
	                H263P	    H.263+ / H.263-1998 / H.263 version 2.
	                MSMPEG4v3	MPEG-4 part 2 Microsoft variant version 3.
	                MSMPEG4v2	MPEG-4 part 2 Microsoft variant version 2.
	                WMV2	    Windows Media Video 8.
	                WMV1	    Windows Media Video 7.
	                MPEG4	    MPEG-4 part 2.
	                Default	    Default video codec, which FFmpeg library selects for the specified file format.
                    missing : H264        
                */

                videoWriter.Open(myFolderName + "\\" + myOutputName, width, height, fps, ((videoType == 0) ? VideoCodec.MPEG2 : VideoCodec.MPEG4));
                //videoWriter.Open(myFolderName + "\\" + myOutputName, width, height, fps, ((videoType == 0) ? VideoCodec.H263P : VideoCodec.MPEG4));
                //Files
                //for (int i =0;i < filesFound.Count;i++)
                for (int i = 0; i < maxI; i++)
                {
                    //using (Bitmap image = Bitmap.FromFile(filesFound[i]) as Bitmap)
                    using (Bitmap image = Bitmap.FromFile(myFileName) as Bitmap)
                    {
                        if (textBoxWaterMark.Text != null)
                            myText = textBoxWaterMark.Text;
                        else
                            myText = "";
                        Bitmap imageResized = ResizeIt(image, width, height, myText);

                        //Seconds
                        for (int j = 0; j < secs; j++)
                        {
                            //Frames
                            for (int k = 0; k < fps; k++)
                            {
                                videoWriter.WriteVideoFrame(imageResized);
                                progressBar1.PerformStep();
                            }
                        }
                    }
                }
                videoWriter.Close();
                //progressBar1.Value = 0;
                toolStripStatusLabel1.Text = "Done";

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private static Image resizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }
    
    /*public class ImageProcessor
    {*/
    //public
        private Bitmap ResizeIt(Bitmap image, int newWidth, int newHeight, string message)
        {
            try
            {
                Bitmap newImage = new Bitmap(newWidth, Calculations(image.Width, image.Height, newWidth));

                using (Graphics gr = Graphics.FromImage(newImage))
                {
                    gr.SmoothingMode = SmoothingMode.AntiAlias;
                    gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    gr.DrawImage(image, new Rectangle(0, 0, newImage.Width, newImage.Height));

                    var myBrush = new SolidBrush(Color.FromArgb(70, 205, 205, 205));

                    double diagonal = Math.Sqrt(newImage.Width * newImage.Width + newImage.Height * newImage.Height);

                    Rectangle containerBox = new Rectangle();

                    containerBox.X = (int)(diagonal / 10);
                    Font stringFont = null; ;
                    StringFormat sf = null;
                    if (message.Length > 0)
                    {
                        float messageLength = (float)(diagonal / message.Length * 1);
                        containerBox.Y = -(int)(messageLength / 1.6);

                        stringFont = new Font("verdana", messageLength);

                        sf = new StringFormat();
                    }
                    float slope = (float)(Math.Atan2(newImage.Height, newImage.Width) * 180 / Math.PI);

                    gr.RotateTransform(slope);
                    if (message.Length > 0)
                    {
                        gr.DrawString(message, stringFont, myBrush, containerBox, sf);
                    }
                    return newImage;
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public int Calculations(decimal w1, decimal h1, int newWidth)
        {
            decimal heightC = 0;
            decimal ratio = 0;

            if (newWidth == w1)
            {
                return (int)h1;
            }
            else if (newWidth < w1)
            {
                ratio = w1 / newWidth;
                heightC = h1 / ratio;

                // return height.To<int>();
                return (int)heightC;
            }

            else if (w1 < newWidth)
            {
                ratio = newWidth / w1;
                heightC = h1 * ratio;
                //return height.To<int>();
                return (int)heightC;
            }

            //return height.To<int>();
            return (int)heightC;
        }

    }
}
