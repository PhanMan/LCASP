using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCASP
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



            _serialPort.BaudRate = 38400;
            _serialPort.DataBits = 8;
            _serialPort.Handshake = Handshake.None;
            _serialPort.Parity = Parity.None;
            _serialPort.PortName = commPort;
            _serialPort.StopBits = StopBits.One;

            _serialPort.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceived);
        }

        public void Open()
        {
            _serialPort.Open();
        }

        public void Close()
        {
            _serialPort.Close();
        }

        ~ScannerComm()
        {
            _serialPort.Dispose();
            _serialPort = null;
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
            int checkCounter = 200;

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

            while (theQueue.GetQueueBytes() < 17 && (checkCounter--)>0)
                System.Threading.Thread.Sleep(25);

            theQueue.ClearQueue();

            dataFlow = true;
        }
    }
}


