using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace GM9PRO_Kit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RunCommand(adb,"devices");
        }

        public static string path = Application.StartupPath.ToString() + "\\libs",
            adb = path + "adb.exe",
            fastboot = path + "fastboot.exe";
        public static bool isthereconnecteddevice = true;




        public void RunCommand(string tool,string code)
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
    }

}
