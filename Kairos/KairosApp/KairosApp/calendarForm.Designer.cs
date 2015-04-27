namespace KairosApp
{
    partial class calendarForm
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.sermonsLabel = new System.Windows.Forms.Label();
            this.whatIsLove = new System.Windows.Forms.Label();
            this.alphaAndOmega = new System.Windows.Forms.Label();
            this.christHasRisen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(30, 13);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // sermonsLabel
            // 
            this.sermonsLabel.AutoSize = true;
            this.sermonsLabel.Location = new System.Drawing.Point(115, 184);
            this.sermonsLabel.Name = "sermonsLabel";
            this.sermonsLabel.Size = new System.Drawing.Size(51, 13);
            this.sermonsLabel.TabIndex = 1;
            this.sermonsLabel.Text = "Sermons:";
            this.sermonsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // whatIsLove
            // 
            this.whatIsLove.AutoSize = true;
            this.whatIsLove.Location = new System.Drawing.Point(89, 232);
            this.whatIsLove.Name = "whatIsLove";
            this.whatIsLove.Size = new System.Drawing.Size(105, 13);
            this.whatIsLove.TabIndex = 2;
            this.whatIsLove.Text = "4/19: What is Love?";
            // 
            // alphaAndOmega
            // 
            this.alphaAndOmega.AutoSize = true;
            this.alphaAndOmega.Location = new System.Drawing.Point(89, 219);
            this.alphaAndOmega.Name = "alphaAndOmega";
            this.alphaAndOmega.Size = new System.Drawing.Size(121, 13);
            this.alphaAndOmega.TabIndex = 3;
            this.alphaAndOmega.Text = "4/12: Alpha and Omega";
            // 
            // christHasRisen
            // 
            this.christHasRisen.AutoSize = true;
            this.christHasRisen.Location = new System.Drawing.Point(89, 206);
            this.christHasRisen.Name = "christHasRisen";
            this.christHasRisen.Size = new System.Drawing.Size(106, 13);
            this.christHasRisen.TabIndex = 4;
            this.christHasRisen.Text = "4/5: Christ has Risen";
            // 
            // calendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 273);
            this.Controls.Add(this.christHasRisen);
            this.Controls.Add(this.alphaAndOmega);
            this.Controls.Add(this.whatIsLove);
            this.Controls.Add(this.sermonsLabel);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "calendarForm";
            this.Text = "calendarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label sermonsLabel;
        private System.Windows.Forms.Label whatIsLove;
        private System.Windows.Forms.Label alphaAndOmega;
        private System.Windows.Forms.Label christHasRisen;
    }
}