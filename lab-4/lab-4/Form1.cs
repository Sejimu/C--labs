using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing;

namespace lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ‚˚ıÓ‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit (); // or here we use the class and the Exit method to exit the program
            this.Close(); // in this line we close this form objectloadPictureSFile ToolStripMenuItem_Click

        }

        private void Á‡„ÛÁËÚ¸ ‡ÚËÌÍÛ—‘‡ÈÎ‡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            // in the condition for checks when the dialog box was opened, the Open button was pressed then load the picture, if the cancel button was pressed, the picture does not load * /
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                // load an image from a file.

            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void stretchImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void autoSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void centerImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            label3.Text = toolStripComboBox1.SelectedItem.ToString();
        }


        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            label1.Text = toolStripTextBox1.Text;
        }
    }
}