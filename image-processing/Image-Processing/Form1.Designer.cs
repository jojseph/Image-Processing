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
            btn_subtract = new Button();
            btn_loadImageB = new Button();
            btn_loadImageA = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            btnPickColor = new Button();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            miniToolStrip = new MenuStrip();
            Image_filter = new TabControl();
            Image_filters = new TabPage();
            Image_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_result).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_orig).BeginInit();
            menuStrip1.SuspendLayout();
            Image_subtract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            Image_filter.SuspendLayout();
            SuspendLayout();
            // 
            // Image_filters
            // 
            Image_filters.Controls.Add(picture_result);
            Image_filters.Controls.Add(picture_orig);
            Image_filters.Controls.Add(menuStrip1);
            Image_filters.Location = new Point(4, 24);
            Image_filters.Margin = new Padding(3, 2, 3, 2);
            Image_filters.Name = "Image_filters";
            Image_filters.Padding = new Padding(3, 2, 3, 2);
            Image_filters.Size = new Size(1005, 519);
            Image_filters.TabIndex = 0;
            Image_filters.Text = "Image Filters";
            Image_filters.UseVisualStyleBackColor = true;
            // 
            // picture_result
            // 
            picture_result.Location = new Point(523, 71);
            picture_result.Margin = new Padding(3, 2, 3, 2);
            picture_result.Name = "picture_result";
            picture_result.Size = new Size(448, 411);
            picture_result.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_result.TabIndex = 2;
            picture_result.TabStop = false;
            // 
            // picture_orig
            // 
            picture_orig.Location = new Point(35, 71);
            picture_orig.Margin = new Padding(3, 2, 3, 2);
            picture_orig.Name = "picture_orig";
            picture_orig.Size = new Size(448, 411);
            picture_orig.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_orig.TabIndex = 1;
            picture_orig.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, filtersToolStripMenuItem });
            menuStrip1.Location = new Point(3, 2);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(999, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(100, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem1
            // 
            loadToolStripMenuItem1.AccessibleRole = AccessibleRole.ButtonMenu;
            loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            loadToolStripMenuItem1.Size = new Size(100, 22);
            loadToolStripMenuItem1.Text = "Load";
            loadToolStripMenuItem1.Click += loadToolStripMenuItem1_Click;
            // 
            // filtersToolStripMenuItem
            // 
            filtersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { duplicateToolStripMenuItem, greyscaleToolStripMenuItem, inversionToolStripMenuItem, histogramToolStripMenuItem, sepiaToolStripMenuItem });
            filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            filtersToolStripMenuItem.Size = new Size(50, 20);
            filtersToolStripMenuItem.Text = "Filters";
            // 
            // duplicateToolStripMenuItem
            // 
            duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            duplicateToolStripMenuItem.Size = new Size(133, 22);
            duplicateToolStripMenuItem.Text = "Duplicate";
            duplicateToolStripMenuItem.Click += duplicateToolStripMenuItem_Click;
            // 
            // greyscaleToolStripMenuItem
            // 
            greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            greyscaleToolStripMenuItem.Size = new Size(133, 22);
            greyscaleToolStripMenuItem.Text = "Greyscale ";
            greyscaleToolStripMenuItem.Click += greyscaleToolStripMenuItem_Click;
            // 
            // inversionToolStripMenuItem
            // 
            inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            inversionToolStripMenuItem.Size = new Size(133, 22);
            inversionToolStripMenuItem.Text = "Inversion  ";
            inversionToolStripMenuItem.Click += inversionToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(133, 22);
            histogramToolStripMenuItem.Text = "Histogram ";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(133, 22);
            sepiaToolStripMenuItem.Text = "Sepia";
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
            // 
            // Image_subtract
            // 
            Image_subtract.Controls.Add(btn_subtract);
            Image_subtract.Controls.Add(btn_loadImageB);
            Image_subtract.Controls.Add(btn_loadImageA);
            Image_subtract.Controls.Add(pictureBox3);
            Image_subtract.Controls.Add(pictureBox2);
            Image_subtract.Controls.Add(pictureBox1);
            Image_subtract.Controls.Add(panel1);
            Image_subtract.Location = new Point(4, 24);
            Image_subtract.Margin = new Padding(3, 2, 3, 2);
            Image_subtract.Name = "Image_subtract";
            Image_subtract.Padding = new Padding(3, 2, 3, 2);
            Image_subtract.Size = new Size(1005, 519);
            Image_subtract.TabIndex = 1;
            Image_subtract.Text = "Image Subtract";
            Image_subtract.UseVisualStyleBackColor = true;
            // 
            // btn_subtract
            // 
            btn_subtract.Location = new Point(770, 335);
            btn_subtract.Name = "btn_subtract";
            btn_subtract.Size = new Size(149, 23);
            btn_subtract.TabIndex = 5;
            btn_subtract.Text = "Subtract";
            btn_subtract.UseVisualStyleBackColor = true;
            btn_subtract.Click += btn_subtract_Click;
            // 
            // btn_loadImageB
            // 
            btn_loadImageB.Location = new Point(438, 335);
            btn_loadImageB.Name = "btn_loadImageB";
            btn_loadImageB.Size = new Size(149, 23);
            btn_loadImageB.TabIndex = 4;
            btn_loadImageB.Text = "Load Background";
            btn_loadImageB.UseVisualStyleBackColor = true;
            btn_loadImageB.Click += btn_loadImageB_Click;
            // 
            // btn_loadImageA
            // 
            btn_loadImageA.Location = new Point(102, 335);
            btn_loadImageA.Name = "btn_loadImageA";
            btn_loadImageA.Size = new Size(149, 23);
            btn_loadImageA.TabIndex = 3;
            btn_loadImageA.Text = "Load Image";
            btn_loadImageA.UseVisualStyleBackColor = true;
            btn_loadImageA.Click += btn_loadImageA_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(685, 36);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(302, 278);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(349, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(302, 278);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnPickColor);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, 423);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 100);
            panel1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(853, 34);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 12;
            label2.Text = "Hold the mouse down";
            label2.Click += label2_Click;
            // 
            // btnPickColor
            // 
            btnPickColor.Location = new Point(842, 52);
            btnPickColor.Name = "btnPickColor";
            btnPickColor.Size = new Size(145, 23);
            btnPickColor.TabIndex = 8;
            btnPickColor.Text = "Pick a color";
            btnPickColor.UseVisualStyleBackColor = true;
            btnPickColor.Click += btnPickColor_Click;
            btnPickColor.MouseDown += btnPickColor_MouseDown;
            btnPickColor.MouseUp += btnPickColor_MouseUp;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(773, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(38, 23);
            panel2.TabIndex = 11;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(58, 52);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Use Camera";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(667, 34);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 10;
            label1.Text = "Color";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(151, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(667, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
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
            Image_filter.Location = new Point(10, 9);
            Image_filter.Margin = new Padding(3, 2, 3, 2);
            Image_filter.Name = "Image_filter";
            Image_filter.SelectedIndex = 0;
            Image_filter.Size = new Size(1013, 547);
            Image_filter.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 562);
            Controls.Add(Image_filter);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Image_filters.ResumeLayout(false);
            Image_filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_result).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_orig).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            Image_subtract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button btn_loadImageA;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private Button btn_subtract;
        private Button btn_loadImageB;
        private Button btnPickColor;
        private Panel panel2;
        private Label label1;
        private TextBox textBox1;
        private Panel color_picked;
        private Label label2;
        private Panel panel1;
    }
}
