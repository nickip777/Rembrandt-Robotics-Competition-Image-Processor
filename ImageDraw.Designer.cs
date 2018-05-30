namespace rembrandtRobotics {
    partial class ImageDraw {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.IPAddressTextBox = new System.Windows.Forms.TextBox();
            this.IPAddressLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.startBtn = new System.Windows.Forms.Label();
            this.abortBtn = new System.Windows.Forms.Label();
            this.newImageBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(301, 219);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(516, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // IPAddressTextBox
            // 
            this.IPAddressTextBox.Location = new System.Drawing.Point(365, 189);
            this.IPAddressTextBox.Name = "IPAddressTextBox";
            this.IPAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.IPAddressTextBox.TabIndex = 3;
            // 
            // IPAddressLabel
            // 
            this.IPAddressLabel.AutoSize = true;
            this.IPAddressLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPAddressLabel.Location = new System.Drawing.Point(298, 193);
            this.IPAddressLabel.Name = "IPAddressLabel";
            this.IPAddressLabel.Size = new System.Drawing.Size(61, 13);
            this.IPAddressLabel.TabIndex = 4;
            this.IPAddressLabel.Text = "IP Address";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // startBtn
            // 
            this.startBtn.AutoSize = true;
            this.startBtn.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(501, 270);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(88, 38);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Start";
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            this.startBtn.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.startBtn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // abortBtn
            // 
            this.abortBtn.AutoSize = true;
            this.abortBtn.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abortBtn.Location = new System.Drawing.Point(501, 270);
            this.abortBtn.Name = "abortBtn";
            this.abortBtn.Size = new System.Drawing.Size(95, 38);
            this.abortBtn.TabIndex = 7;
            this.abortBtn.Text = "Abort";
            this.abortBtn.Click += new System.EventHandler(this.abortBtn_Click);
            this.abortBtn.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.abortBtn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // newImageBtn
            // 
            this.newImageBtn.AutoSize = true;
            this.newImageBtn.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newImageBtn.Location = new System.Drawing.Point(441, 327);
            this.newImageBtn.Name = "newImageBtn";
            this.newImageBtn.Size = new System.Drawing.Size(214, 38);
            this.newImageBtn.TabIndex = 8;
            this.newImageBtn.Text = "Retake Image";
            this.newImageBtn.Click += new System.EventHandler(this.newImageBtn_Click);
            this.newImageBtn.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.newImageBtn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // ImageDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.newImageBtn);
            this.Controls.Add(this.abortBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.IPAddressLabel);
            this.Controls.Add(this.IPAddressTextBox);
            this.Controls.Add(this.progressBar1);
            this.Name = "ImageDraw";
            this.Size = new System.Drawing.Size(1100, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox IPAddressTextBox;
        private System.Windows.Forms.Label IPAddressLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label startBtn;
        private System.Windows.Forms.Label abortBtn;
        private System.Windows.Forms.Label newImageBtn;
    }
}
