using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Image_Processing
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed, imageA, imageB, image_subtracted, effects;
        Color pickedColor;

        VideoCaptureDevice vcd;
        FilterInfoCollection fic;

        private CancellationTokenSource cancellationTokenSource;
        private Thread backgroundThread;

        int videoEffectsIndex = 0;
        String[] videoEffects =
        {
            "Subtract",
            "Duplicate",
            "GrayScale",
            "Invert",
            "Sepia"
        };

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;

            InitializeVideoCameras();
            InitializePart2();
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource?.Cancel();

            if (vcd != null && vcd.IsRunning)
            {
                stopCamera();
            }

            if (backgroundThread != null && backgroundThread.IsAlive)
            {
                if (!backgroundThread.Join(1000))
                {
                    backgroundThread.Abort();
                }
            }
        }

        public void InitializeVideoCameras()
        {
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            vcd = new VideoCaptureDevice();
            foreach (FilterInfo dev in fic)
            {
                comboBox1.Items.Add(dev.Name);
                comboBox1.SelectedIndex = 0;
            }
        }

        public void reloadImages()
        {
            picture_orig.Image = loaded;
            picture_result.Image = processed;
            pictureBox1.Image = imageA;
            pictureBox2.Image = imageB;
        }

        public void InitializePart2()
        {
            foreach (String s in videoEffects)
            {
                comboBox2.Items.Add(s);
            }
            comboBox2.SelectedIndex = 0;

        }


        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var test = Image.FromFile(open.FileName))
                    {
                        loaded = new Bitmap(test);
                    }
                    reloadImages();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The selected file is not a valid image.\n\n" + ex.Message,
                                    "Invalid File",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new() { Filter = "JPEG Image|*.jpg" };
            if (save.ShowDialog() == DialogResult.OK)
                processed.Save(save.FileName);
        }

        public void ImageFilters(int type_filter)
        {
            switch (type_filter)
            {
                case 0:
                    processed = ImageProcessing.Duplicate(loaded);
                    break;
                case 1:
                    processed = ImageProcessing.Grayscale(loaded);
                    break;
                case 2:
                    processed = ImageProcessing.Invert(loaded);
                    break;
                case 3:
                    processed = Histogram.DrawHistogram(loaded, picture_result.Size);
                    break;
                case 4:
                    processed = ImageProcessing.Sepia(loaded);
                    break;
            }
            picture_result.Image = processed;
        }

        public int indexreturn(object sender)
        {
            return filtersToolStripMenuItem.DropDownItems.IndexOf(sender as ToolStripItem);
        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageFilters(indexreturn(sender));
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageFilters(indexreturn(sender));
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageFilters(indexreturn(sender));
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageFilters(indexreturn(sender));
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageFilters(indexreturn(sender));
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                imageB = new Bitmap(open.FileName);
                reloadImages();
            }
        }

        private void btn_loadImageA_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                imageA = new Bitmap(open.FileName);
                reloadImages();
            }
        }

        private void btn_subtract_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = image_subtracted = ImageProcessing.Subtract(imageA, imageB, pickedColor);
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {

        }

        Color GetColorAt(Point location)
        {
            using (Bitmap pixelContainer = new Bitmap(1, 1))
            {
                using (Graphics g = Graphics.FromImage(pixelContainer))
                {
                    g.CopyFromScreen(location, Point.Empty, pixelContainer.Size);
                }
                return pixelContainer.GetPixel(0, 0);
            }
        }

        bool Buttonpressed = false;

        private void btnPickColor_MouseDown(object sender, MouseEventArgs e)
        {
            Buttonpressed = true;
            Cursor = Cursors.Cross;
        }

        private void btnPickColor_MouseUp(object sender, MouseEventArgs e)
        {
            Buttonpressed = false;
            Cursor = Cursors.Default;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            cancellationTokenSource = new CancellationTokenSource();

            backgroundThread = new Thread(() => BackgroundThread(cancellationTokenSource.Token))
            {
                IsBackground = true
            };
            backgroundThread.Start();
        }

        void BackgroundThread(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    if (Buttonpressed)
                    {
                        Point cursorPos = Cursor.Position;
                        pickedColor = GetColorAt(cursorPos);

                        if (!cancellationToken.IsCancellationRequested)
                        {
                            panel1.BackColor = pickedColor;
                            string hexvalue = ColorTranslator.ToHtml(pickedColor);
                            textBox1.Text = hexvalue;
                        }
                    }

                }
                catch (Exception)
                {
                    break;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void stopCamera()
        {
            if (vcd != null && vcd.IsRunning)
            {
                vcd.SignalToStop();
                vcd.WaitForStop();
            }
        }

        private void useCamera()
        {
            if (checkBox1.Checked)
            {
                stopCamera();
                vcd = new VideoCaptureDevice(fic[comboBox1.SelectedIndex].MonikerString);
                vcd.NewFrame += Vcd_NewFrame;
                vcd.Start();
            }
            else
            {
                stopCamera();
            }
        }

        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            imageA = (Bitmap)eventArgs.Frame.Clone();

        

            switch (videoEffectsIndex)
            {
                case 0:
                    effects = ImageProcessing.Subtract(imageA, imageB, pickedColor);
                    break;
                case 1:
                    effects = ImageProcessing.Duplicate(imageA);
                    break;
                case 2:
                    effects = ImageProcessing.Grayscale(imageA);
                    break;
                case 3:
                    effects = ImageProcessing.Invert(imageA);
                    break;
                case 4:
                    effects = ImageProcessing.Sepia(imageA);
                    break;

            }
            pictureBox3.Image = effects;
            pictureBox1.Image = imageA;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            useCamera();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            useCamera();
        }

        private void shrinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picture_result.Image = processed = ConvolutionMatrix.Shrink(loaded);
        }

        private void smoothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picture_result.Image = processed = ConvolutionMatrix.Smooth(loaded);
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picture_result.Image = processed = ConvolutionMatrix.GaussianBlur(loaded);
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picture_result.Image = processed = ConvolutionMatrix.Sharpen(loaded);
        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picture_result.Image = processed = ConvolutionMatrix.MeanRemoval(loaded);
        }

        private void embossingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picture_result.Image = processed = ConvolutionMatrix.EmbossLaplascian(loaded);
        }

        private void embossLaplascianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picture_result.Image = processed = ConvolutionMatrix.EmbossLaplascian(loaded);
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            videoEffectsIndex = comboBox2.SelectedIndex;
        }
    }
}