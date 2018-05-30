namespace rembrandtRobotics {
    partial class CameraCapture {
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drawBtn = new System.Windows.Forms.Label();
            this.capBtn = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.heightTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.widthTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.drawBtn);
            this.splitContainer1.Panel2.Controls.Add(this.capBtn);
            this.splitContainer1.Panel2.Controls.Add(this.trackBar1);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 500);
            this.splitContainer1.SplitterDistance = 438;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer2.Size = new System.Drawing.Size(1100, 438);
            this.splitContainer2.SplitterDistance = 550;
            this.splitContainer2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(517, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(15, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pictureBox2.Size = new System.Drawing.Size(511, 390);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(694, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Width";
            // 
            // textBox2
            // 
            this.heightTextBox.Location = new System.Drawing.Point(694, 21);
            this.heightTextBox.Name = "textBox2";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 9;
            // 
            // textBox1
            // 
            this.widthTextBox.Location = new System.Drawing.Point(569, 22);
            this.widthTextBox.Name = "textBox1";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Detail";
            // 
            // drawBtn
            // 
            this.drawBtn.AutoSize = true;
            this.drawBtn.BackColor = System.Drawing.Color.White;
            this.drawBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawBtn.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawBtn.ForeColor = System.Drawing.Color.Black;
            this.drawBtn.Location = new System.Drawing.Point(1011, 13);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(67, 25);
            this.drawBtn.TabIndex = 4;
            this.drawBtn.Text = "Draw!";
            this.drawBtn.UseMnemonic = false;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            this.drawBtn.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.drawBtn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // capBtn
            // 
            this.capBtn.AutoSize = true;
            this.capBtn.BackColor = System.Drawing.Color.White;
            this.capBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.capBtn.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capBtn.ForeColor = System.Drawing.Color.Black;
            this.capBtn.Location = new System.Drawing.Point(867, 13);
            this.capBtn.Name = "capBtn";
            this.capBtn.Size = new System.Drawing.Size(86, 25);
            this.capBtn.TabIndex = 3;
            this.capBtn.Text = "Capture";
            this.capBtn.Click += new System.EventHandler(this.capBtn_Click);
            this.capBtn.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.capBtn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(127, 13);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.Size = new System.Drawing.Size(409, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 100;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // CameraCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Name = "CameraCapture";
            this.Size = new System.Drawing.Size(1100, 500);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label drawBtn;
        private System.Windows.Forms.Label capBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
    }
}
