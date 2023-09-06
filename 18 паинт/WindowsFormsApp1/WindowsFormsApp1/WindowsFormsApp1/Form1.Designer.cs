namespace WindowsFormsApp1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.Open_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.circle_button = new System.Windows.Forms.Button();
            this.rec_button = new System.Windows.Forms.Button();
            this.line_button = new System.Windows.Forms.Button();
            this.erase_batton = new System.Windows.Forms.Button();
            this.Fill_button = new System.Windows.Forms.Button();
            this.Pen_button = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.clear_button);
            this.panel1.Controls.Add(this.Open_button);
            this.panel1.Controls.Add(this.save_button);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.circle_button);
            this.panel1.Controls.Add(this.rec_button);
            this.panel1.Controls.Add(this.line_button);
            this.panel1.Controls.Add(this.erase_batton);
            this.panel1.Controls.Add(this.Fill_button);
            this.panel1.Controls.Add(this.Pen_button);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 114);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Размер";
            // 
            // clear_button
            // 
            this.clear_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_button.Location = new System.Drawing.Point(742, 79);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(110, 23);
            this.clear_button.TabIndex = 16;
            this.clear_button.Text = "Очистить";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Open_button
            // 
            this.Open_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Open_button.Location = new System.Drawing.Point(742, 50);
            this.Open_button.Name = "Open_button";
            this.Open_button.Size = new System.Drawing.Size(110, 23);
            this.Open_button.TabIndex = 15;
            this.Open_button.Text = "Открыть";
            this.Open_button.UseVisualStyleBackColor = true;
            this.Open_button.Click += new System.EventHandler(this.Open_button_Click);
            // 
            // save_button
            // 
            this.save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_button.Location = new System.Drawing.Point(742, 21);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(110, 23);
            this.save_button.TabIndex = 14;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(544, 36);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(103, 45);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // circle_button
            // 
            this.circle_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.circle_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle_button.Image = global::WindowsFormsApp1.Properties.Resources.circle1;
            this.circle_button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.circle_button.Location = new System.Drawing.Point(478, 16);
            this.circle_button.Name = "circle_button";
            this.circle_button.Size = new System.Drawing.Size(50, 61);
            this.circle_button.TabIndex = 12;
            this.circle_button.Text = "Круг";
            this.circle_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.circle_button.UseVisualStyleBackColor = false;
            this.circle_button.Click += new System.EventHandler(this.circle_button_Click);
            // 
            // rec_button
            // 
            this.rec_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rec_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rec_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rec_button.Image = global::WindowsFormsApp1.Properties.Resources.rectangle;
            this.rec_button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.rec_button.Location = new System.Drawing.Point(422, 16);
            this.rec_button.Name = "rec_button";
            this.rec_button.Size = new System.Drawing.Size(50, 61);
            this.rec_button.TabIndex = 11;
            this.rec_button.Text = "Квадрат";
            this.rec_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rec_button.UseVisualStyleBackColor = false;
            this.rec_button.Click += new System.EventHandler(this.rec_button_Click);
            // 
            // line_button
            // 
            this.line_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.line_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.line_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line_button.Image = global::WindowsFormsApp1.Properties.Resources.line;
            this.line_button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.line_button.Location = new System.Drawing.Point(366, 16);
            this.line_button.Name = "line_button";
            this.line_button.Size = new System.Drawing.Size(50, 61);
            this.line_button.TabIndex = 10;
            this.line_button.Text = "Линия";
            this.line_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.line_button.UseVisualStyleBackColor = false;
            this.line_button.Click += new System.EventHandler(this.line_button_Click);
            // 
            // erase_batton
            // 
            this.erase_batton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.erase_batton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.erase_batton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.erase_batton.Image = global::WindowsFormsApp1.Properties.Resources.eraser;
            this.erase_batton.Location = new System.Drawing.Point(310, 16);
            this.erase_batton.Name = "erase_batton";
            this.erase_batton.Size = new System.Drawing.Size(50, 61);
            this.erase_batton.TabIndex = 9;
            this.erase_batton.Text = "Ластик";
            this.erase_batton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.erase_batton.UseVisualStyleBackColor = false;
            this.erase_batton.Click += new System.EventHandler(this.erase_batton_Click);
            // 
            // Fill_button
            // 
            this.Fill_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Fill_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fill_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fill_button.Image = global::WindowsFormsApp1.Properties.Resources.bucket;
            this.Fill_button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Fill_button.Location = new System.Drawing.Point(254, 16);
            this.Fill_button.Name = "Fill_button";
            this.Fill_button.Size = new System.Drawing.Size(50, 61);
            this.Fill_button.TabIndex = 8;
            this.Fill_button.Text = "Заливка";
            this.Fill_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Fill_button.UseVisualStyleBackColor = false;
            this.Fill_button.Click += new System.EventHandler(this.Fill_button_Click);
            // 
            // Pen_button
            // 
            this.Pen_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pen_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pen_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pen_button.Image = global::WindowsFormsApp1.Properties.Resources.pencil;
            this.Pen_button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Pen_button.Location = new System.Drawing.Point(198, 16);
            this.Pen_button.Name = "Pen_button";
            this.Pen_button.Size = new System.Drawing.Size(50, 61);
            this.Pen_button.TabIndex = 7;
            this.Pen_button.Text = "Перо";
            this.Pen_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pen_button.UseVisualStyleBackColor = false;
            this.Pen_button.Click += new System.EventHandler(this.Pen_button_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.Silver;
            this.pic_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_color.Location = new System.Drawing.Point(3, 5);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(189, 106);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            this.pic_color.Click += new System.EventHandler(this.pic_color_Click_1);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(864, 511);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button circle_button;
        private System.Windows.Forms.Button rec_button;
        private System.Windows.Forms.Button line_button;
        private System.Windows.Forms.Button erase_batton;
        private System.Windows.Forms.Button Fill_button;
        private System.Windows.Forms.Button Pen_button;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button Open_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

