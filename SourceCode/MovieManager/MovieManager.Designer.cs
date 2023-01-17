
namespace MovieManager
{
    partial class MovieManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Movielb = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Synopsislbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Genrelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Releaselbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newMoviebtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Movielb
            // 
            this.Movielb.FormattingEnabled = true;
            this.Movielb.ItemHeight = 15;
            this.Movielb.Location = new System.Drawing.Point(12, 12);
            this.Movielb.Name = "Movielb";
            this.Movielb.Size = new System.Drawing.Size(180, 274);
            this.Movielb.TabIndex = 0;
            this.Movielb.SelectedIndexChanged += new System.EventHandler(this.Movielb_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Synopsislbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Genrelbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Releaselbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Namelbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(206, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 232);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie Info";
            // 
            // Synopsislbl
            // 
            this.Synopsislbl.AutoSize = true;
            this.Synopsislbl.Location = new System.Drawing.Point(123, 125);
            this.Synopsislbl.Name = "Synopsislbl";
            this.Synopsislbl.Size = new System.Drawing.Size(37, 15);
            this.Synopsislbl.TabIndex = 7;
            this.Synopsislbl.Text = "------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Synopsis";
            // 
            // Genrelbl
            // 
            this.Genrelbl.AutoSize = true;
            this.Genrelbl.Location = new System.Drawing.Point(123, 95);
            this.Genrelbl.Name = "Genrelbl";
            this.Genrelbl.Size = new System.Drawing.Size(37, 15);
            this.Genrelbl.TabIndex = 5;
            this.Genrelbl.Text = "------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Genre";
            // 
            // Releaselbl
            // 
            this.Releaselbl.AutoSize = true;
            this.Releaselbl.Location = new System.Drawing.Point(123, 65);
            this.Releaselbl.Name = "Releaselbl";
            this.Releaselbl.Size = new System.Drawing.Size(37, 15);
            this.Releaselbl.TabIndex = 3;
            this.Releaselbl.Text = "------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Release Date";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(123, 35);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(37, 15);
            this.Namelbl.TabIndex = 1;
            this.Namelbl.Text = "------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // newMoviebtn
            // 
            this.newMoviebtn.Location = new System.Drawing.Point(532, 12);
            this.newMoviebtn.Name = "newMoviebtn";
            this.newMoviebtn.Size = new System.Drawing.Size(75, 38);
            this.newMoviebtn.TabIndex = 2;
            this.newMoviebtn.Text = "Add New Movie";
            this.newMoviebtn.UseVisualStyleBackColor = true;
            this.newMoviebtn.Click += new System.EventHandler(this.newMoviebtn_Click);
            // 
            // MovieManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 294);
            this.Controls.Add(this.newMoviebtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Movielb);
            this.Name = "MovieManager";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Movielb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Genrelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Releaselbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Synopsislbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newMoviebtn;
    }
}

