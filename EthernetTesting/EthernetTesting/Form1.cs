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
using System.Threading;
using System.Net;

namespace EthernetTesting
{
   public partial class Form1 : Form
   {
      int m_ReadPort = 5002, m_WritePort = 5002;
      TcpClient m_ReadClient = null, m_WriteClient = null;
      NetworkStream m_ReadStream = null, m_WriteStream = null;
      public Form1()
      {
         InitializeComponent();
         button1.Location = new Point(btnInitPort.Location.X, btnInitPort.Location.Y+btnInitPort.Size.Height);
      }

      private void btnInitPort_Click(object sender, EventArgs e)
      {
         try
         {
            IPAddress ipadd;
            IPAddress.TryParse(textBoxX2.Text, out ipadd);
            int.TryParse(textBoxX1.Text, out m_ReadPort);
            int.TryParse(textBoxX1.Text, out m_WritePort);
            m_ReadClient = new TcpClient(ipadd.ToString(), m_ReadPort);
            m_ReadStream = m_ReadClient.GetStream();
            m_WriteClient = new TcpClient(ipadd.ToString(), m_WritePort);
            m_WriteStream = m_WriteClient.GetStream();
            m_ReadClient.ReceiveTimeout = 5000;
            m_WriteClient.SendTimeout = 5000;
            if ((m_ReadClient.Connected) && (m_WriteClient.Connected))
            {
               Statuslbl.Text = "Port Initilized Successfully";
            }
            else
               Statuslbl.Text = "Port failed Initilize";
         }
         catch (Exception ex)
         {
            MessageBox.Show("Ethernet communication Error");
            Statuslbl.Text = "Port failed Initilize";
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         byte[] onsend = new byte[1024];
         try
         {
            byte[] dataBuffer = new byte[1024];

            if (string.IsNullOrEmpty(txtpayload.Text)) return;
            dataBuffer = Encoding.ASCII.GetBytes(txtpayload.Text);
            for (int i = 0; i < dataBuffer.Length; i++)
            {
               onsend[i] = dataBuffer[i];
            }
            if (m_ReadClient != null)
            {
               if (m_ReadClient.Client.Connected)
               {
                  m_ReadStream.Write(dataBuffer, 0, dataBuffer.Length);
               }

            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Ethernet communication Error");
         }
      }

      private void button2_Click(object sender, EventArgs e)
      {
         try
         {
            byte[] dataBuffer = new byte[1024];
            while (true)
            {
               dataBuffer = new byte[1024];
               m_ReadStream.Write(dataBuffer, 0, dataBuffer.Length);
               Thread.Sleep(30);
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Ethernet communication Error");
         }
        
      }

   }
}
