using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

/*
 * 
 * This is the drawing page that handles all the communication to the robot
 * 
 * Contents:
 * 3 buttons - start, abort and retake the image
 * IP address textbox
 * Progress bar
 * 
 * When the start button is pressed, a seperate thread will start sending the commands from the analyzed
 * image to the client object. In addition, the progress bar will use the number of points analyzed to update its UI
 * 
 * To send the coordinates in physical millimeters, the class will call functions to convert pixel coordinates to the physical dpi required
 * 
 * 
 */
namespace rembrandtRobotics {
    public partial class ImageDraw : UserControl {
        MainWindow window;
        ImageProcess imageProcess;
        Color lightBlue = Color.FromArgb ( 153, 176, 255 );

        public ImageDraw ( MainWindow temp ) {
            window = temp; // get reference to main window
            InitializeComponent ();
            imageProcess = ImageProcess.Instance; // image process instance
        }

        //calculate progress bar percent 
        private int progressBarSet ( int progressSum ) {
            double k = (double) progressSum / (double) imageProcess.countPoints (); //get ratio
            double result = k * 100; // get percentage
            return (int) result; // cast to int

        }

        //convert width pixel to physical coordinates
        private int convertWidth ( int x ) {
            double dpi = (double) imageProcess.getWidth () / 200;
            double distance = x / dpi;
            return (int) distance;
        }

        //convert height pixel to physical coordinates
        private int convertHeight ( int x ) {
            double dpi = (double) imageProcess.getHeight () / 150;
            double distance = x / dpi;
            return (int) distance;
        }

        //background worker thread
        void backgroundWorker1_DoWork ( object sender, DoWorkEventArgs e ) {
            try {
                BackgroundWorker worker = sender as BackgroundWorker;
                int progressSum = 0;
                Client client = new Client ( IPAddressTextBox.Text, 1234 ); //start client object
                List<List<Point>> contours = imageProcess.getSortedContours (); //get the sorted contours
                //client.servoCmd ( 0 ); // lift servo
                foreach ( List<Point> vector in contours ) {
                    client.writeCmd ( convertWidth ( vector[0].X ), convertHeight ( vector[0].Y ) ); // move servo to first coordinate of vector
                    //client.servoCmd ( 1 ); // drop servo
                    foreach ( Point point in vector ) {
                        client.writeCmd ( convertWidth ( point.X ), convertHeight ( point.Y ) ); // send coordinate command
                        Console.WriteLine ( convertWidth ( point.X ) + " , " + convertHeight ( point.Y ) );
                        while ( true ) {
                            if ( client.readCmd ().Contains ( "ERR" ) ) { // while queue is full resend the command
                                client.writeCmd ( convertWidth ( point.X ), convertHeight ( point.Y ) );
                            } else {
                                progressSum++; // increment num commands sent
                                worker.ReportProgress ( progressBarSet ( progressSum ) ); // update progress bar
                                break;
                            }
                        }
                    }
                    //client.servoCmd ( 0 ); // lift servo
                }
            } catch ( Exception ex ) {
                Console.WriteLine ( ex );
            }
        }

        //event for reporting progress
        private void backgroundWorker1_ProgressChanged ( object sender, ProgressChangedEventArgs e ) {
            progressBar1.Value = e.ProgressPercentage;
            progressBar1.Update (); // update progress bar UI
        }

        //click abort button
        private void abortBtn_Click ( object sender, EventArgs e ) {
            backgroundWorker1.CancelAsync (); // stop worker thread
            revealBtns ( true ); // reveal the other buttons 
        }

        //click start button and checks if connection is valid
        private void startBtn_Click ( object sender, EventArgs e ) {
            startBtn.Text = "Retry"; // change start button text
            revealBtns ( false );
            /*
            revealBtns ( false ); // hide the buttons
            Client client = new Client ( IPAddressTextBox.Text, 1234 ); //start client object
            abortBtn.Enabled = false; // diable abort button until connection valid
            if ( !client.isConnected () ) { // check if connection valid
                MessageBox.Show ( "Invalid Connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                revealBtns ( true );
                return;
            }
            abortBtn.Enabled = true;
            */
            if ( !backgroundWorker1.IsBusy )
                backgroundWorker1.RunWorkerAsync (); // start the worker thread
        }

        //functions for UI -------------------------------------------------------------------------------------------------------------
        private void btn_MouseEnter ( object sender, EventArgs e ) {
            var btn = sender as Label;
            btn.ForeColor = lightBlue;
        }

        private void btn_MouseLeave ( object sender, EventArgs e ) {
            var btn = sender as Label;
            btn.ForeColor = Color.Black;
        }

        //restart button
        private void newImageBtn_Click ( object sender, EventArgs e ) {
            imageProcess.clearImg ();
            window.hideDrawPage ();
        }

        //reveal the buttons 
        private void revealBtns ( bool show ) {
            if ( !show ) {
                revealStart ( false );
                revealAbort ( true );
                revealNewImage ( false );
                revealIP ( false );
            } else {
                revealStart ( true );
                revealAbort ( false );
                revealNewImage ( true );
                revealIP ( true );
            }
        }

        //reveal the start button
        private void revealStart ( bool show ) {
            if ( show ) {
                startBtn.Visible = true;
                startBtn.Enabled = true;
            } else {
                startBtn.Visible = false;
                startBtn.Enabled = false;
            }
        }

        //reveal the abort button
        private void revealAbort ( bool show ) {
            if ( show ) {
                abortBtn.Visible = true;
                abortBtn.Enabled = true;
            } else {
                abortBtn.Visible = false;
                abortBtn.Enabled = false;
            }
        }

        //reveal restart button
        private void revealNewImage ( bool show ) {
            if ( show ) {
                newImageBtn.Visible = true;
                newImageBtn.Enabled = true;
            } else {
                newImageBtn.Visible = false;
                newImageBtn.Enabled = false;
            }
        }

        //reveal IP address textbox
        private void revealIP ( bool show ) {
            if ( show ) {
                IPAddressTextBox.Visible = true;
                IPAddressTextBox.Enabled = true;
                IPAddressLabel.Visible = true;
                IPAddressLabel.Enabled = true;
            } else {
                IPAddressTextBox.Visible = false;
                IPAddressTextBox.Enabled = false;
                IPAddressLabel.Visible = false;
                IPAddressLabel.Enabled = false;
            }
        }


    }
}
