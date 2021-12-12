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
        Thread receiverThread;
        UdpClient udpClient = new UdpClient(8080);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            receiverThread = new Thread(new ThreadStart(runReciver));
            receiverThread.Start();
        }


        private void runReciver()
        {           
            while (true)
            {
                try
                {
                    IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 8080);
                    byte[] returnData = udpClient.Receive(ref iPEndPoint);
                    string Datareceiver = Encoding.ASCII.GetString(returnData);
                    Console.WriteLine(Encoding.ASCII.GetString(returnData));
                    this.Invoke(new MethodInvoker(delegate ()
                    {


                        listb_receiver.Items.Add(iPEndPoint.Address.ToString() + ": " + Datareceiver);
                        listb_receiver.SelectedIndex = listb_receiver.Items.Count - 1;
                        //listb_receiver.SelectedIndex = -1;


                    }));

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                    break;
                }
            }
        }

        private void btn_sent_Click(object sender, EventArgs e)
        {
            Console.WriteLine("press SENT or ENTER");
            udpClient.Connect(txb_ipAdress.Text, Convert.ToInt32(txb_port.Text));
            byte[] senddata = Encoding.ASCII.GetBytes(txb_message.Text);
            udpClient.Send(senddata, senddata.Length);
            txb_message.Text = "";

        }

        private void txb_message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_sent_Click(this,new EventArgs());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            receiverThread.Abort();
        }

        private void tim100_Tick(object sender, EventArgs e)
        {

        }
    }
}
