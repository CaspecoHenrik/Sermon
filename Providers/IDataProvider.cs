// -----------------------------------------------------------------------
// <copyright file="IDataProvider.cs" company="">
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
    public interface IDataProvider
    {
        event EventHandler<DataAvailableEventArgs> DataAvailable;
    }

    public class DataAvailableEventArgs : EventArgs
    {
        public DataAvailableEventArgs(DataSet data)
        {
            Data = data;
        }

        public DataSet Data
        {
            get;
            private set;
        }
    }
}
