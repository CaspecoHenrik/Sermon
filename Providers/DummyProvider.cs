// -----------------------------------------------------------------------
// <copyright file="DummyProvider.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Sermon.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Diagnostics;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class DummyProvider : IDataProvider 
    {
        public event EventHandler<DataAvailableEventArgs> DataAvailable;
        private Timer dummyTimer;
        private Stopwatch sw;

        public DummyProvider()
        {
            dummyTimer = new Timer();
            dummyTimer.Interval = 100;
            dummyTimer.Start();
            dummyTimer.Tick += new System.EventHandler(this.Tick);

            sw = Stopwatch.StartNew();
        }

        private void Tick(object sender, System.EventArgs e)
        {
            var data = new DataSet();
            data.Timestamp = DateTime.Now;
            
            var dp = new DataPoint();
            dp.Type = DataPoint.DataPointType.Text;
            dp.Text = "Debug text";
            dp.Label = "A";
            data.DataPoints.Add(dp);

            dp = new DataPoint();
            dp.Type = DataPoint.DataPointType.GenericSensorValue;
            dp.Value = Math.Cos(sw.ElapsedMilliseconds / 1000);
            dp.Label = "";
            data.DataPoints.Add(dp);

            var args = new DataAvailableEventArgs(data);
            DataAvailable(this, args);
        }
    }
}
