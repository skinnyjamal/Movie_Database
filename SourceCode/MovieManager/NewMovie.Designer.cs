﻿
namespace MovieManager
{
    partial class NewMovie
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
            this.Submitbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ReleaseDatedtp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Nametb = new System.Windows.Forms.TextBox();
            this.Genretb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Synopsistb = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Ratingtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Submitbtn
            // 
            this.Submitbtn.Location = new System.Drawing.Point(234, 466);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(75, 23);
            this.Submitbtn.TabIndex = 6;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = true;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Synopsis";
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
            // Genretb
            // 
            this.Genretb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Genretb.Location = new System.Drawing.Point(92, 74);
            this.Genretb.Name = "Genretb";
            this.Genretb.Size = new System.Drawing.Size(153, 23);
            this.Genretb.TabIndex = 5;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Ratingtb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Genretb);
            this.groupBox1.Controls.Add(this.ReleaseDatedtp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Nametb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Synopsistb
            // 
            this.Synopsistb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Synopsistb.Location = new System.Drawing.Point(18, 171);
            this.Synopsistb.Name = "Synopsistb";
            this.Synopsistb.Size = new System.Drawing.Size(512, 289);
            this.Synopsistb.TabIndex = 10;
            this.Synopsistb.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "/10";
            // 
            // Ratingtb
            // 
            this.Ratingtb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Ratingtb.Location = new System.Drawing.Point(92, 104);
            this.Ratingtb.Name = "Ratingtb";
            this.Ratingtb.Size = new System.Drawing.Size(29, 23);
            this.Ratingtb.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "My Rating";
            // 
            // NewMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 501);
            this.Controls.Add(this.Synopsistb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Submitbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewMovie";
            this.Text = "New Movie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Submitbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ReleaseDatedtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nametb;
        private System.Windows.Forms.TextBox Genretb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox Synopsistb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Ratingtb;
        private System.Windows.Forms.Label label5;
    }
}