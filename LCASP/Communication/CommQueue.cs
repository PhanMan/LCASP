using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCASP
{
    public class CommQueue
    {
        private static int QBUF = 10000;
        private int numBytes = 0;
        private int insertItem = 0;
        private int takeItem = 0;
        private string[] sendData = null;
        private int[] usedData = null;


        public CommQueue()
        {
            sendData = new string[QBUF];
            usedData = new int[QBUF];

            ClearQueue();
        }

        ~CommQueue()
        {
            sendData = null;
            usedData = null;
        }

        public void ClearQueue()
        {
            insertItem = 0;
            takeItem = 0;
            numBytes = 0;

            for (int counter = 0; counter < QBUF; counter++)
            {
                sendData[counter] = "";
                usedData[counter] = 0;
            }
        }

        public int GetQueueBytes()
        {
            return numBytes;
        }

        public int EnQueue(string inb)
        {
            if (usedData[insertItem] == 1)
                return 0;

            numBytes++;

            sendData[insertItem] = inb;
            usedData[insertItem] = 1;
            insertItem++;

            if (insertItem == QBUF)
                insertItem = 0;

            return 1;
        }


        public string DeQueue()
        {
            string outByte = "";

            if (usedData[takeItem] == 0)
                return null;

            outByte = sendData[takeItem];
            usedData[takeItem] = 0;

            numBytes--;
            takeItem++;

            if (takeItem == QBUF)
                takeItem = 0;

            return outByte;
        }
    }
}
