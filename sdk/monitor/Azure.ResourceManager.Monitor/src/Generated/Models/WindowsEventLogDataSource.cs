// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary>
    /// Definition of which Windows Event Log events will be collected and how they will be collected.
    /// Only collected from Windows machines.
    /// </summary>
    public partial class WindowsEventLogDataSource
    {
        /// <summary> Initializes a new instance of WindowsEventLogDataSource. </summary>
        public WindowsEventLogDataSource()
        {
            Streams = new ChangeTrackingList<WindowsEventLogDataSourceStream>();
            XPathQueries = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of WindowsEventLogDataSource. </summary>
        /// <param name="streams">
        /// List of streams that this data source will be sent to.
        /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        /// </param>
        /// <param name="xPathQueries"> A list of Windows Event Log queries in XPATH format. </param>
        /// <param name="name">
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </param>
        internal WindowsEventLogDataSource(IList<WindowsEventLogDataSourceStream> streams, IList<string> xPathQueries, string name)
        {
            Streams = streams;
            XPathQueries = xPathQueries;
            Name = name;
        }

        /// <summary>
        /// List of streams that this data source will be sent to.
        /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        /// </summary>
        public IList<WindowsEventLogDataSourceStream> Streams { get; }
        /// <summary> A list of Windows Event Log queries in XPATH format. </summary>
        public IList<string> XPathQueries { get; }
        /// <summary>
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; set; }
    }
}
