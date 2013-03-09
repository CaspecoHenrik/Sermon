// -----------------------------------------------------------------------
// <copyright file="ComPortProvider.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Sermon.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ComPortProvider : IDataProvider 
    {
        private System.IO.Ports.SerialPort port;

        public ComPortProvider(string portName)
        {
            port = new System.IO.Ports.SerialPort(portName, 9600);
            port.Open(); 
        }

        DataSet IDataProvider.ReadData()
        {
            return null;
        }
    }
}
