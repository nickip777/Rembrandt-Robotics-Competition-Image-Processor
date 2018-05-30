using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;

/*
 * 
 * 
 * This is the camera capture function
 * Components:
 * 2 pictureboxes - 1 for camera stream, 1 for analyzed image
 * thresh bar - for user to specify the amount of detail
 * capture button - capture current image of camera stream
 * draw button - starts draw button page
 * 
 * 
 */
namespace rembrandtRobotics {
    public partial class CameraCapture : UserControl {
        int thresh = 100;
        MainWindow window;
        VideoCapture capture;
        ImageProcess imageProcess;
        Color lightBlue = Color.FromArgb ( 153, 176, 255 );

        public CameraCapture ( MainWindow temp ) {
            window = temp; // get main window reference
            InitializeComponent ();
            initializeCamera (); // initialize the camera
            trackBar1.Value = thresh; // intiialize default thresh value
            imageProcess = ImageProcess.Instance; // get singleton instance

        }

        // initialize camera function
        private void initializeCamera () {
            if ( capture == null ) {
                capture = new VideoCapture ( 0 );// grab camera
            }
            capture.ImageGrabbed += Capture_ImageGrabbed1; //get video stream
            capture.Start ();
        }

        //camera stream event
        private void Capture_ImageGrabbed1 ( object sender, EventArgs e ) {
            try {
                Mat m = new Mat ();
                capture.Retrieve ( m );
                pictureBox1.Image = m.ToImage<Bgr, byte> ().Bitmap; // send camera stream to picture box 1
            } catch ( Exception ex ) {
                Console.WriteLine ( ex );
            }
        }

        //click capture buton
        private void capBtn_Click ( object sender, EventArgs e ) {
            int n; // check for valid string
            if ( widthTextBox.Text.Equals ( "" ) || heightTextBox.Text.Equals ( "" ) ||
                 !int.TryParse ( widthTextBox.Text, out n ) || !int.TryParse ( heightTextBox.Text, out n ) ) {
                MessageBox.Show ( "Invalid Width and Height", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            if ( capture != null ) {
                try {

                    Mat s = new Mat (); // Mat for storing capture image
                    s = capture.QueryFrame ();
                    imageProcess.setSize ( int.Parse ( widthTextBox.Text ), int.Parse ( heightTextBox.Text ) ); //set the size of the image
                    imageProcess.setImg ( s, thresh ); // set image into singleton
                    pictureBox2.Image = imageProcess.getAnalyzedImg ().ToImage<Bgr, byte> ().Bitmap; // pass image into picture box
                } catch ( Exception ex ) {
                    Console.WriteLine ( ex );
                }
            }
        }

        //click draw button
        private void drawBtn_Click ( object sender, EventArgs e ) {
            if ( imageProcess.getMat () != null ) { // check if image exists
                capture.Dispose ();
                pictureBox1.Dispose ();
                pictureBox2.Dispose ();
                window.hideCapturePage (); // hide capture page and show draw page
            } else {
                MessageBox.Show ( "No Image Taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

        }

        // keeps track of trackbar value
        private void trackBar1_ValueChanged ( object sender, EventArgs e ) {
            thresh = trackBar1.Value;
        }

        //animations for UI
        private void btn_MouseEnter ( object sender, EventArgs e ) {
            var btn = sender as Label;
            btn.ForeColor = lightBlue;
        }

        private void btn_MouseLeave ( object sender, EventArgs e ) {
            var btn = sender as Label;
            btn.ForeColor = Color.Black;
        }
    }
}
