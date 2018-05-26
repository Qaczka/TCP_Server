using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
namespace TCP_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private TcpListener server = null;
        private TcpClient client = null;

        private void start_Click(object sender, EventArgs e)
        {
            IPAddress AdressIP = null;
            try
            {
                AdressIP = IPAddress.Parse(adress.Text);
            }
            catch
            {
                MessageBox.Show("Wrong IP-ADRESS FORMAT", "Error");
                adress.Text = string.Empty;
                return;
            }
            int port = System.Convert.ToUInt16(myPort.Value);
            try
            {
                server = new TcpListener(AdressIP, port);
                server.Start();
                client = server.AcceptTcpClient();
                IPEndPoint IP = (IPEndPoint)client.Client.RemoteEndPoint;
                info_about_connections.Items.Add("Succesfully connected with !" +IP.ToString());
                start.Enabled = false;
                stop.Enabled = true;
                client.Close();
                server.Stop();
            }
            catch(Exception ex)
            {
                info_about_connections.Items.Add("Bad server intitiation!");
                MessageBox.Show(ex.ToString(), "Error");
            }
                
        }

        private void stop_Click(object sender, EventArgs e)
        {
            start.Enabled = true;
            server.Stop();
            client.Close();
            info_about_connections.Items.Add("Server has stopped");
            start.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
