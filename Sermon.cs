using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sermon.Providers;

namespace Sermon
{
    public partial class Sermon : Form
    {
        private string currentComPort = "COM?";
        private IDataProvider provider = null;

        public Sermon()
        {
            InitializeComponent();

            tsddComPort.DropDownOpening += new System.EventHandler(this.tsddComPort_DropDownOpening);
            tsddComPort.DropDownItemClicked += new ToolStripItemClickedEventHandler(this.tsddComPort_DropDownItemClicked);
        }

        private void tsddComPort_DropDownOpening(object sender, EventArgs e)
        {
            tsddComPort.DropDownItems.Clear();

            // Find COM ports
            foreach (string comPort in System.IO.Ports.SerialPort.GetPortNames())
            {
                var tsmi = new ToolStripMenuItem(comPort);
                if (comPort == currentComPort)
                {
                    tsmi.Checked = true;
                }
                tsddComPort.DropDownItems.Add(tsmi);
            }
        }

        private void tsddComPort_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            tsddComPort.Text = e.ClickedItem.Text;
            currentComPort = e.ClickedItem.Text;

            // get rid of old provider
            if (provider != null)
            {
            }

            // create provider
//            provider = new ComPortProvider(e.ClickedItem.Text);
            provider = new DummyProvider();
            provider.DataAvailable += new System.EventHandler<DataAvailableEventArgs>(this.DataAvailable);
        }

        private void DataAvailable(object sender, DataAvailableEventArgs e)
        {
            tsslStatus.Text = "Got data " + e.Data.Timestamp;
        }
    }
}
