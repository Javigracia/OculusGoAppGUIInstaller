using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SharpAdbClient;

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
            this.connect_button.Click += new System.EventHandler(this.Connect_button_Click);
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

        private void Connect_button_Click(object sender, EventArgs e)
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


        private void TwitterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.twitterLabel.LinkVisited = true;
            Process.Start("https://twitter.com/javigracia");
        }

        private void Install_button_Click(object sender, EventArgs e)
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

        private void Readme_button_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            ProcessStartInfo psi2 = new ProcessStartInfo("Wordpad.exe");
            psi2.Arguments = "\"" + path + "\\docs\\README.rtf\"";
            Process p2 = Process.Start(psi2);
            p2.Close();
        }

        private void AppsList_button_Click(object sender, EventArgs e)
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
            appsList.Items.Clear();
            var res = listaApps.Where(s => !listaAppsProtected.Any(ignored => s.Contains(ignored))).ToList();
            foreach (var item in res)
            {
                appsList.Items.Add(item);
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
        private void AppsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            appSelected = appsList.SelectedItem.ToString();
            txtLogBox.Clear();
            txtLogBox.Text = appSelected;
        }

        private void Uninstall_button_Click(object sender, EventArgs e)
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

        private void Resolution1024_button_Click(object sender, EventArgs e)
        {
            var device = AdbClient.Instance.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureWidth 1024", device, receiver);
            txtLogBox.Clear();
            txtLogBox.Text = "Width resolution changed to 1024.";
            AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureHeight 1024", device, receiver);
            txtLogBox.Text = txtLogBox.Text + "\r\nHeight resolution changed to 1024.";
        }

        private void Resolution1536_button_Click(object sender, EventArgs e)
        {
            var device = AdbClient.Instance.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureWidth 1536", device, receiver);
            txtLogBox.Clear();
            txtLogBox.Text = "Width resolution changed to 1536.";
            AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureHeight 1536", device, receiver);
            txtLogBox.Text = txtLogBox.Text + "\r\nHeight resolution changed to 1536.";
        }

        private void Resolution2048_button_Click(object sender, EventArgs e)
        {
            var device = AdbClient.Instance.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureWidth 2048", device, receiver);
            txtLogBox.Clear();
            txtLogBox.Text = "Width resolution changed to 2048.";
            AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.textureHeight 2048", device, receiver);
            txtLogBox.Text = txtLogBox.Text + "\r\nHeight resolution changed to 2048.";
        }

        private void Resolution2560_button_Click(object sender, EventArgs e)
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

        private void Resolution2048Plus_button_Click(object sender, EventArgs e)
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

        private void Resolution3072Plus_button_Click(object sender, EventArgs e)
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

        private void ChromaticFixOn_button_Click(object sender, EventArgs e)
        {
            var device = AdbClient.Instance.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.forceChroma 1", device, receiver);
            txtLogBox.Clear();
            txtLogBox.Text = "Chromatic aberration fix ON.";
        }

        private void ChromaticFixOff_button_Click(object sender, EventArgs e)
        {
            var device = AdbClient.Instance.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand("setprop debug.oculus.forceChroma 0", device, receiver);
            txtLogBox.Clear();
            txtLogBox.Text = "Chromatic aberration fix OFF.";
        }

        private void SavesList_button_Click(object sender, EventArgs e)
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
            saveDataList.Items.Clear();
            var res = listaSaves.Where(s => !listaAppsProtected.Any(ignored => s.Contains(ignored))).ToList();
            foreach (var item in res)
            {
                saveDataList.Items.Add(item);
            }
        }

        private void SaveDataList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            saveSelected = saveDataList.SelectedItem.ToString();
            txtLogBox.Clear();
            txtLogBox.Text = saveSelected;
        }

        private void SaveBackup_button_Click(object sender, EventArgs e)
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
                txtLogBox.Text = saveSelected + " backup done";
                p.Close();
            }
            else
            {
                txtLogBox.Clear();
                txtLogBox.Text = "Operation Cancelled!!";
            }
        }

        private void SaveRestore_button_Click(object sender, EventArgs e)
        {
            using(var fbd = new FolderBrowserDialog())
            {
                string path = Directory.GetCurrentDirectory();
                fbd.SelectedPath = path + "\\saveBackups";
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //txtLogBox.Clear();
                    //txtLogBox.Text = fbd.SelectedPath;
                    ProcessStartInfo psi = new ProcessStartInfo(path + "\\adb\\adb.exe");
                    psi.Arguments = "push \"" + fbd.SelectedPath + "\" /sdcard/Android/data/";
                    psi.UseShellExecute = false;
                    psi.RedirectStandardInput = true;
                    Process p = Process.Start(psi);
                    txtLogBox.Clear();
                    txtLogBox.Text = "Backup restored to /sdcard/Android/data/";
                    MessageBox.Show("Save data restored");
                    p.Close();
                }
            }
        }
    }
}