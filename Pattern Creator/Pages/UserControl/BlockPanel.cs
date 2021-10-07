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

        /// <summary>
        /// Hide = True, Show = False, Confirm, Remove, blockName and amount items determines of hide or show status.
        /// </summary>
        /// <param name="HideOrNot"></param>
        private void DetermineStatusOfItems(bool HideOrNot)
        {
            if (HideOrNot)
            {
                blockName_label.Text = blockName_combobox.Text;
                amount_label.Text = amount_textBox.Text;
                confirm_iconbutton.Visible = false;
                remove_iconbutton.Visible = false;
                blockName_combobox.Visible = false;
                amount_textBox.Visible = false;
            }
            else
            {
                confirm_iconbutton.Visible = true;
                remove_iconbutton.Visible = true;
                blockName_combobox.Visible = true;
                amount_textBox.Visible = true;
            }
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
            DetermineStatusOfItems(true);
        }

        private void remove_iconbutton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void blockName_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(blockName_combobox.SelectedValue);
                if (index > -1)
                    ChangeImage(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
            
        }

        private void editMode_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (editMode_checkBox.Checked)
                DetermineStatusOfItems(false);
        }
        #endregion
    }
}
