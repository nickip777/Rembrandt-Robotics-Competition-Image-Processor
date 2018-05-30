namespace rembrandtRobotics {
    partial class Start {
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
            this.splash_Title = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splash_Title
            // 
            this.splash_Title.AutoSize = true;
            this.splash_Title.BackColor = System.Drawing.Color.White;
            this.splash_Title.Font = new System.Drawing.Font("Coolvetica Rg", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splash_Title.ForeColor = System.Drawing.Color.Black;
            this.splash_Title.Location = new System.Drawing.Point(37, 169);
            this.splash_Title.Name = "splash_Title";
            this.splash_Title.Size = new System.Drawing.Size(569, 96);
            this.splash_Title.TabIndex = 0;
            this.splash_Title.Text = "Pacific Robotics";
            // 
            // startBtn
            // 
            this.startBtn.AutoSize = true;
            this.startBtn.BackColor = System.Drawing.Color.White;
            this.startBtn.Font = new System.Drawing.Font("Roboto Lt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.Black;
            this.startBtn.Location = new System.Drawing.Point(494, 265);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(99, 44);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            this.startBtn.MouseEnter += new System.EventHandler(this.startBtn_MouseEnter);
            this.startBtn.MouseLeave += new System.EventHandler(this.startBtn_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::rembrandtRobotics.Properties.Resources.hand_pencil_drawing_sketch_85140_1920x1080;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::rembrandtRobotics.Properties.Resources.hand_pencil_drawing_sketch_85140_1920x1080;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1100, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.splash_Title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Start";
            this.Size = new System.Drawing.Size(1100, 550);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label splash_Title;
        private System.Windows.Forms.Label startBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
