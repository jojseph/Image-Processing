
using AForge.Video;
using AForge.Video.DirectShow;
using MaterialSkin.Controls;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Image_Processing
{
    public partial class Form1 : MaterialForm
    {
        Bitmap loaded, processed, imageA, imageB, image_subtracted, effects;
        Color pickedColor;
        VideoCaptureDevice vcd;
        FilterInfoCollection fic;
        public Form1()
        {
            InitializeComponent();

            InitializeDefaultImage();
            InitializeVideoCameras();

        }
        public void InitializeDefaultImage()
        {
            String defaultImage = System.IO.Path.Combine(Application.StartupPath, "..\\..\\..\\static\\sta-art.jpg");
            loaded = new Bitmap(defaultImage);
            reloadImages();
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

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void btn_loadImageA_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                imageA = new Bitmap(open.FileName);
                reloadImages();
            }
        }

        private void btn_loadImageB_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                imageB = new Bitmap(open.FileName);
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
            Thread thread = new Thread(BackgroundThread)
            {
                IsBackground = true
            };
            thread.Start();
        }
        void BackgroundThread()
        {
            while (true)
            {
                if (Buttonpressed)
                {
                    Point cursorPos = Cursor.Position;
                    pickedColor = GetColorAt(cursorPos);
                    panel2.BackColor = pickedColor;
                    string hexvalue = ColorTranslator.ToHtml(pickedColor);
                    textBox1.Text = hexvalue;
                }
            }
        }

        private void stopCamera()
        {
            vcd.SignalToStop();
            vcd.WaitForStop();
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

            effects = ImageProcessing.Subtract(imageA, imageB, pickedColor);

            pictureBox1.Image = imageA;
            pictureBox3.Image = effects;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            useCamera();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            useCamera();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
