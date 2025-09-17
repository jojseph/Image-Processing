namespace Image_Processing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabPage Image_filters;
            picture_result = new PictureBox();
            picture_orig = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem1 = new ToolStripMenuItem();
            filtersToolStripMenuItem = new ToolStripMenuItem();
            duplicateToolStripMenuItem = new ToolStripMenuItem();
            greyscaleToolStripMenuItem = new ToolStripMenuItem();
            inversionToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            Image_subtract = new TabPage();
            miniToolStrip = new MenuStrip();
            Image_filter = new TabControl();
            Image_filters = new TabPage();
            Image_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_result).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_orig).BeginInit();
            menuStrip1.SuspendLayout();
            Image_filter.SuspendLayout();
            SuspendLayout();
            // 
            // Image_filters
            // 
            Image_filters.Controls.Add(picture_result);
            Image_filters.Controls.Add(picture_orig);
            Image_filters.Controls.Add(menuStrip1);
            Image_filters.Location = new Point(4, 29);
            Image_filters.Name = "Image_filters";
            Image_filters.Padding = new Padding(3);
            Image_filters.Size = new Size(1150, 696);
            Image_filters.TabIndex = 0;
            Image_filters.Text = "Image Filters";
            Image_filters.UseVisualStyleBackColor = true;
            // 
            // picture_result
            // 
            picture_result.Location = new Point(598, 95);
            picture_result.Name = "picture_result";
            picture_result.Size = new Size(512, 548);
            picture_result.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_result.TabIndex = 2;
            picture_result.TabStop = false;
            // 
            // picture_orig
            // 
            picture_orig.Location = new Point(40, 95);
            picture_orig.Name = "picture_orig";
            picture_orig.Size = new Size(512, 548);
            picture_orig.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_orig.TabIndex = 1;
            picture_orig.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, filtersToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1144, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(125, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem1
            // 
            loadToolStripMenuItem1.AccessibleRole = AccessibleRole.ButtonMenu;
            loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            loadToolStripMenuItem1.Size = new Size(125, 26);
            loadToolStripMenuItem1.Text = "Load";
            loadToolStripMenuItem1.Click += loadToolStripMenuItem1_Click;
            // 
            // filtersToolStripMenuItem
            // 
            filtersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { duplicateToolStripMenuItem, greyscaleToolStripMenuItem, inversionToolStripMenuItem, histogramToolStripMenuItem, sepiaToolStripMenuItem });
            filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            filtersToolStripMenuItem.Size = new Size(62, 24);
            filtersToolStripMenuItem.Text = "Filters";
            // 
            // duplicateToolStripMenuItem
            // 
            duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            duplicateToolStripMenuItem.Size = new Size(166, 26);
            duplicateToolStripMenuItem.Text = "Duplicate";
            duplicateToolStripMenuItem.Click += duplicateToolStripMenuItem_Click;
            // 
            // greyscaleToolStripMenuItem
            // 
            greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            greyscaleToolStripMenuItem.Size = new Size(166, 26);
            greyscaleToolStripMenuItem.Text = "Greyscale ";
            greyscaleToolStripMenuItem.Click += greyscaleToolStripMenuItem_Click;
            // 
            // inversionToolStripMenuItem
            // 
            inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            inversionToolStripMenuItem.Size = new Size(166, 26);
            inversionToolStripMenuItem.Text = "Inversion  ";
            inversionToolStripMenuItem.Click += inversionToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(166, 26);
            histogramToolStripMenuItem.Text = "Histogram ";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(166, 26);
            sepiaToolStripMenuItem.Text = "Sepia";
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
            // 
            // Image_subtract
            // 
            Image_subtract.Location = new Point(4, 29);
            Image_subtract.Name = "Image_subtract";
            Image_subtract.Padding = new Padding(3);
            Image_subtract.Size = new Size(1150, 696);
            Image_subtract.TabIndex = 1;
            Image_subtract.Text = "Image Subtract";
            Image_subtract.UseVisualStyleBackColor = true;
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "New item selection";
            miniToolStrip.AccessibleRole = AccessibleRole.ComboBox;
            miniToolStrip.AutoSize = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.ImageScalingSize = new Size(20, 20);
            miniToolStrip.Location = new Point(114, 2);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(967, 28);
            miniToolStrip.TabIndex = 0;
            // 
            // Image_filter
            // 
            Image_filter.Controls.Add(Image_filters);
            Image_filter.Controls.Add(Image_subtract);
            Image_filter.Location = new Point(12, 12);
            Image_filter.Name = "Image_filter";
            Image_filter.SelectedIndex = 0;
            Image_filter.Size = new Size(1158, 729);
            Image_filter.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(Image_filter);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Image_filters.ResumeLayout(false);
            Image_filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_result).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_orig).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            Image_filter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage Image_subtract;
        private TabPage Image_filters;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem1;
        private ToolStripMenuItem filtersToolStripMenuItem;
        private MenuStrip miniToolStrip;
        private TabControl Image_filter;
        private PictureBox picture_result;
        private PictureBox picture_orig;
        private ToolStripMenuItem duplicateToolStripMenuItem;
        private ToolStripMenuItem greyscaleToolStripMenuItem;
        private ToolStripMenuItem inversionToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem sepiaToolStripMenuItem;
    }
}
