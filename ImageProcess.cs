using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.IO;

/*
 * 
 * This is the main singleton that handles all the image processing
 * it contains the mat and all the vector points necessary for image processing
 * it also sorts the contours for maximum efficiency
 * 
 * 
 * 
 */
namespace rembrandtRobotics {
    public class ImageProcess {
        private VectorOfVectorOfPoint contours;
        private Mat img;
        private static ImageProcess instance;
        private List<List<Point>> sortedContours; // final contour points
        private int width = 500;
        private int height = 500;

        //constructor
        private ImageProcess () {
            sortedContours = new List<List<Point>> ();

        }

        //Singleton instance
        public static ImageProcess Instance {
            get {
                if ( instance == null ) {
                    instance = new ImageProcess ();
                }
                return instance;
            }

        }

        // count total number of points
        public int countPoints () {
            int sum = 0;
            foreach ( List<Point> vector in sortedContours ) {
                sum += vector.Count;
            }
            return sum;
        }

        //set the size of the image
        public void setSize ( int width, int height ) {
            this.width = width;
            this.height = height;
        }

        //get the width of the image
        public int getWidth () {
            return width;
        }

        //get the height of the image
        public int getHeight () {
            return height;
        }

        // get the sorted contours
        public List<List<Point>> getSortedContours () {
            return sortedContours;
        }

        // get the current mat image
        public Mat getMat () {
            return img;
        }

        //clear the image
        public void clearImg () {
            img = null;
        }

        //get the analyzed image for the display in the capture page
        public Mat getAnalyzedImg () {
            using ( Mat hierarchy = new Mat () ) {
                for ( int i = 0; i < contours.Size; i++ ) {
                    MCvScalar color = new MCvScalar ( 255, 255, 255 );
                    CvInvoke.DrawContours ( img, contours, i, color, 2, Emgu.CV.CvEnum.LineType.EightConnected, hierarchy, 0 ); // draw the contours onto the empty mat
                }
            }
            return img;
        }


        //set the image from the capture page into the image processing class
        public void setImg ( Mat cameraImg, int thresh ) {
            contours = new VectorOfVectorOfPoint ();
            Mat imgResize = new Mat (); // resize the mat
            Size size = new Size ( width, height );
            CvInvoke.Resize ( cameraImg, imgResize, size );
            Mat img_gray = new Mat ();
            Mat canny_output = new Mat ();
            CvInvoke.CvtColor ( imgResize, img_gray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray ); // convert to grayscale
            CvInvoke.Blur ( img_gray, img_gray, new System.Drawing.Size ( 3, 3 ), new Point ( -1, -1 ) ); // gaussian blur
            CvInvoke.Canny ( img_gray, canny_output, thresh, thresh * 3, 3 ); // create the canny
            using ( Mat hierarchy = new Mat () ) {
                //find the contours
                CvInvoke.FindContours ( canny_output, contours, hierarchy, Emgu.CV.CvEnum.RetrType.Tree, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple );
                img = new Mat ( canny_output.Size, Emgu.CV.CvEnum.DepthType.Cv8U, 3 ); // set the image
            }
            contourSort (); // sort the contours
        }

        //sort contours
        public void contourSort () {
            sortedContours.Clear ();
            List<List<Point>> list = arrToList ( contours.ToArrayOfArray () );
            sortedContours.Add ( extractVector ( list, 0 ) );// extract the first vector
            while ( list.Count != 0 ) {
                int save = 0;
                //find the closest vector
                for ( int i = 1; i < list.Count; i++ ) {
                    if ( isVectorCloser ( sortedContours.Last (), list[i], list[save] ) ) {
                        save = i;
                    }
                }
                //sort and insert vector into contours object
                contourSortInsert ( ref sortedContours, extractVector ( list, save ) );
            }
        }

        // determine which order vector should be added to contours
        private void contourSortInsert ( ref List<List<Point>> contours, List<Point> vector ) {
            if ( vector.Count < 5 ) {
                return;
            }
            if ( isReverse ( contours.Last (), vector ) ) {
                vector.Reverse ();
                contours.Add ( vector );
            } else {
                contours.Add ( vector );
            }
        }

        // extract the vector from the list
        private List<Point> extractVector ( List<List<Point>> list, int index ) {
            List<Point> vector = list.ElementAt ( index );
            list.RemoveAt ( index );
            return vector;
        }

        // determine if vector should be reversed
        private bool isReverse ( List<Point> origin, List<Point> vector ) {
            if ( isPointCloser ( origin.Last (), vector.First (), vector.Last () ) ) {
                return true;
            } else {
                return false;
            }
        }

        // compare which vector is closer
        private bool isVectorCloser ( List<Point> origin, List<Point> vector1, List<Point> vector2 ) {
            Point startPoint = origin.Last ();
            double vector1Distance;
            double vector2Distance;
            if ( isPointCloser ( startPoint, vector1.First (), vector1.Last () ) ) {
                vector1Distance = hyp ( startPoint, vector1.First () );
            } else {
                vector1Distance = hyp ( startPoint, vector1.Last () );
            }
            if ( isPointCloser ( startPoint, vector2.First (), vector2.Last () ) ) {
                vector2Distance = hyp ( startPoint, vector2.First () );
            } else {
                vector2Distance = hyp ( startPoint, vector2.Last () );
            }
            if ( vector1Distance < vector2Distance ) {
                return true;
            } else {
                return false;
            }
        }

        //determine which point is closer
        private bool isPointCloser ( Point origin, Point closerPoint, Point farPoint ) {
            if ( hyp ( origin, closerPoint ) < hyp ( origin, farPoint ) || hyp ( origin, closerPoint ) == hyp ( origin, farPoint ) ) {
                return true;
            }
            return false;
        }

        //calculate the hypotenuse
        private double hyp ( Point a, Point b ) {
            int x = b.X - a.X;
            int y = b.Y - a.Y;
            return Math.Sqrt ( x * x + y * y );
        }

        // convert arr to list
        private List<List<Point>> arrToList ( Point[][] arr ) {
            List<List<Point>> list = new List<List<Point>> ();
            foreach ( Point[] arr2 in arr ) {
                list.Add ( arr2.ToList () );
            }
            return list;
        }

    }
}
