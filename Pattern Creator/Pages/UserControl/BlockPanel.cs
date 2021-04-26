using System;
using System.IO;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Pattern_Creator.Scripts;

namespace Pattern_Creator.Forms.UserForm
{
    public partial class BlockPanel : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public BlockPanel()
        {
            InitializeComponent();
            BorderStyle = BorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            blockName_combobox.DataSource = Database.Select();
            blockName_combobox.DisplayMember = "Name";
            blockName_combobox.ValueMember = "ID";
            this.BackColor = Color.FromArgb(80, Color.LightGray);
        }

        #region Custom Methods
        private void ConfirmBlock()
        {
            blockName_label.Text = blockName_combobox.Text;
            amount_label.Text = amount_textBox.Text;
            confirm_iconbutton.Dispose();
            remove_iconbutton.Dispose();
            blockName_combobox.Dispose();
            amount_textBox.Dispose();
        }

        private void ChangeImage(int id)
        {
            byte[] imageSource = Database.GetImage(id);
            Bitmap image;
            using (MemoryStream stream = new MemoryStream(imageSource))
            {
                image = new Bitmap(stream);
            }
            blockPic_pictureBox.Image = image;
        }
        #endregion

        #region Events
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void confirm_iconbutton_Click(object sender, EventArgs e)
        {
            ConfirmBlock();
        }

        #endregion

        private void remove_iconbutton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void blockName_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(blockName_combobox.SelectedValue);
            if (index > -1)
                ChangeImage(index);
        }
    }
}
