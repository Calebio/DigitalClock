namespace DigitalClock
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
            this.components = new System.ComponentModel.Container();
            this.DcTime = new System.Windows.Forms.Label();
            this.DcDay = new System.Windows.Forms.Label();
            this.DcDate = new System.Windows.Forms.Label();
            this.DcSeconds = new System.Windows.Forms.Label();
            this.DcTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // DcTime
            // 
            this.DcTime.AutoSize = true;
            this.DcTime.BackColor = System.Drawing.Color.Transparent;
            this.DcTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DcTime.Font = new System.Drawing.Font("Chiller", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DcTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DcTime.Location = new System.Drawing.Point(48, 52);
            this.DcTime.Name = "DcTime";
            this.DcTime.Size = new System.Drawing.Size(238, 113);
            this.DcTime.TabIndex = 1;
            this.DcTime.Text = "22:22";
            // 
            // DcDay
            // 
            this.DcDay.AutoSize = true;
            this.DcDay.BackColor = System.Drawing.Color.Transparent;
            this.DcDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DcDay.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DcDay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DcDay.Location = new System.Drawing.Point(292, 265);
            this.DcDay.Name = "DcDay";
            this.DcDay.Size = new System.Drawing.Size(133, 58);
            this.DcDay.TabIndex = 2;
            this.DcDay.Text = "Monday";
            // 
            // DcDate
            // 
            this.DcDate.AutoSize = true;
            this.DcDate.BackColor = System.Drawing.Color.Transparent;
            this.DcDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DcDate.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DcDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DcDate.Location = new System.Drawing.Point(48, 265);
            this.DcDate.Name = "DcDate";
            this.DcDate.Size = new System.Drawing.Size(235, 58);
            this.DcDate.TabIndex = 3;
            this.DcDate.Text = "June 25 2019";
            // 
            // DcSeconds
            // 
            this.DcSeconds.AutoSize = true;
            this.DcSeconds.BackColor = System.Drawing.Color.Transparent;
            this.DcSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DcSeconds.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DcSeconds.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DcSeconds.Location = new System.Drawing.Point(292, 129);
            this.DcSeconds.Name = "DcSeconds";
            this.DcSeconds.Size = new System.Drawing.Size(41, 36);
            this.DcSeconds.TabIndex = 4;
            this.DcSeconds.Text = "22";
            // 
            // DcTimer
            // 
            this.DcTimer.Interval = 1000;
            this.DcTimer.Tick += new System.EventHandler(this.DcTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(502, 446);
            this.Controls.Add(this.DcSeconds);
            this.Controls.Add(this.DcDate);
            this.Controls.Add(this.DcDay);
            this.Controls.Add(this.DcTime);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DcTime;
        private System.Windows.Forms.Label DcDay;
        private System.Windows.Forms.Label DcDate;
        private System.Windows.Forms.Label DcSeconds;
        private System.Windows.Forms.Timer DcTimer;
    }
}

