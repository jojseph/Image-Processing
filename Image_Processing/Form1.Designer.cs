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
            Button btnPickColor;
            tabControl1 = new TabControl();
            DIP = new TabPage();
            picture_result = new PictureBox();
            picture_orig = new PictureBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            filtersToolStripMenuItem = new ToolStripMenuItem();
            duplicateToolStripMenuItem = new ToolStripMenuItem();
            greyscaleToolStripMenuItem = new ToolStripMenuItem();
            inversionToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            convolutionalMatrixToolStripMenuItem = new ToolStripMenuItem();
            shrinkToolStripMenuItem = new ToolStripMenuItem();
            smoothingToolStripMenuItem = new ToolStripMenuItem();
            gaussianBlurToolStripMenuItem = new ToolStripMenuItem();
            sharpenToolStripMenuItem = new ToolStripMenuItem();
            meanRemovalToolStripMenuItem = new ToolStripMenuItem();
            embossingToolStripMenuItem = new ToolStripMenuItem();
            embossLaplascianToolStripMenuItem = new ToolStripMenuItem();
            tabPage23 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            btn_subtract = new Button();
            btn_loadImageB = new Button();
            btn_loadImageA = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnPickColor = new Button();
            tabControl1.SuspendLayout();
            DIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_result).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_orig).BeginInit();
            menuStrip1.SuspendLayout();
            tabPage23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnPickColor
            // 
            btnPickColor.Location = new Point(806, 459);
            btnPickColor.Name = "btnPickColor";
            btnPickColor.Size = new Size(149, 23);
            btnPickColor.TabIndex = 8;
            btnPickColor.Text = "Pick a color";
            btnPickColor.UseVisualStyleBackColor = true;
            btnPickColor.Click += btnPickColor_Click;
            btnPickColor.MouseDown += btnPickColor_MouseDown;
            btnPickColor.MouseUp += btnPickColor_MouseUp;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(DIP);
            tabControl1.Controls.Add(tabPage23);
            tabControl1.Location = new Point(0, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1033, 559);
            tabControl1.TabIndex = 0;
            // 
            // DIP
            // 
            DIP.Controls.Add(picture_result);
            DIP.Controls.Add(picture_orig);
            DIP.Controls.Add(menuStrip1);
            DIP.Location = new Point(4, 24);
            DIP.Name = "DIP";
            DIP.Padding = new Padding(3);
            DIP.Size = new Size(1025, 531);
            DIP.TabIndex = 0;
            DIP.Text = "DIP";
            DIP.UseVisualStyleBackColor = true;
            DIP.Click += tabPage1_Click;
            // 
            // picture_result
            // 
            picture_result.Location = new Point(536, 52);
            picture_result.Name = "picture_result";
            picture_result.Size = new Size(448, 411);
            picture_result.TabIndex = 2;
            picture_result.TabStop = false;
            // 
            // picture_orig
            // 
            picture_orig.Location = new Point(55, 52);
            picture_orig.Name = "picture_orig";
            picture_orig.Size = new Size(448, 411);
            picture_orig.TabIndex = 1;
            picture_orig.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, filtersToolStripMenuItem, convolutionalMatrixToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1019, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(100, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(100, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
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
            duplicateToolStripMenuItem.Size = new Size(130, 22);
            duplicateToolStripMenuItem.Text = "Duplicate";
            duplicateToolStripMenuItem.Click += duplicateToolStripMenuItem_Click;
            // 
            // greyscaleToolStripMenuItem
            // 
            greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            greyscaleToolStripMenuItem.Size = new Size(130, 22);
            greyscaleToolStripMenuItem.Text = "Greyscale";
            greyscaleToolStripMenuItem.Click += greyscaleToolStripMenuItem_Click;
            // 
            // inversionToolStripMenuItem
            // 
            inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            inversionToolStripMenuItem.Size = new Size(130, 22);
            inversionToolStripMenuItem.Text = "Inversion";
            inversionToolStripMenuItem.Click += inversionToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(130, 22);
            histogramToolStripMenuItem.Text = "Histogram";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(130, 22);
            sepiaToolStripMenuItem.Text = "Sepia";
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
            // 
            // convolutionalMatrixToolStripMenuItem
            // 
            convolutionalMatrixToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { shrinkToolStripMenuItem, smoothingToolStripMenuItem, gaussianBlurToolStripMenuItem, sharpenToolStripMenuItem, meanRemovalToolStripMenuItem, embossingToolStripMenuItem, embossLaplascianToolStripMenuItem });
            convolutionalMatrixToolStripMenuItem.Name = "convolutionalMatrixToolStripMenuItem";
            convolutionalMatrixToolStripMenuItem.Size = new Size(130, 20);
            convolutionalMatrixToolStripMenuItem.Text = "Convolutional Matrix";
            // 
            // shrinkToolStripMenuItem
            // 
            shrinkToolStripMenuItem.Name = "shrinkToolStripMenuItem";
            shrinkToolStripMenuItem.Size = new Size(176, 22);
            shrinkToolStripMenuItem.Text = "Shrink";
            shrinkToolStripMenuItem.Click += shrinkToolStripMenuItem_Click;
            // 
            // smoothingToolStripMenuItem
            // 
            smoothingToolStripMenuItem.Name = "smoothingToolStripMenuItem";
            smoothingToolStripMenuItem.Size = new Size(176, 22);
            smoothingToolStripMenuItem.Text = "Smoothing";
            smoothingToolStripMenuItem.Click += smoothingToolStripMenuItem_Click;
            // 
            // gaussianBlurToolStripMenuItem
            // 
            gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            gaussianBlurToolStripMenuItem.Size = new Size(176, 22);
            gaussianBlurToolStripMenuItem.Text = "Gaussian Blur ";
            gaussianBlurToolStripMenuItem.Click += gaussianBlurToolStripMenuItem_Click;
            // 
            // sharpenToolStripMenuItem
            // 
            sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            sharpenToolStripMenuItem.Size = new Size(176, 22);
            sharpenToolStripMenuItem.Text = "Sharpen";
            sharpenToolStripMenuItem.Click += sharpenToolStripMenuItem_Click;
            // 
            // meanRemovalToolStripMenuItem
            // 
            meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            meanRemovalToolStripMenuItem.Size = new Size(176, 22);
            meanRemovalToolStripMenuItem.Text = "Mean Removal ";
            meanRemovalToolStripMenuItem.Click += meanRemovalToolStripMenuItem_Click;
            // 
            // embossingToolStripMenuItem
            // 
            embossingToolStripMenuItem.Name = "embossingToolStripMenuItem";
            embossingToolStripMenuItem.Size = new Size(176, 22);
            embossingToolStripMenuItem.Text = "Embossing";
            embossingToolStripMenuItem.Click += embossingToolStripMenuItem_Click;
            // 
            // embossLaplascianToolStripMenuItem
            // 
            embossLaplascianToolStripMenuItem.Name = "embossLaplascianToolStripMenuItem";
            embossLaplascianToolStripMenuItem.Size = new Size(176, 22);
            embossLaplascianToolStripMenuItem.Text = "Emboss Laplascian ";
            embossLaplascianToolStripMenuItem.Click += embossLaplascianToolStripMenuItem_Click;
            // 
            // tabPage23
            // 
            tabPage23.Controls.Add(label2);
            tabPage23.Controls.Add(label1);
            tabPage23.Controls.Add(btnPickColor);
            tabPage23.Controls.Add(panel1);
            tabPage23.Controls.Add(textBox1);
            tabPage23.Controls.Add(btn_subtract);
            tabPage23.Controls.Add(btn_loadImageB);
            tabPage23.Controls.Add(btn_loadImageA);
            tabPage23.Controls.Add(pictureBox3);
            tabPage23.Controls.Add(pictureBox2);
            tabPage23.Controls.Add(pictureBox1);
            tabPage23.Controls.Add(panel2);
            tabPage23.Location = new Point(4, 24);
            tabPage23.Name = "tabPage23";
            tabPage23.Padding = new Padding(3);
            tabPage23.Size = new Size(1025, 531);
            tabPage23.TabIndex = 1;
            tabPage23.Text = "Image Subtract";
            tabPage23.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(633, 441);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 12;
            label2.Text = "Color";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(820, 441);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 11;
            label1.Text = "Hold the mouse down";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(153, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(59, 48);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Camera";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(739, 459);
            panel1.Name = "panel1";
            panel1.Size = new Size(45, 23);
            panel1.TabIndex = 7;
            panel1.Paint += panel2_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(633, 459);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btn_subtract
            // 
            btn_subtract.Location = new Point(785, 363);
            btn_subtract.Name = "btn_subtract";
            btn_subtract.Size = new Size(149, 23);
            btn_subtract.TabIndex = 5;
            btn_subtract.Text = "Subtract";
            btn_subtract.UseVisualStyleBackColor = true;
            btn_subtract.Click += btn_subtract_Click;
            // 
            // btn_loadImageB
            // 
            btn_loadImageB.Location = new Point(455, 363);
            btn_loadImageB.Name = "btn_loadImageB";
            btn_loadImageB.Size = new Size(149, 23);
            btn_loadImageB.TabIndex = 4;
            btn_loadImageB.Text = "Load Background";
            btn_loadImageB.UseVisualStyleBackColor = true;
            btn_loadImageB.Click += button2_Click;
            // 
            // btn_loadImageA
            // 
            btn_loadImageA.Location = new Point(104, 363);
            btn_loadImageA.Name = "btn_loadImageA";
            btn_loadImageA.Size = new Size(149, 23);
            btn_loadImageA.TabIndex = 3;
            btn_loadImageA.Text = "Load Image";
            btn_loadImageA.UseVisualStyleBackColor = true;
            btn_loadImageA.Click += btn_loadImageA_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(695, 60);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(302, 278);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(365, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(302, 278);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(31, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Honeydew;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(checkBox1);
            panel2.Location = new Point(2, 413);
            panel2.Name = "panel2";
            panel2.Size = new Size(1023, 115);
            panel2.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 562);
            Controls.Add(tabControl1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            DIP.ResumeLayout(false);
            DIP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_result).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_orig).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabPage23.ResumeLayout(false);
            tabPage23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage DIP;
        private TabPage tabPage23;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem filtersToolStripMenuItem;
        private ToolStripMenuItem duplicateToolStripMenuItem;
        private ToolStripMenuItem greyscaleToolStripMenuItem;
        private ToolStripMenuItem inversionToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private PictureBox picture_result;
        private PictureBox picture_orig;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btn_loadImageB;
        private Button btn_loadImageA;
        private Button btn_subtract;
        private TextBox textBox1;
        private Panel panel1;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private ToolStripMenuItem convolutionalMatrixToolStripMenuItem;
        private ToolStripMenuItem shrinkToolStripMenuItem;
        private ToolStripMenuItem smoothingToolStripMenuItem;
        private ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private ToolStripMenuItem sharpenToolStripMenuItem;
        private ToolStripMenuItem meanRemovalToolStripMenuItem;
        private ToolStripMenuItem embossingToolStripMenuItem;
        private ToolStripMenuItem embossLaplascianToolStripMenuItem;
        private Label label2;
        private Label label1;
        private Panel panel2;
    }
}
