namespace MovieAPI
{
    partial class Form1
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
            this.title = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.moviePlot = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.movieActors = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(218, 67);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 22);
            this.title.TabIndex = 0;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(404, 67);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 22);
            this.year.TabIndex = 1;
            // 
            // moviePlot
            // 
            this.moviePlot.Location = new System.Drawing.Point(169, 155);
            this.moviePlot.Multiline = true;
            this.moviePlot.Name = "moviePlot";
            this.moviePlot.Size = new System.Drawing.Size(469, 265);
            this.moviePlot.TabIndex = 2;
            // 
            // search
            // 
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.search.Location = new System.Drawing.Point(563, 67);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Plot";
            // 
            // movieActors
            // 
            this.movieActors.Location = new System.Drawing.Point(715, 155);
            this.movieActors.Multiline = true;
            this.movieActors.Name = "movieActors";
            this.movieActors.Size = new System.Drawing.Size(115, 265);
            this.movieActors.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(715, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Actors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 488);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.movieActors);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.moviePlot);
            this.Controls.Add(this.year);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox moviePlot;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox movieActors;
        private System.Windows.Forms.Label label4;
    }
}

