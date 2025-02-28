// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the alternative option specified by the Publisher for this image when this image is deprecated. </summary>
    public partial class ImageAlternativeOption
    {
        /// <summary> Initializes a new instance of ImageAlternativeOption. </summary>
        public ImageAlternativeOption()
        {
        }

        /// <summary> Initializes a new instance of ImageAlternativeOption. </summary>
        /// <param name="alternativeType"> Describes the type of the alternative option. </param>
        /// <param name="value"> Indicates the alternative option value specified by the Publisher. This is the Offer name when the type is Offer or the Plan name when the type is Plan. </param>
        internal ImageAlternativeOption(ImageAlternativeType? alternativeType, string value)
        {
            AlternativeType = alternativeType;
            Value = value;
        }

        /// <summary> Describes the type of the alternative option. </summary>
        public ImageAlternativeType? AlternativeType { get; set; }
        /// <summary> Indicates the alternative option value specified by the Publisher. This is the Offer name when the type is Offer or the Plan name when the type is Plan. </summary>
        public string Value { get; set; }
    }
}
