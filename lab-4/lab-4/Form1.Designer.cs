namespace lab_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip2 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            работаСКартинкойToolStripMenuItem = new ToolStripMenuItem();
            загрузитьКартинкуСФайлаToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            normalToolStripMenuItem = new ToolStripMenuItem();
            stretchImageToolStripMenuItem = new ToolStripMenuItem();
            autoSizeToolStripMenuItem = new ToolStripMenuItem();
            centerImageToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            примерыРаботыToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripComboBox1 = new ToolStripComboBox();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = SystemColors.AppWorkspace;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, работаСКартинкойToolStripMenuItem, примерыРаботыToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(940, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(135, 26);
            выходToolStripMenuItem.Text = "выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // работаСКартинкойToolStripMenuItem
            // 
            работаСКартинкойToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { загрузитьКартинкуСФайлаToolStripMenuItem, toolStripMenuItem1 });
            работаСКартинкойToolStripMenuItem.Name = "работаСКартинкойToolStripMenuItem";
            работаСКартинкойToolStripMenuItem.Size = new Size(159, 24);
            работаСКартинкойToolStripMenuItem.Text = "Работа с картинкой";
            // 
            // загрузитьКартинкуСФайлаToolStripMenuItem
            // 
            загрузитьКартинкуСФайлаToolStripMenuItem.Name = "загрузитьКартинкуСФайлаToolStripMenuItem";
            загрузитьКартинкуСФайлаToolStripMenuItem.Size = new Size(284, 26);
            загрузитьКартинкуСФайлаToolStripMenuItem.Text = "Загрузить картинку с файла";
            загрузитьКартинкуСФайлаToolStripMenuItem.Click += загрузитьКартинкуСФайлаToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { normalToolStripMenuItem, stretchImageToolStripMenuItem, autoSizeToolStripMenuItem, centerImageToolStripMenuItem, zoomToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(284, 26);
            toolStripMenuItem1.Text = "Размещение картинки";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(180, 26);
            normalToolStripMenuItem.Text = "normal";
            normalToolStripMenuItem.Click += normalToolStripMenuItem_Click;
            // 
            // stretchImageToolStripMenuItem
            // 
            stretchImageToolStripMenuItem.Name = "stretchImageToolStripMenuItem";
            stretchImageToolStripMenuItem.Size = new Size(180, 26);
            stretchImageToolStripMenuItem.Text = "StretchImage";
            stretchImageToolStripMenuItem.Click += stretchImageToolStripMenuItem_Click;
            // 
            // autoSizeToolStripMenuItem
            // 
            autoSizeToolStripMenuItem.Name = "autoSizeToolStripMenuItem";
            autoSizeToolStripMenuItem.Size = new Size(180, 26);
            autoSizeToolStripMenuItem.Text = "AutoSize";
            autoSizeToolStripMenuItem.Click += autoSizeToolStripMenuItem_Click;
            // 
            // centerImageToolStripMenuItem
            // 
            centerImageToolStripMenuItem.Name = "centerImageToolStripMenuItem";
            centerImageToolStripMenuItem.Size = new Size(180, 26);
            centerImageToolStripMenuItem.Text = "CenterImage";
            centerImageToolStripMenuItem.Click += centerImageToolStripMenuItem_Click;
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(180, 26);
            zoomToolStripMenuItem.Text = "Zoom";
            zoomToolStripMenuItem.Click += zoomToolStripMenuItem_Click;
            // 
            // примерыРаботыToolStripMenuItem
            // 
            примерыРаботыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripSeparator1, toolStripComboBox1 });
            примерыРаботыToolStripMenuItem.Name = "примерыРаботыToolStripMenuItem";
            примерыРаботыToolStripMenuItem.Size = new Size(145, 24);
            примерыРаботыToolStripMenuItem.Text = "примеры работы";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.BackColor = SystemColors.GradientActiveCaption;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.BackColor = SystemColors.InactiveCaption;
            toolStripComboBox1.Items.AddRange(new object[] { "1ЙФЦУКЕНГШ" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            toolStripComboBox1.Click += toolStripComboBox1_Click;

            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(30, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(416, 360);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(614, 91);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 3;
            label1.Text = "то что мы ввели";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(614, 153);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(614, 215);
            label3.Name = "label3";
            label3.Size = new Size(279, 20);
            label3.TabIndex = 5;
            label3.Text = "то что выбрали в выпадающем списке";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(614, 274);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(940, 577);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip2);
            Name = "Form1";
            Text = "Form1";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip2;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem работаСКартинкойToolStripMenuItem;
        private ToolStripMenuItem загрузитьКартинкуСФайлаToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem stretchImageToolStripMenuItem;
        private ToolStripMenuItem autoSizeToolStripMenuItem;
        private ToolStripMenuItem centerImageToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ToolStripMenuItem примерыРаботыToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripComboBox toolStripComboBox1;

    }
}