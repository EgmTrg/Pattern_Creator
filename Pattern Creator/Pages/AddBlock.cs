using System;
using System.IO;
using System.Windows.Forms;
using Pattern_Creator.Scripts;

namespace Pattern_Creator.Pages
{
    public partial class AddBlock : Form
    {
        public AddBlock()
        {
            InitializeComponent();
            openFileDialog.Filter = "Resim Dosyalari|*.jpg;*.png| Tum Dosyalar|*.*";
            openFileDialog.Title = "Will be added automatically.";
        }

        private void selectImage_button_Click(object sender, EventArgs e)
        {
            int affected = 0;
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (openFileDialog.Multiselect)
                {
                    for (int i = 0; i < openFileDialog.SafeFileNames.Length; i++)
                    {
                        blockName_textBox.Text = openFileDialog.SafeFileNames[i].ToString().Remove(openFileDialog.SafeFileNames[i].ToString().Length - 4);
                        pictureBox1.ImageLocation = openFileDialog.FileNames[i];
                        if (SaveBlocksToDatabase())
                            affected++;
                        else
                            MessageBox.Show("1 Block NOT Added but the process will continue", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    pictureBox1.ImageLocation = openFileDialog.FileName;
                    blockName_textBox.Text = openFileDialog.SafeFileName;
                }
            }
            else
                pictureBox1.Image = Properties.Resources.noImage;
            if (affected > 0)
                MessageBox.Show($"Process Successfully Finished. Totally {affected} Image(s) Added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"No Image(s) Added", "No Image(s)!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool SaveBlocksToDatabase()
        {
            FileStream fs = new FileStream(pictureBox1.ImageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] image = br.ReadBytes((int)fs.Length);
            bool status = Database.Insert(blockName_textBox.Text, image);
            return status;
        }

        private void listBlocks_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AllBlocks().Show();
        }

        private void downloadBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://minecraft.gamepedia.com/Inventory");
        }
    }
}
