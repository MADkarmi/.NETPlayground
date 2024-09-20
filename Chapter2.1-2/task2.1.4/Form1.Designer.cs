namespace task2._1._4
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
            this.smoothProgressBar1 = new SmoothProgressBar.SmoothProgressBar();
            this.smoothProgressBar2 = new SmoothProgressBar.SmoothProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.execute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // smoothProgressBar1
            // 
            this.smoothProgressBar1.Location = new System.Drawing.Point(12, 2);
            this.smoothProgressBar1.Maximum = 100;
            this.smoothProgressBar1.Minimum = 0;
            this.smoothProgressBar1.Name = "smoothProgressBar1";
            this.smoothProgressBar1.ProgressBarColor = System.Drawing.Color.Blue;
            this.smoothProgressBar1.Size = new System.Drawing.Size(693, 150);
            this.smoothProgressBar1.TabIndex = 0;
            this.smoothProgressBar1.Value = 0;
            // 
            // smoothProgressBar2
            // 
            this.smoothProgressBar2.Location = new System.Drawing.Point(12, 158);
            this.smoothProgressBar2.Maximum = 100;
            this.smoothProgressBar2.Minimum = 0;
            this.smoothProgressBar2.Name = "smoothProgressBar2";
            this.smoothProgressBar2.ProgressBarColor = System.Drawing.Color.Blue;
            this.smoothProgressBar2.Size = new System.Drawing.Size(693, 150);
            this.smoothProgressBar2.TabIndex = 1;
            this.smoothProgressBar2.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(725, 351);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(75, 23);
            this.execute.TabIndex = 2;
            this.execute.Text = "exec";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 386);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.smoothProgressBar2);
            this.Controls.Add(this.smoothProgressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SmoothProgressBar.SmoothProgressBar smoothProgressBar1;
        private SmoothProgressBar.SmoothProgressBar smoothProgressBar2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button execute;
    }
}

