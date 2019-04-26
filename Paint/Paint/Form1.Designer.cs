namespace Paint
{
    partial class Paint
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pen_button = new System.Windows.Forms.Button();
            this.erase_button = new System.Windows.Forms.Button();
            this.color_button = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.line_button = new System.Windows.Forms.Button();
            this.rectangle_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ellipse_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.checkSmooth = new System.Windows.Forms.CheckBox();
            this.fill_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 402);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pen_button
            // 
            this.pen_button.BackgroundImage = global::Paint.Properties.Resources.Pen_5_icon;
            this.pen_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pen_button.Location = new System.Drawing.Point(627, 77);
            this.pen_button.Name = "pen_button";
            this.pen_button.Size = new System.Drawing.Size(75, 41);
            this.pen_button.TabIndex = 1;
            this.pen_button.UseVisualStyleBackColor = true;
            this.pen_button.Click += new System.EventHandler(this.pen_button_Click);
            // 
            // erase_button
            // 
            this.erase_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("erase_button.BackgroundImage")));
            this.erase_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.erase_button.Location = new System.Drawing.Point(627, 171);
            this.erase_button.Name = "erase_button";
            this.erase_button.Size = new System.Drawing.Size(75, 41);
            this.erase_button.TabIndex = 2;
            this.erase_button.UseVisualStyleBackColor = true;
            this.erase_button.Click += new System.EventHandler(this.erase_button_Click);
            // 
            // color_button
            // 
            this.color_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("color_button.BackgroundImage")));
            this.color_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.color_button.Location = new System.Drawing.Point(627, 264);
            this.color_button.Name = "color_button";
            this.color_button.Size = new System.Drawing.Size(75, 41);
            this.color_button.TabIndex = 3;
            this.color_button.UseVisualStyleBackColor = true;
            this.color_button.Click += new System.EventHandler(this.color_button_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(618, 311);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // line_button
            // 
            this.line_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line_button.BackgroundImage")));
            this.line_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.line_button.Location = new System.Drawing.Point(708, 77);
            this.line_button.Name = "line_button";
            this.line_button.Size = new System.Drawing.Size(75, 41);
            this.line_button.TabIndex = 5;
            this.line_button.UseVisualStyleBackColor = true;
            this.line_button.Click += new System.EventHandler(this.line_button_Click);
            // 
            // rectangle_button
            // 
            this.rectangle_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangle_button.BackgroundImage")));
            this.rectangle_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rectangle_button.Location = new System.Drawing.Point(627, 124);
            this.rectangle_button.Name = "rectangle_button";
            this.rectangle_button.Size = new System.Drawing.Size(75, 41);
            this.rectangle_button.TabIndex = 6;
            this.rectangle_button.UseVisualStyleBackColor = true;
            this.rectangle_button.Click += new System.EventHandler(this.rectangle_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ellipse_button
            // 
            this.ellipse_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ellipse_button.BackgroundImage")));
            this.ellipse_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ellipse_button.Location = new System.Drawing.Point(708, 124);
            this.ellipse_button.Name = "ellipse_button";
            this.ellipse_button.Size = new System.Drawing.Size(75, 41);
            this.ellipse_button.TabIndex = 8;
            this.ellipse_button.UseVisualStyleBackColor = true;
            this.ellipse_button.Click += new System.EventHandler(this.ellipse_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clear_button.BackgroundImage")));
            this.clear_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clear_button.Location = new System.Drawing.Point(629, 362);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 41);
            this.clear_button.TabIndex = 9;
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // checkSmooth
            // 
            this.checkSmooth.AutoSize = true;
            this.checkSmooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkSmooth.Location = new System.Drawing.Point(708, 273);
            this.checkSmooth.Name = "checkSmooth";
            this.checkSmooth.Size = new System.Drawing.Size(79, 20);
            this.checkSmooth.TabIndex = 10;
            this.checkSmooth.Text = "Smooth";
            this.checkSmooth.UseVisualStyleBackColor = true;
            this.checkSmooth.CheckedChanged += new System.EventHandler(this.checkSmooth_CheckedChanged);
            // 
            // fill_button
            // 
            this.fill_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fill_button.BackgroundImage")));
            this.fill_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fill_button.Location = new System.Drawing.Point(708, 171);
            this.fill_button.Name = "fill_button";
            this.fill_button.Size = new System.Drawing.Size(75, 41);
            this.fill_button.TabIndex = 11;
            this.fill_button.UseVisualStyleBackColor = true;
            this.fill_button.Click += new System.EventHandler(this.fill_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(624, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tools";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(624, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Properties";
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fill_button);
            this.Controls.Add(this.checkSmooth);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.ellipse_button);
            this.Controls.Add(this.rectangle_button);
            this.Controls.Add(this.line_button);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.color_button);
            this.Controls.Add(this.erase_button);
            this.Controls.Add(this.pen_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paint";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button pen_button;
        private System.Windows.Forms.Button erase_button;
        private System.Windows.Forms.Button color_button;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button line_button;
        private System.Windows.Forms.Button rectangle_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ellipse_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.CheckBox checkSmooth;
        private System.Windows.Forms.Button fill_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

