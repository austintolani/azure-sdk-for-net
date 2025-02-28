// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    /// <summary> This object is returned from a successful Search Address Reverse call. </summary>
    public partial class ReverseSearchAddressResult
    {
        /// <summary> Initializes a new instance of ReverseSearchAddressResult. </summary>
        internal ReverseSearchAddressResult()
        {
            Addresses = new ChangeTrackingList<ReverseSearchAddressItem>();
        }

        /// <summary> Initializes a new instance of ReverseSearchAddressResult. </summary>
        /// <param name="summary"> Summary object for a Search Address Reverse response. </param>
        /// <param name="addresses"> Addresses array. </param>
        internal ReverseSearchAddressResult(SearchSummary summary, IReadOnlyList<ReverseSearchAddressItem> addresses)
        {
            Summary = summary;
            Addresses = addresses;
        }
        /// <summary> Addresses array. </summary>
        public IReadOnlyList<ReverseSearchAddressItem> Addresses { get; }
    }
}
