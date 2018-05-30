using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Configuration;

namespace rembrandtRobotics {
    class Client {
        private TcpClient client;
        public Client ( string host, int port ) {
            connect ( host, port );
        }

        //function to write coordinate command
        public void writeCmd ( int x, int y ) {
            try {
                NetworkStream nwStream = client.GetStream (); // get network stream
                string text = "AT!MTR_CMD=GOTO," + x.ToString () + "," + y.ToString (); // coordinate command
                byte[] msg = ASCIIEncoding.ASCII.GetBytes ( text );
                Console.WriteLine ( "Sending : " + text );
                nwStream.Write ( msg, 0, msg.Length ); // write command to stream
            } catch ( Exception e ) {
                Console.WriteLine ( e );
            }
        }

        //function to activate servo, 1 is drop servo, 0 is lift
        public void servoCmd ( int x ) {
            try {
                NetworkStream nwStream = client.GetStream (); // get client stream
                string text = "AT!MTR_CMD=SERVO," + x; // client message
                byte[] msg = ASCIIEncoding.ASCII.GetBytes ( text );
                Console.WriteLine ( "Sending : " + text );
                nwStream.Write ( msg, 0, msg.Length ); // write message
            } catch ( Exception e ) {
                Console.WriteLine ( e );
            }
        }

        //function for reading the commands
        public string readCmd () {
            string msgRead = null;
            try {
                NetworkStream nwStream = client.GetStream (); // get client stream
                byte[] msgReceiver = new byte[client.ReceiveBufferSize]; // get msg in bytes
                int bytesRead = nwStream.Read ( msgReceiver, 0, client.ReceiveBufferSize ); // count num bytes read
                msgRead = Encoding.ASCII.GetString ( msgReceiver, 0, bytesRead ); //convert byte msg to string
                Console.WriteLine ( "Received : " + msgRead );
            } catch ( Exception e ) {
                Console.WriteLine ( e );
            }
            return msgRead;
        }

        // function for intializing connection
        public bool connect ( string host, int port ) {
            try {
                client = new TcpClient ( host, port );
            } catch ( Exception e ) {
                Console.WriteLine ( e );
                return false;
            }
            return true;
        }

        //boolean for if tcp client is connected
        public bool isConnected () {
            if ( client == null ) {
                return false;
            } else {
                return true;
            }
        }
    }
}

