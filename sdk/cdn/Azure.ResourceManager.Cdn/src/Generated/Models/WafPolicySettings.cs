// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines contents of a web application firewall global configuration. </summary>
    public partial class WafPolicySettings
    {
        /// <summary> Initializes a new instance of WafPolicySettings. </summary>
        public WafPolicySettings()
        {
        }

        /// <summary> Initializes a new instance of WafPolicySettings. </summary>
        /// <param name="enabledState"> describes if the policy is in enabled state or disabled state. </param>
        /// <param name="mode"> Describes if it is in detection mode or prevention mode at policy level. </param>
        /// <param name="defaultRedirectUri"> If action type is redirect, this field represents the default redirect URL for the client. </param>
        /// <param name="defaultCustomBlockResponseStatusCode"> If the action type is block, this field defines the default customer overridable http response status code. </param>
        /// <param name="defaultCustomBlockResponseBody"> If the action type is block, customer can override the response body. The body must be specified in base64 encoding. </param>
        internal WafPolicySettings(PolicyEnabledState? enabledState, PolicyMode? mode, Uri defaultRedirectUri, PolicySettingsDefaultCustomBlockResponseStatusCode? defaultCustomBlockResponseStatusCode, BinaryData defaultCustomBlockResponseBody)
        {
            EnabledState = enabledState;
            Mode = mode;
            DefaultRedirectUri = defaultRedirectUri;
            DefaultCustomBlockResponseStatusCode = defaultCustomBlockResponseStatusCode;
            DefaultCustomBlockResponseBody = defaultCustomBlockResponseBody;
        }

        /// <summary> describes if the policy is in enabled state or disabled state. </summary>
        public PolicyEnabledState? EnabledState { get; set; }
        /// <summary> Describes if it is in detection mode or prevention mode at policy level. </summary>
        public PolicyMode? Mode { get; set; }
        /// <summary> If action type is redirect, this field represents the default redirect URL for the client. </summary>
        public Uri DefaultRedirectUri { get; set; }
        /// <summary> If the action type is block, this field defines the default customer overridable http response status code. </summary>
        public PolicySettingsDefaultCustomBlockResponseStatusCode? DefaultCustomBlockResponseStatusCode { get; set; }
        /// <summary>
        /// If the action type is block, customer can override the response body. The body must be specified in base64 encoding.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData DefaultCustomBlockResponseBody { get; set; }
    }
}
