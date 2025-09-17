using MetroSet_UI.Forms;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Image_Processing
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        public Form1()
        {
            InitializeComponent();

            InitializeDefaultImage();
        }
        public void InitializeDefaultImage()
        {
            String defaultImage = System.IO.Path.Combine(Application.StartupPath, "..\\..\\..\\static\\sta-art.jpg");
            loaded = new Bitmap(defaultImage);
            reloadImages();
        }

        public void reloadImages()
        {
            picture_orig.Image = loaded;
            picture_result.Image = processed;
        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            { 
                loaded = new Bitmap(open.FileName);
                reloadImages();
               
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
                    processed = Historgram.DrawHistogram(loaded, picture_result.Size);
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
    }
}
