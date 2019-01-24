﻿using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lcasp
{
    public class ReportLocation
    {
        private TcpClient client = null;
        private IPEndPoint serverEndPoint = null;

        public ReportLocation(string version)
        {
            try
            {
                client = new TcpClient();
                IPHostEntry hostEntry = Dns.GetHostEntry("report.purvisms.com");
                serverEndPoint = new IPEndPoint(hostEntry.AddressList[0], 8848);

                client.Connect(serverEndPoint);

                NetworkStream clientStream = client.GetStream();

                ASCIIEncoding encoder = new ASCIIEncoding();

                string[] mmV = version.Substring(4, version.Length-4).Split('.');

                string mVersion = version.Substring(0, 3);

                foreach(string x in mmV)
                {
                    mVersion = mVersion + x;
                }


                byte[] buffer = encoder.GetBytes(Properties.Settings.Default.SiteName + " " + 0 + " " + mVersion);

                clientStream.Write(buffer, 0, buffer.Length);
                clientStream.Flush();
            } catch (Exception)
            {
                // Do nothing.
            }
        }
    }
}