namespace _22521124_NgoHongPhuc_Lab2
{
    partial class Lab2_Bai7
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(12, 12);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(296, 555);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(314, 12);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(605, 264);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(314, 282);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(605, 285);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // Lab2_Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 579);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.treeView);
            this.Name = "Lab2_Bai7";
            this.Text = "Lab2_Bai7";
            this.Load += new System.EventHandler(this.Lab2_Bai7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}