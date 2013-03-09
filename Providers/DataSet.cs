// -----------------------------------------------------------------------
// <copyright file="DataSet.cs" company="">
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
    public class DataSet
    {
        public DateTime Timestamp;
        public List<DataPoint> DataPoints;
    }

    public class DataPoint
    {
        public enum DataPointType
        {
            GenericSensorValue,
            Text,
            Angle
        }

        public string Label;
        public DataPointType Type;
        public double Value;
        public string Text;
    }
}
