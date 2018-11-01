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
        public string appSelected = "";
        public string saveSelected = "";
        public String[] listaAppsProtected = {"com.oculus.systemactivities", "com.oculus.vrshell", "com.oculusvr.dabmobile", "samsung", "google", "android" };
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            AdbServer server = new AdbServer();
            var result = server.StartServer(@"adb\\adb.exe", restartServerIfNewer: false);

        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            ProcessStartInfo psi = new ProcessStartInfo(path + "\\adb\\adb.exe");
            psi.Arguments = "kill-server";
            psi.UseShellExecute = false;
            psi.RedirectStandardInput = true;
            psi.CreateNoWindow = true;
            Process p = Process.Start(psi);
            p.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var devices = AdbClient.Instance.GetDevices();

            foreach (var device in devices)
            {
                txtLogBox.Text = device.Model + " " + device.Serial;
            }
            if (txtLogBox.Text == "null" || txtLogBox.Text == "")
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
                psi.Arguments = "install " + "\"" + txtLogBox.Text + "\"";
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
            psi2.Arguments = "\"" + path + "\\docs\\README.rtf\"";
            Process p2 = Process.Start(psi2);
            p2.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var device = AdbClient.Instance.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand("ls -x1 /sdcard/Android/data", device, receiver);
            txtLogBox.Text =
                "Ocultadas apps en el comboBox que puedan proceder de android(sistema), samsung o google para evitar borrados por error. En el Log se pueden ver todas las apps sin filtrar\r\n-----------\r\nHidden apps in the comboBox that can come from android(system), samsung or google to avoid being deleted by mistake. In the Log you can see all the unfiltered apps\r\n-----------\r\n";
            txtLogBox.Text = txtLogBox.Text + receiver;
            string temp = receiver.ToString().Replace("\r\n", "-");
            Char delimiter = '-';
            String[] listaApps = temp.Split(delimiter);
            comboBox1.Items.Clear();
            var res = listaApps.Where(s => !listaAppsProtected.Any(ignored => s.Contains(ignored))).ToList();
            foreach (var item in res)
            {
                comboBox1.Items.Add(item);
            }
        }

        //public static string ReducirEspacios(string cadena)
        //{
        //    while (cadena.Contains("  "))
        //    {
        //        cadena = cadena.Replace("  ", " ");
        //    }
        //    return cadena;
        //}
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            appSelected = comboBox1.SelectedItem.ToString();
            txtLogBox.Clear();
            txtLogBox.Text = appSelected;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to Uninstall " + appSelected + "?", "Confirm to Uninstall it",
                MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                string path = Directory.GetCurrentDirectory();
                txtLogBox.Text = openFileDialog1.FileName;
                ProcessStartInfo psi = new ProcessStartInfo(path + "\\adb\\adb.exe");
                psi.Arguments = "uninstall " + "\"" + appSelected + "\"";
                psi.UseShellExecute = false;
                psi.RedirectStandardInput = true;
                Process p = Process.Start(psi);
                txtLogBox.Clear();
                txtLogBox.Text = appSelected + "uninstalled";
                p.Close();
            }
            else
            {
                txtLogBox.Clear();
                txtLogBox.Text = "Operation Cancelled!!";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var device = AdbClient.Instance.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureWidth 1024", device, receiver);
            txtLogBox.Clear();
            txtLogBox.Text = "Width resolution changed to 1024.";
            AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureHeight 1024", device, receiver);
            txtLogBox.Text = txtLogBox.Text + "\r\nHeight resolution changed to 1024.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var device = AdbClient.Instance.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureWidth 1536", device, receiver);
            txtLogBox.Clear();
            txtLogBox.Text = "Width resolution changed to 1536.";
            AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureHeight 1536", device, receiver);
            txtLogBox.Text = txtLogBox.Text + "\r\nHeight resolution changed to 1536.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var device = AdbClient.Instance.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureWidth 2048", device, receiver);
            txtLogBox.Clear();
            txtLogBox.Text = "Width resolution changed to 2048.";
            AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureHeight 2048", device, receiver);
            txtLogBox.Text = txtLogBox.Text + "\r\nHeight resolution changed to 2048.";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("You are going to raise the cpu and gpu to lvl 4. Refrigeration is required.", "Do you want to continue?",
                MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                var device = AdbClient.Instance.GetDevices().First();
                var receiver = new ConsoleOutputReceiver();
                AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureWidth 2560", device, receiver);
                txtLogBox.Clear();
                txtLogBox.Text = "Width resolution changed to 2560.";
                AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureHeight 2560", device, receiver);
                AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.gpuLevel 4", device, receiver);
                AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.cpuLevel 4", device, receiver);
                AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.adaclocks.force 0", device, receiver);
                txtLogBox.Text = txtLogBox.Text + "\r\nHeight resolution changed to 2560.\r\nThe cpu and gpu is upgrade to level 4.\r\nAll the changes will reset if you restart yout Oculus Go.";
            }
            else
            {
                txtLogBox.Clear();
                txtLogBox.Text = "Operation Cancelled!!";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("You are going to raise the cpu and gpu to lvl 2. Refrigeration is recommended.", "Do you want to continue?",
                MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                var device = AdbClient.Instance.GetDevices().First();
                var receiver = new ConsoleOutputReceiver();
                AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureWidth 2048", device, receiver);
                txtLogBox.Clear();
                txtLogBox.Text = "Width resolution changed to 2048.";
                AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureHeight 2048", device, receiver);
                AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.gpuLevel 2", device, receiver);
                AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.cpuLevel 2", device, receiver);
                AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.adaclocks.force 0", device, receiver);
                txtLogBox.Text = txtLogBox.Text + "\r\nHeight resolution changed to 2048.\r\nThe cpu and gpu is upgrade to level 2.\r\nAll the changes will reset if you restart yout Oculus Go.";
            }
            else
            {
                txtLogBox.Clear();
                txtLogBox.Text = "Operation Cancelled!!";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("You are going to raise the cpu and gpu to lvl 4 and the highest resolution. Only use it if you have EXTRA REFRIGERATION or your Oculus Go will be restarted.", "Do you want to continue?",
                MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                var device = AdbClient.Instance.GetDevices().First();
                var receiver = new ConsoleOutputReceiver();
                AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureWidth 3072", device, receiver);
                txtLogBox.Clear();
                txtLogBox.Text = "Width resolution changed to 3072.";
                AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureHeight 3072", device, receiver);
                AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.gpuLevel 4", device, receiver);
                AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.cpuLevel 4", device, receiver);
                AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.adaclocks.force 0", device, receiver);
                txtLogBox.Text = txtLogBox.Text + "\r\nHeight resolution changed to 3072.\r\nThe cpu and gpu is upgrade to level 4.\r\nAll the changes will reset if you restart yout Oculus Go.";
            }
            else
            {
                txtLogBox.Clear();
                txtLogBox.Text = "Operation Cancelled!!";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var device = AdbClient.Instance.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.forceChroma 1", device, receiver);
            txtLogBox.Clear();
            txtLogBox.Text = "Chromatic aberration fix ON.";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var device = AdbClient.Instance.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.forceChroma 0", device, receiver);
            txtLogBox.Clear();
            txtLogBox.Text = "Chromatic aberration fix OFF.";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var device = AdbClient.Instance.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand("ls -x1 /sdcard/Android/data", device, receiver);
            txtLogBox.Text =
                "Ocultadas apps en el comboBox que puedan proceder de android(sistema), samsung o google para evitar borrados por error. En el Log se pueden ver todas las apps sin filtrar\r\n-----------\r\nHidden apps in the comboBox that can come from android(system), samsung or google to avoid being deleted by mistake. In the Log you can see all the unfiltered apps\r\n-----------\r\n";
            txtLogBox.Text = txtLogBox.Text + receiver;
            string temp = receiver.ToString().Replace("\r\n", "-");
            Char delimiter = '-';
            String[] listaSaves = temp.Split(delimiter);
            comboBox2.Items.Clear();
            var res = listaSaves.Where(s => !listaAppsProtected.Any(ignored => s.Contains(ignored))).ToList();
            foreach (var item in res)
            {
                comboBox2.Items.Add(item);
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            saveSelected = comboBox2.SelectedItem.ToString();
            txtLogBox.Clear();
            txtLogBox.Text = saveSelected;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string savePath = Directory.GetCurrentDirectory();
            var confirmResult = MessageBox.Show("You will backup your save of " + saveSelected + " to saveBackups directory in this App directory.", "Confirm it?",
                MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                
                txtLogBox.Text = openFileDialog1.FileName;
                ProcessStartInfo psi = new ProcessStartInfo(savePath + "\\adb\\adb.exe");
                string argumentPath = "/sdcard/Android/data/" + saveSelected + "/ ";
                psi.Arguments = "pull "+argumentPath +"saveBackups/";
                psi.UseShellExecute = false;
                psi.RedirectStandardInput = true;
                Process p = Process.Start(psi);
                txtLogBox.Clear();
                txtLogBox.Text = saveSelected + "backup done";
                p.Close();
            }
            else
            {
                txtLogBox.Clear();
                txtLogBox.Text = "Operation Cancelled!!";
            }
        }
    }
}