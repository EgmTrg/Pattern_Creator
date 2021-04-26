using System;
using System.Windows.Forms;
using Pattern_Creator.Scripts;

namespace Pattern_Creator
{
    public partial class AllBlocks : Form
    {
        Nullable<int> _SELECTED_ID = null;
        private string _BLOCK_NAME = null;
        private string _NEW_BLOCK_NAME = null;
        public AllBlocks()
        {
            InitializeComponent();
        }

        private void AllBlocks_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Database.Select();
        }

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = Database.Select();
            }
            catch (Exception) { }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_SELECTED_ID.Equals(null))
            {
                DialogResult dialog = MessageBox.Show("Selected row permanently will delete. This action is irreversible! Are you sure to delete it?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                    Database.Delete(_SELECTED_ID.Value);
                else
                    MessageBox.Show("Action has been canceled!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            refreshListToolStripMenuItem.PerformClick();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                try
                {
                    _SELECTED_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                    _BLOCK_NAME = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                }
                catch (Exception)
                { }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _NEW_BLOCK_NAME = dataGridView1.CurrentRow.Cells[e.ColumnIndex].Value.ToString();
            bool updateStatus = false;
            if (!(string.IsNullOrEmpty(_NEW_BLOCK_NAME) || string.IsNullOrWhiteSpace(_NEW_BLOCK_NAME) && _SELECTED_ID.HasValue))
            {
                DialogResult dialog = MessageBox.Show("This action is irreversible! Are you sure to update it?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes && _SELECTED_ID.HasValue)
                {
                    Database.Update(_SELECTED_ID.Value, _NEW_BLOCK_NAME);
                    updateStatus = true;
                }
                else
                    dataGridView1.CurrentRow.Cells[e.ColumnIndex].Value = _BLOCK_NAME;
            }
            if (updateStatus)
                refreshListToolStripMenuItem.PerformClick();
        }
    }
}
