using System.Windows.Forms;

namespace picture_viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void clearbttn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void closebttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showbttn_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                imageFiles = openFileDialog1.FileNames.ToList();
                if (imageFiles.Count > 0)
                {
                    currentImageIndex = 0;
                    DisplayImage(currentImageIndex);
                }
            }
            
                
                
            
        }
        
        List<string> imageFiles = new List<string>(); 
        int currentImageIndex = -1;
        private void DisplayImage(int index)
        {
            if (imageFiles.Count > 0 && index >= 0 && index < imageFiles.Count)
            {
                pictureBox1.Image = new Bitmap(imageFiles[index]);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    if (currentImageIndex > 0)
                    {
                        currentImageIndex--;
                        DisplayImage(currentImageIndex); 
                    }
                    break;

                case Keys.Right:
                    if (currentImageIndex < imageFiles.Count - 1)
                    {
                        currentImageIndex++;
                        DisplayImage(currentImageIndex);  
                    }
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
