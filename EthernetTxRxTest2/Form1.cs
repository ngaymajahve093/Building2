using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EthernetTxRxTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Thread receiverThread = new Thread(new ThreadStart(runReciver));
            receiverThread.Start();
        }


        private void runReciver()
        {
            UdpClient udpClient =new UdpClient(8080);
            while (true)
            {
                try
                {
                    IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 8080);
                    byte[] returnData = udpClient.Receive(ref iPEndPoint);
                    Console.WriteLine(returnData.ToString());
                    Console.WriteLine(Encoding.ASCII.GetString(returnData));

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                    break;
                }
            }
        }
    }
}
