﻿namespace _22521124_NgoHongPhuc_Lab2
{
    partial class Lab2_Bai1
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
            this.doc = new System.Windows.Forms.Button();
            this.ghi = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // doc
            // 
            this.doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc.Location = new System.Drawing.Point(36, 33);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(155, 70);
            this.doc.TabIndex = 0;
            this.doc.Text = "ĐỌC FILE";
            this.doc.UseVisualStyleBackColor = true;
            this.doc.Click += new System.EventHandler(this.doc_Click);
            // 
            // ghi
            // 
            this.ghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghi.Location = new System.Drawing.Point(36, 181);
            this.ghi.Name = "ghi";
            this.ghi.Size = new System.Drawing.Size(155, 70);
            this.ghi.TabIndex = 1;
            this.ghi.Text = "GHI FILE";
            this.ghi.UseVisualStyleBackColor = true;
            this.ghi.Click += new System.EventHandler(this.ghi_Click);
            // 
            // content
            // 
            this.content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.Location = new System.Drawing.Point(221, 33);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(391, 218);
            this.content.TabIndex = 2;
            this.content.Text = "";
            // 
            // Lab2_Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 288);
            this.Controls.Add(this.content);
            this.Controls.Add(this.ghi);
            this.Controls.Add(this.doc);
            this.Name = "Lab2_Bai1";
            this.Text = "Lab2_Bai1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button doc;
        private System.Windows.Forms.Button ghi;
        private System.Windows.Forms.RichTextBox content;
    }
}