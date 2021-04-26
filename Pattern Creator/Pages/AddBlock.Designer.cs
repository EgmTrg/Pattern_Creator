
namespace Pattern_Creator.Pages
{
    partial class AddBlock
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBlock));
            this.label1 = new System.Windows.Forms.Label();
            this.blockName_textBox = new System.Windows.Forms.TextBox();
            this.selectImage_button = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listBlocks_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Block Name:";
            // 
            // blockName_textBox
            // 
            this.blockName_textBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.blockName_textBox.Location = new System.Drawing.Point(12, 62);
            this.blockName_textBox.Multiline = true;
            this.blockName_textBox.Name = "blockName_textBox";
            this.blockName_textBox.Size = new System.Drawing.Size(208, 70);
            this.blockName_textBox.TabIndex = 1;
            // 
            // selectImage_button
            // 
            this.selectImage_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.selectImage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectImage_button.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.selectImage_button.ForeColor = System.Drawing.Color.Black;
            this.selectImage_button.Location = new System.Drawing.Point(12, 138);
            this.selectImage_button.Name = "selectImage_button";
            this.selectImage_button.Size = new System.Drawing.Size(208, 47);
            this.selectImage_button.TabIndex = 4;
            this.selectImage_button.Text = "Select Image";
            this.selectImage_button.UseVisualStyleBackColor = false;
            this.selectImage_button.Click += new System.EventHandler(this.selectImage_button_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listBlocks_ToolStripMenuItem,
            this.downloadBlockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(393, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listBlocks_ToolStripMenuItem
            // 
            this.listBlocks_ToolStripMenuItem.Name = "listBlocks_ToolStripMenuItem";
            this.listBlocks_ToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.listBlocks_ToolStripMenuItem.Text = "List Blocks";
            this.listBlocks_ToolStripMenuItem.Click += new System.EventHandler(this.listBlocks_ToolStripMenuItem_Click);
            // 
            // downloadBlockToolStripMenuItem
            // 
            this.downloadBlockToolStripMenuItem.Name = "downloadBlockToolStripMenuItem";
            this.downloadBlockToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.downloadBlockToolStripMenuItem.Text = "Download Block";
            this.downloadBlockToolStripMenuItem.Click += new System.EventHandler(this.downloadBlockToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(230, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AddBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 197);
            this.Controls.Add(this.selectImage_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blockName_textBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AddBlock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBlock";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox blockName_textBox;
        private System.Windows.Forms.Button selectImage_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listBlocks_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadBlockToolStripMenuItem;
    }
}