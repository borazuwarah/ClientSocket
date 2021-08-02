using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ClientSocket
{
    public partial class ClientSocket : Form
    {
        public ClientSocket()
        {
            InitializeComponent();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTextToServer.Text))
                MessageBox.Show("Please enter a message to continue ", "Message error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //conection
                Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                IPEndPoint connect = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6400);
                try
                {
                    listen.Connect(connect);
                    byte[] sendData = new byte[100];
                    string data;

                    data = txtTextToServer.Text;
                    sendData = Encoding.Default.GetBytes(data);

                    listen.Send(sendData);
                    //listen.Disconnect(true);
                    listen.Close();
                    // listen.Dispose();
                }
                catch (SocketException exception)
                {
                    //MessageBox.Show("Error: "+ exception.ToString());

                    MessageBox.Show("No active service detected in IP:" + connect.Address + " and port: " + connect.Port + "\n Please activate the server previously to continue",
                        "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
