namespace H2V_Acid_2
{
    partial class Wowzers
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.randomButton = new System.Windows.Forms.Button();
            this.loopRandomButton = new System.Windows.Forms.Button();
            this.loopTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 12);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(776, 45);
            this.trackBar1.TabIndex = 0;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(12, 63);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(776, 45);
            this.trackBar2.TabIndex = 1;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(12, 114);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(776, 45);
            this.trackBar3.TabIndex = 2;
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(12, 165);
            this.trackBar4.Maximum = 255;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(776, 45);
            this.trackBar4.TabIndex = 3;
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(12, 216);
            this.trackBar5.Maximum = 255;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(776, 45);
            this.trackBar5.TabIndex = 4;
            // 
            // trackBar6
            // 
            this.trackBar6.Location = new System.Drawing.Point(12, 267);
            this.trackBar6.Maximum = 255;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(776, 45);
            this.trackBar6.TabIndex = 5;
            // 
            // trackBar7
            // 
            this.trackBar7.Location = new System.Drawing.Point(12, 318);
            this.trackBar7.Maximum = 255;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(776, 45);
            this.trackBar7.TabIndex = 6;
            // 
            // trackBar8
            // 
            this.trackBar8.Location = new System.Drawing.Point(12, 369);
            this.trackBar8.Maximum = 255;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Size = new System.Drawing.Size(776, 45);
            this.trackBar8.TabIndex = 7;
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(12, 420);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(364, 72);
            this.randomButton.TabIndex = 8;
            this.randomButton.Text = "Random";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // loopRandomButton
            // 
            this.loopRandomButton.Location = new System.Drawing.Point(424, 420);
            this.loopRandomButton.Name = "loopRandomButton";
            this.loopRandomButton.Size = new System.Drawing.Size(364, 72);
            this.loopRandomButton.TabIndex = 9;
            this.loopRandomButton.Text = "Random Loop";
            this.loopRandomButton.UseVisualStyleBackColor = true;
            this.loopRandomButton.Click += new System.EventHandler(this.loopRandomButton_Click);
            // 
            // loopTimer
            // 
            this.loopTimer.Interval = 10;
            this.loopTimer.Tick += new System.EventHandler(this.loopTimer_Tick);
            // 
            // Wowzers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.loopRandomButton);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.trackBar8);
            this.Controls.Add(this.trackBar7);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Wowzers";
            this.Text = "Cool Colors Man\'";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button loopRandomButton;
        private System.Windows.Forms.Timer loopTimer;
    }
}

