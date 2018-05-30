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
 * This is the main window 
 * It contains a user control panel and it acts as a page navigator
 * these pages are the splash, camera capture and the draw page
 * this page also initializes the singleton containing the image process functions
 * 
 */
namespace rembrandtRobotics {
    public partial class MainWindow : Form {
        //create page variables
        Start startPage;
        CameraCapture capturePage;
        ImageDraw drawPage;


        public MainWindow () {
            InitializeComponent ();
            showStartPage ();//show start page
            var imageProcess = ImageProcess.Instance; // instantiate singleton

        }

        //hide start page
        public void hideStartPage () {
            panel1.Controls.Remove ( startPage ); // remove start page from user control
            startPage.Dispose ();
            showCapturePage (); // show capture page
        }

        //show start page
        public void showStartPage () {
            startPage = new Start ( this );
            panel1.Controls.Add ( startPage ); // add start page to user control
        }

        //show capture page
        public void showCapturePage () {
            capturePage = new CameraCapture ( this );
            panel1.Controls.Add ( capturePage ); // add capture page to user control
        }

        //hide capture page
        public void hideCapturePage () {
            panel1.Controls.Remove ( capturePage ); // remove capture page from user control
            capturePage.Dispose ();
            showDrawPage (); // show draw page
        }

        //show draw page
        public void showDrawPage () {
            drawPage = new ImageDraw ( this );
            panel1.Controls.Add ( drawPage ); // add draw page to user control
        }

        //hide draw page
        public void hideDrawPage () {
            panel1.Controls.Remove ( drawPage ); // remove draw page from user control
            drawPage.Dispose ();
            showStartPage (); // show start page
        }
    }
}
