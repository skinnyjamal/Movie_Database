﻿namespace MovieManager
{
    partial class EditMovie
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
            this.Synopsistb = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Genretb = new System.Windows.Forms.TextBox();
            this.ReleaseDatedtp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Nametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Synopsistb
            // 
            this.Synopsistb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Synopsistb.Location = new System.Drawing.Point(19, 145);
            this.Synopsistb.Name = "Synopsistb";
            this.Synopsistb.Size = new System.Drawing.Size(512, 289);
            this.Synopsistb.TabIndex = 14;
            this.Synopsistb.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Genretb);
            this.groupBox1.Controls.Add(this.ReleaseDatedtp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Nametb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 111);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // Genretb
            // 
            this.Genretb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Genretb.Location = new System.Drawing.Point(92, 74);
            this.Genretb.Name = "Genretb";
            this.Genretb.Size = new System.Drawing.Size(153, 23);
            this.Genretb.TabIndex = 5;
            // 
            // ReleaseDatedtp
            // 
            this.ReleaseDatedtp.Location = new System.Drawing.Point(92, 45);
            this.ReleaseDatedtp.Name = "ReleaseDatedtp";
            this.ReleaseDatedtp.Size = new System.Drawing.Size(153, 23);
            this.ReleaseDatedtp.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Genre";
            // 
            // Nametb
            // 
            this.Nametb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Nametb.Location = new System.Drawing.Point(92, 16);
            this.Nametb.Name = "Nametb";
            this.Nametb.Size = new System.Drawing.Size(153, 23);
            this.Nametb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Release Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Synopsis";
            // 
            // Submitbtn
            // 
            this.Submitbtn.Location = new System.Drawing.Point(233, 440);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(75, 23);
            this.Submitbtn.TabIndex = 11;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = true;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // EditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 476);
            this.Controls.Add(this.Synopsistb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Submitbtn);
            this.Name = "EditMovie";
            this.Text = "Edit Movie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Synopsistb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Genretb;
        private System.Windows.Forms.DateTimePicker ReleaseDatedtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nametb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Submitbtn;
    }
}