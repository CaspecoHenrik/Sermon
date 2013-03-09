using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sermon
{
    public partial class Sermon : Form
    {
        private string currentComPort = "COM?";

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
        }
    }
}
