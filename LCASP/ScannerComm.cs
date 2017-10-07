using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCASP
{
    public class ScannerComm
    {
        private System.IO.Ports.SerialPort _serialPort = new System.IO.Ports.SerialPort();
        public static CommQueue theQueue = null;


        public ScannerComm()
        {
            theQueue = new CommQueue();

            _serialPort.BaudRate = 38400;
            _serialPort.DataBits = 8;
            _serialPort.Handshake = Handshake.None;
            _serialPort.Parity = Parity.None;
            _serialPort.PortName = "COM2";
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
            while(_serialPort.BytesToRead > 0)
            {
                theQueue.EnQueue(_serialPort.ReadLine());
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

            while(theQueue.GetQueueBytes()==0)
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

            while(theQueue.GetQueueBytes() < 17)
                System.Threading.Thread.Sleep(25);

            theQueue.ClearQueue();
        }


    }

}


