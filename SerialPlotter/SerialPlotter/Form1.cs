using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPlotter
{
    
    public partial class Form1 : Form
    {
        Process process;
        bool mouseDown;
        Point lastLocation;
        public Form1()
        {
            InitializeComponent();
            baudRateDD.SelectedItem = "115200";
            refreshComPorts(true);
            
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            closePlotter();
            string exepath = @"..\\..\\..\\..\\cppp\cppp-serial.exe";
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = exepath;
            psi.WorkingDirectory = Path.GetDirectoryName(exepath);
            string arguments = serialPortCB.SelectedItem.ToString() + " ";
            arguments += baudRateDD.SelectedItem.ToString() + " ";
            arguments += Convert.ToInt16(checksumCB.Checked).ToString() + " ";
            arguments += Convert.ToInt16(byteorderCB.Checked).ToString() + " ";
            arguments += Convert.ToInt16(timeCB.Checked).ToString() + " ";
            arguments += Convert.ToInt16(loggingCB.Checked).ToString() + " ";
            arguments += Convert.ToInt16(fullscreenCB.Checked).ToString() + " ";
            psi.Arguments = arguments;
            Console.WriteLine(arguments);
            process = Process.Start(psi);
            metroLabel1.Focus();

            this.BringToFront();

            
        }

        private void serialPortCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serialPortCB_DropDown(object sender, EventArgs e)
        {
            refreshComPorts(false);
            metroLabel1.Focus();
        }

        void refreshComPorts(bool first) 
        {
            var selectedItem = serialPortCB.SelectedItem;
            serialPortCB.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                serialPortCB.Items.Add(port);
            }
            if(first) 
            {
                serialPortCB.SelectedIndex = 0;
            }
            else 
            {
                serialPortCB.SelectedItem = selectedItem;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            closePlotter();
            Application.Exit();
        }

        private void closePlotterBTN_Click(object sender, EventArgs e)
        {
            closePlotter();
            metroLabel1.Focus();
        }

        void closePlotter() 
        {
            if (process != null)
            {
                if (!process.HasExited)
                {
                    process.CloseMainWindow();
                    process = null;
                }
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

    }
}
