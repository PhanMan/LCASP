using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lcasp
{
    public class ScannerComm
    {
        string commPort = Properties.Settings.Default.COM;
        private System.IO.Ports.SerialPort _serialPort = new System.IO.Ports.SerialPort();
        public ListBox dataBox = null;
        CommQueue theQueue = null;
        private bool dataFlow = false;

        public ScannerComm(CommQueue aQueue)
        {
            theQueue = aQueue;

            string com = GetPorts("Silicon Labs");

            if (com.Length > 0)
                commPort = com;

            _serialPort.BaudRate = 38400;
            _serialPort.DataBits = 8;
            _serialPort.Handshake = Handshake.None;
            _serialPort.Parity = Parity.None;
            _serialPort.PortName = commPort;
            _serialPort.StopBits = StopBits.One;

            _serialPort.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceived);
        }

        private string GetPorts(string usbDeviceName)
        {
            string retVal = "";

            var searcher = new ManagementObjectSearcher(@"Select * From Win32_PnPEntity");
            ManagementObjectCollection collection = searcher.Get();
            foreach (var device in collection)
            {
                string deviceId = device["DeviceID"].ToString();
                string port = device["Caption"].ToString();
                string desc = device["Description"].ToString();
                string name = device["Name"].ToString();

                // "USB\\VID_10C4&PID_EA60\\1200"
                // "Silicon Labs CP210x USB to UART Bridge (COM2)"

                if (name.Contains(usbDeviceName))
                {
                    int start = name.IndexOf("COM");
                    int end = name.IndexOf(")");



                    retVal = name.Substring(start, (end-start));
                    return retVal;
                }
            }

            return retVal;
        }

        public void Open()
        {
            _serialPort.Open();
        }

        public void Close()
        {
            _serialPort.Close();
        }

        void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (_serialPort.BytesToRead > 0)
            {
                string dataIn = _serialPort.ReadLine();

                theQueue.EnQueue(dataIn);

                if (dataFlow)
                {
                    ArcherData a1 = new ArcherData(dataIn);

                    new DatabaseQueries().SetArcherData(a1);
                }
            }
        }

        public CommQueue GetQueue()
        {
            return theQueue;
        }

        public void Write(string outBytes)
        {
            _serialPort.Write(outBytes);
        }

        public bool SendScannerReset()
        {
            Write("R1" + "\r\n");

            while (theQueue.GetQueueBytes() == 0)
                System.Threading.Thread.Sleep(50);

            if (theQueue.GetQueueBytes() > 0)
            {
                string tst = theQueue.DeQueue();

                if (tst.CompareTo("OK\r") == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public void InitializeScanner()
        {
            int checkCounter = 100;

            Write("V" + "\r\n");
            //System.Threading.Thread.Sleep(1000);

            Write("R1T2" + "\r\n");
            //System.Threading.Thread.Sleep(1000);

            Write("N8A8M0I2" + "\r\n");
            //System.Threading.Thread.Sleep(1000);

            Write("K5K4X8" + "\r\n");
            //System.Threading.Thread.Sleep(1000);

            Write("X9" + "\r\n");
            //System.Threading.Thread.Sleep(1000);

            Write("R1M6T2" + "\r\n");
            //System.Threading.Thread.Sleep(1000);

            Write("N8M8M0I2K5K4" + "\r\n");
            //System.Threading.Thread.Sleep(1000);

            while (theQueue.GetQueueBytes() < 17 && (checkCounter--) > 0)
                System.Threading.Thread.Sleep(25);

            if(theQueue.InspectQueue(13).Substring(0,3).CompareTo("5.6") != 0)
            {
                MessageBox.Show("Scanner Firmware 5.6 Required! (Currently " + theQueue.InspectQueue(13).Substring(0,3) + ")");
            }

            theQueue.ClearQueue();

            dataFlow = true;
        }
    }
}


