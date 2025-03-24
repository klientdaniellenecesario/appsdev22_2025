using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.Devices;

namespace SimpleFavoriteCartoonFormAppp
{

    public partial class Form1 : Form
    {
        string imageFolderPath = Path.Combine(Application.StartupPath, "images");
        public Form1()
        {
            InitializeComponent();
            comboBox.Items.Add("Johnny Bravo");
            comboBox.Items.Add("Mickey Mouse");
            comboBox.Items.Add("Tom & Jerry");
            comboBox.Items.Add("Tweety");
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            string selectedCartoon = comboBox.SelectedItem.ToString();

            switch (selectedCartoon)
            {
                case "Johnny Bravo":
                    pictureBox.Image = ConvertByteArrayToImage(Properties.Resources.Johnny_Bravo);
                    break;

                case "Mickey Mouse":
                    pictureBox.Image = ConvertByteArrayToImage(Properties.Resources.Mickey_Mouse);
                    break;

                case "Tom & Jerry":
                    pictureBox.Image = ConvertByteArrayToImage(Properties.Resources.Tom_Jerry2);
                    break;

                case "Tweety":
                    pictureBox.Image = ConvertByteArrayToImage(Properties.Resources.Tweety1);
                    break;

                default:
                    MessageBox.Show("Please select a valid cartoon.");
                    break;
            }
        }

        // Helper method to convert byte[] to Image
        private System.Drawing.Image ConvertByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }
        private void clearbtn_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
