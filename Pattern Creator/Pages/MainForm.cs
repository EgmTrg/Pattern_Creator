using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using Pattern_Creator.Pages;
using Pattern_Creator.Forms.UserForm;
using System.Runtime.InteropServices;

namespace Pattern_Creator
{
    public partial class MainForm : Form
    {
        private ArrayList blockPanels = new ArrayList();
        private bool editModeStatus = false;
        #region Drag Region
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void header_panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        public MainForm()
        {
            InitializeComponent();
            Size = new Size(1575, 750);
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            BackgroundImage = Properties.Resources.bg2;
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            InformationScreen();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                InformationScreen();
            if (e.KeyCode == Keys.F2)
            {
                if (!editModeStatus)
                {
                    BlockPanel bPanel = new BlockPanel();
                    fpanel.Controls.Add(bPanel);
                    blockPanels.Add(bPanel);
                }
                else
                    MessageBox.Show("Please turn off edit mode!", "Edit mode is active.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.KeyCode == Keys.F3)
                new AddBlock().Show();
            if (e.KeyCode == Keys.F4)
                Application.Exit();
            if (e.KeyCode == Keys.F5)
                DeleteEveryBlockPanel();
            if (e.KeyCode == Keys.F6)
            {
                if (editModeStatus) editModeStatus = false;
                else editModeStatus = true;

                foreach (BlockPanel panel in blockPanels)
                {
                    Control[] checkBoxes = panel.Controls.Find("editMode_checkBox", false);
                    if (checkBoxes.Length > 0)
                        if (checkBoxes[0].Visible)
                            checkBoxes[0].Visible = false;
                        else
                            checkBoxes[0].Visible = true;
                    else
                        MessageBox.Show("I dont know why happing like that. Please report to me", "I dont know why", MessageBoxButtons.OK);
                }
            }
        }

        private void InformationScreen()
        {
            MessageBox.Show("F1 : Information.\n" +
                            "F2 : Adding a new block box.\n" +
                            "F3 : Opening a new Window for add block to database.\n" +
                            "F4 : Exit\n" +
                            "F5 : Destroy All Blocks\n" +
                            "F6 : Edit Mode",
                            "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DeleteEveryBlockPanel()
        {
            DialogResult dResult = MessageBox.Show("All Blocks will destroy! Are you sure?", "Destroy all blocks", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dResult == DialogResult.Yes)
            {
                foreach (BlockPanel panel in blockPanels)
                    panel.Dispose();
                blockPanels.Clear();
            }
        }


    }
}
