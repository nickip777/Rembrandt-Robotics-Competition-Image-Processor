using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * 
 *this is the splash page
 * The only function is the start button
 * 
 * 
 */
namespace rembrandtRobotics {
    public partial class Start : UserControl {
        MainWindow window;
        Color lightBlue = Color.FromArgb ( 153, 176, 255 );
        public Start ( MainWindow temp ) {
            window = temp; // get ref to the main window
            InitializeComponent ();
        }

        //click the start button
        private void startBtn_Click ( object sender, EventArgs e ) {
            window.hideStartPage (); // hide the start page and show the capture page
        }

        // events for UI animations------------------------------------------------------------------------------------------------------------------------
        private void startBtn_MouseEnter ( object sender, EventArgs e ) {
            startBtn.ForeColor = lightBlue;
        }

        private void startBtn_MouseLeave ( object sender, EventArgs e ) {
            startBtn.ForeColor = Color.Black;
        }

    }
}
