// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Task properties of the software update configuration. </summary>
    public partial class SoftwareUpdateConfigurationTaskProperties
    {
        /// <summary> Initializes a new instance of SoftwareUpdateConfigurationTaskProperties. </summary>
        public SoftwareUpdateConfigurationTaskProperties()
        {
            Parameters = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of SoftwareUpdateConfigurationTaskProperties. </summary>
        /// <param name="parameters"> Gets or sets the parameters of the task. </param>
        /// <param name="source"> Gets or sets the name of the runbook. </param>
        internal SoftwareUpdateConfigurationTaskProperties(IDictionary<string, string> parameters, string source)
        {
            Parameters = parameters;
            Source = source;
        }

        /// <summary> Gets or sets the parameters of the task. </summary>
        public IDictionary<string, string> Parameters { get; }
        /// <summary> Gets or sets the name of the runbook. </summary>
        public string Source { get; set; }
    }
}
