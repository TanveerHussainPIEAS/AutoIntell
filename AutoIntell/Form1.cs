using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoIntell
{
    public partial class Form1 : Form
    {
        private VideoCapture capture;
        private Mat frame;
        private Bitmap image;
        private Bitmap capturedImage;
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

                // Store the captured image
                capturedImage = (Bitmap)image.Clone();

                if (capturedImage != null)
                {
                    // Check the width and height of capturedImage
                    int width = capturedImage.Width;
                    int height = capturedImage.Height;

                    // Display width and height in labels
                    labelWidth.Text = $"Width: {width}";
                    labelHeight.Text = $"Height: {height}";
                }
                else
                {
                    // If the captured image is null, hide the labels
                    labelWidth.Text = "";
                    labelHeight.Text = " ";
                }
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


        private void importButton_Click(object sender, EventArgs e)
        {
            // Open a file dialog to select an image
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the selected image
                    capturedImage = new Bitmap(openFileDialog.FileName);

                    // Display the image in the PictureBox
                    pictureBox1.Image = capturedImage;

                    // Check the width and height of the imported image
                    int width = capturedImage.Width;
                    int height = capturedImage.Height;

                    // Display width and height in labels
                    labelWidth.Text = $"Width: {width}";
                    labelHeight.Text = $"Height: {height}";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Do not start capturing when the form loads
        }
    }
}
