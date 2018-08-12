using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpAdbClient;
using SharpAdbClient.DeviceCommands;

namespace AdbGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);
            AdbServer server = new AdbServer();
            var result = server.StartServer(@"adb\\adb.exe", restartServerIfNewer: false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var devices = AdbClient.Instance.GetDevices();

            foreach(var device in devices)
            {
                txtLogBox.Text = device.Model + " " + device.Serial;
            }
            if(txtLogBox.Text == "null" || txtLogBox.Text == "")
            {
                txtLogBox.Text = "Device not connected or detected.";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            Process.Start("https://twitter.com/javigracia");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = Directory.GetCurrentDirectory();
                txtLogBox.Text = openFileDialog1.FileName;
                ProcessStartInfo psi = new ProcessStartInfo(path + "\\adb\\adb.exe");
                psi.Arguments = "install "+ "\"" + txtLogBox.Text + "\"";
                psi.UseShellExecute = false;
                psi.RedirectStandardInput = true;

                // I don´t hide console window to use it like a reference of the installing process. When it close, the installation has finished.
                //psi.CreateNoWindow = true;

                Process p = Process.Start(psi);
                MessageBox.Show("App installed");
                p.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            ProcessStartInfo psi2 = new ProcessStartInfo("Wordpad.exe");
            psi2.Arguments = "\""+path+"\\docs\\README.rtf\"";
            Process p2 = Process.Start(psi2);
        }
    }
}
