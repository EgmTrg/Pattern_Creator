
namespace Pattern_Creator.Forms.UserForm
{
    partial class BlockPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlockPanel));
            this.blockPic_pictureBox = new System.Windows.Forms.PictureBox();
            this.blockName_label = new System.Windows.Forms.Label();
            this.blockName_combobox = new System.Windows.Forms.ComboBox();
            this.amount_textBox = new System.Windows.Forms.TextBox();
            this.confirm_iconbutton = new FontAwesome.Sharp.IconButton();
            this.remove_iconbutton = new FontAwesome.Sharp.IconButton();
            this.amount_label = new System.Windows.Forms.Label();
            this.editMode_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.blockPic_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // blockPic_pictureBox
            // 
            this.blockPic_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("blockPic_pictureBox.Image")));
            this.blockPic_pictureBox.Location = new System.Drawing.Point(2, 2);
            this.blockPic_pictureBox.Name = "blockPic_pictureBox";
            this.blockPic_pictureBox.Size = new System.Drawing.Size(60, 60);
            this.blockPic_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blockPic_pictureBox.TabIndex = 0;
            this.blockPic_pictureBox.TabStop = false;
            // 
            // blockName_label
            // 
            this.blockName_label.AutoSize = true;
            this.blockName_label.Location = new System.Drawing.Point(68, 20);
            this.blockName_label.Name = "blockName_label";
            this.blockName_label.Size = new System.Drawing.Size(59, 22);
            this.blockName_label.TabIndex = 1;
            this.blockName_label.Text = "label1";
            // 
            // blockName_combobox
            // 
            this.blockName_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.blockName_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.blockName_combobox.FormattingEnabled = true;
            this.blockName_combobox.Location = new System.Drawing.Point(68, 17);
            this.blockName_combobox.Name = "blockName_combobox";
            this.blockName_combobox.Size = new System.Drawing.Size(226, 30);
            this.blockName_combobox.TabIndex = 2;
            this.blockName_combobox.SelectedIndexChanged += new System.EventHandler(this.blockName_combobox_SelectedIndexChanged);
            // 
            // amount_textBox
            // 
            this.amount_textBox.Location = new System.Drawing.Point(300, 18);
            this.amount_textBox.Name = "amount_textBox";
            this.amount_textBox.Size = new System.Drawing.Size(63, 29);
            this.amount_textBox.TabIndex = 3;
            this.amount_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // confirm_iconbutton
            // 
            this.confirm_iconbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.confirm_iconbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.confirm_iconbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm_iconbutton.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.confirm_iconbutton.IconColor = System.Drawing.Color.Black;
            this.confirm_iconbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.confirm_iconbutton.IconSize = 22;
            this.confirm_iconbutton.Location = new System.Drawing.Point(351, 0);
            this.confirm_iconbutton.Name = "confirm_iconbutton";
            this.confirm_iconbutton.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.confirm_iconbutton.Size = new System.Drawing.Size(23, 23);
            this.confirm_iconbutton.TabIndex = 4;
            this.confirm_iconbutton.UseVisualStyleBackColor = false;
            this.confirm_iconbutton.Click += new System.EventHandler(this.confirm_iconbutton_Click);
            // 
            // remove_iconbutton
            // 
            this.remove_iconbutton.BackColor = System.Drawing.Color.Crimson;
            this.remove_iconbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.remove_iconbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_iconbutton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.remove_iconbutton.IconColor = System.Drawing.Color.Black;
            this.remove_iconbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.remove_iconbutton.IconSize = 22;
            this.remove_iconbutton.Location = new System.Drawing.Point(351, 40);
            this.remove_iconbutton.Name = "remove_iconbutton";
            this.remove_iconbutton.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.remove_iconbutton.Size = new System.Drawing.Size(23, 23);
            this.remove_iconbutton.TabIndex = 4;
            this.remove_iconbutton.UseVisualStyleBackColor = false;
            this.remove_iconbutton.Click += new System.EventHandler(this.remove_iconbutton_Click);
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Location = new System.Drawing.Point(304, 20);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(52, 22);
            this.amount_label.TabIndex = 5;
            this.amount_label.Text = "some";
            // 
            // editMode_checkBox
            // 
            this.editMode_checkBox.AutoSize = true;
            this.editMode_checkBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editMode_checkBox.Location = new System.Drawing.Point(68, 45);
            this.editMode_checkBox.Name = "editMode_checkBox";
            this.editMode_checkBox.Size = new System.Drawing.Size(97, 21);
            this.editMode_checkBox.TabIndex = 6;
            this.editMode_checkBox.Text = "Edit Mode";
            this.editMode_checkBox.UseVisualStyleBackColor = true;
            this.editMode_checkBox.Visible = false;
            this.editMode_checkBox.CheckedChanged += new System.EventHandler(this.editMode_checkBox_CheckedChanged);
            // 
            // BlockPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.editMode_checkBox);
            this.Controls.Add(this.remove_iconbutton);
            this.Controls.Add(this.confirm_iconbutton);
            this.Controls.Add(this.amount_textBox);
            this.Controls.Add(this.blockName_combobox);
            this.Controls.Add(this.blockName_label);
            this.Controls.Add(this.blockPic_pictureBox);
            this.Controls.Add(this.amount_label);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "BlockPanel";
            this.Size = new System.Drawing.Size(374, 63);
            ((System.ComponentModel.ISupportInitialize)(this.blockPic_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox blockPic_pictureBox;
        private System.Windows.Forms.Label blockName_label;
        private System.Windows.Forms.ComboBox blockName_combobox;
        private System.Windows.Forms.TextBox amount_textBox;
        private FontAwesome.Sharp.IconButton confirm_iconbutton;
        private FontAwesome.Sharp.IconButton remove_iconbutton;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.CheckBox editMode_checkBox;
    }
}
