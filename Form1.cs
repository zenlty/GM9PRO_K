using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GM9PRO_Kit
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public static string path = Application.StartupPath.ToString() + "\\libs\\",
            adb = path + "adb.exe",
            fastboot = path + "fastboot.exe",
            devicename;
        public static bool isthereconnecteddevice = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            detecter();
        }
        public void RunCommand(string tool, string code)
        {
            if (isthereconnecteddevice == true)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = tool;
                startInfo.Arguments = code;
                process.StartInfo = startInfo;
                process.Start();
            }
            else
            {
                MessageBox.Show("GM 9 PRO Algılanmadı", "Hata Kodu : 001",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        void detecter()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = adb;
            startInfo.Arguments = " shell getprop ro.product.model";
            process.StartInfo = startInfo;
            process.Start();
            detecterbanner.ButtonText = process.StandardOutput.ReadToEnd();
            if (detecterbanner.ButtonText == "" || detecterbanner.ButtonText == null)
            {
                detecterbanner.ButtonText = "GM 9 PRO Algılanmadı";
                isthereconnecteddevice = false;
                detecterbanner.BackgroundColor = Color.Black;
            }
            else
            {
                isthereconnecteddevice = true;
                detecterbanner.ButtonText = "General Mobile GM 9 PRO Algılandı !";
                detecterbanner.BackgroundColor = Color.DarkRed;

            }
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x219)
            {
                detecter();
            }
            base.WndProc(ref m);
        }
    }
}
