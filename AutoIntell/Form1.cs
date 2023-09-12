using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoIntell
{
    public partial class Form1 : Form
    {
        private VideoCapture capture;
        private Mat frame;
        private Bitmap image;
        private bool isCapturing = false;

        public Form1()
        {
            InitializeComponent();

            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);

            if (!capture.IsOpened())
            {
                MessageBox.Show("Camera not found!");
                Environment.Exit(0);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!isCapturing)
            {
                isCapturing = true;
                button1.Text = "Capture Image";
                await CaptureCameraFeedAsync();
            }
            else
            {
                isCapturing = false;
                button1.Text = "Retake Image";
            }
        }

        private async Task CaptureCameraFeedAsync()
        {
            while (isCapturing)
            {
                if (capture.IsOpened())
                {
                    capture.Read(frame);
                    image = BitmapConverter.ToBitmap(frame);
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }
                    pictureBox1.Image = image;
                    await Task.Delay(1); // Adjust the delay as needed for the frame rate
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // Do not start capturing when the form loads
        }
    }
}
