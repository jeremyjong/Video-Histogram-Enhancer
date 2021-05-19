using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Threading;
using System.IO;


namespace VideoEnhancer
{
    public partial class Form1 : Form
    {             


        string input_path = "";
        string output_path = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_browse_input_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                input_path = folderBrowserDialog1.SelectedPath;
                textBox1.Text = input_path;
            }
        }

        private void btn_browse_output_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                input_path = folderBrowserDialog1.SelectedPath;
                textBox2.Text = input_path;
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            VideoCapture vcap = new VideoCapture(textBox6.Text);

                while (vcap.IsOpened())
            {
                Mat mat = new Mat();
                Mat mat_out = new Mat();
                Mat mat_concat = new Mat();

                if (vcap.Read(mat))
                {
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();//Memory release
                    }

                    if (mat.IsContinuous())
                    {

                        using (CLAHE clahe = Cv2.CreateCLAHE())
                        {
                            clahe.ClipLimit = 20;
                            clahe.TilesGridSize = new OpenCvSharp.Size(Int32.Parse(textBox3.Text), Int32.Parse(textBox3.Text));

                            if (mat.Type() != MatType.CV_8UC1)
                            {
                                Cv2.CvtColor(mat, mat, ColorConversionCodes.RGB2GRAY);
                            }

                            clahe.Apply(mat, mat_out);
                            Cv2.HConcat(mat, mat_out, mat_concat);
                            Cv2.MedianBlur(mat_concat, mat_concat, Int32.Parse(textBox5.Text));
                        }


                        pictureBox1.Image = BitmapConverter.ToBitmap(mat_concat);
                    }
                    else
                    {
                        break;
                    }
                    Application.DoEvents(); // 非推奨
                }
                else
                {
                    break;
                }
                Thread.Sleep((int)(100 / vcap.Fps));

                mat.Dispose();//Memory release
                mat_out.Dispose();

            }
        }

        private void btn_browse_inputfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = fdlg.FileName;
            }
        }

        private void btn_execute_all_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && textBox2.TextLength != 0)
            {
                string[] fileEntries = Directory.GetFiles(textBox1.Text);
                foreach (string fileName in fileEntries)
                {
                    VideoCapture vcap = new VideoCapture(fileName);
                    VideoWriter vw = new VideoWriter(textBox2 + "\\" + Path.GetFileNameWithoutExtension(fileName) + "_output.avi", FourCC.MJPG, vcap.Fps, new OpenCvSharp.Size(vcap.FrameWidth, vcap.FrameHeight));

                    while (vcap.IsOpened())
                    {
                        Mat mat = new Mat();
                        Mat mat_out = new Mat();
                        Mat mat_concat = new Mat();
                        Mat mat_save = new Mat();

                        if (vcap.Read(mat))
                        {
                            if (pictureBox1.Image != null)
                            {
                                pictureBox1.Image.Dispose();//Memory release
                            }

                            if (mat.IsContinuous())
                            {

                                using (CLAHE clahe = Cv2.CreateCLAHE())
                                {
                                    clahe.ClipLimit = 20;
                                    clahe.TilesGridSize = new OpenCvSharp.Size(Int32.Parse(textBox3.Text), Int32.Parse(textBox3.Text));

                                    if (mat.Type() != MatType.CV_8UC1)
                                    {
                                        Cv2.CvtColor(mat, mat, ColorConversionCodes.RGB2GRAY);
                                    }

                                    clahe.Apply(mat, mat_out);
                                    Cv2.MedianBlur(mat_out, mat_out, Int32.Parse(textBox5.Text));
                                    Cv2.HConcat(mat, mat_out, mat_concat);
                                    


                                    //Cv2.CvtColor(mat_out, mat_save, ColorConversionCodes.GRAY2BGR);
                                    vw.Write(mat_save);
                                    
                                }


                                pictureBox1.Image = BitmapConverter.ToBitmap(mat_concat);
                            }
                            else
                            {
                                break;
                            }
                            Application.DoEvents(); // 非推奨
                        }
                        else
                        {
                            break;
                        }
                        //Thread.Sleep((int)(100 / vcap.Fps));

                        mat.Dispose();//Memory release
                        mat_out.Dispose();
                    }


                }
            }
        }
    }
}
