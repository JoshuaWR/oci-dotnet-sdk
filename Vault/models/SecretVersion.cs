/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.VaultService.Models
{
    /// <summary>
    /// The details of the secret version, excluding the contents of the secret.
    /// </summary>
    public class SecretVersion 
    {
                ///
        /// <value>
        /// The content type of the secret version's secret contents.
        /// </value>
        ///
        public enum ContentTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "BASE64")]
            Base64
        };

        /// <value>
        /// The content type of the secret version's secret contents.
        /// </value>
        [JsonProperty(PropertyName = "contentType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ContentTypeEnum> ContentType { get; set; }
        
        /// <value>
        /// The name of the secret version. A name is unique across versions of a secret.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The OCID of the secret.
        /// </value>
        [JsonProperty(PropertyName = "secretId")]
        public string SecretId { get; set; }
                ///
        ///
        public enum StagesEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CURRENT")]
            Current,
            [EnumMember(Value = "PENDING")]
            Pending,
            [EnumMember(Value = "LATEST")]
            Latest,
            [EnumMember(Value = "PREVIOUS")]
            Previous,
            [EnumMember(Value = "DEPRECATED")]
            Deprecated
        };

        /// <value>
        /// A list of possible rotation states for the secret version. A secret version marked `CURRENT` is currently in use. A secret version
        /// marked `PENDING` is staged and available for use, but has not been applied on the target system and, therefore, has not been rotated
        /// into current, active use. The secret most recently uploaded to a vault is always marked `LATEST`. (The first version of a secret is
        /// always marked as both `CURRENT` and `LATEST`.) A secret version marked `PREVIOUS` is the secret version that was most recently marked
        /// `CURRENT`, before the last secret version rotation. A secret version marked `DEPRECATED` is neither current, pending, nor the previous
        /// one in use. Only secret versions marked `DEPRECATED` can be scheduled for deletion.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "stages", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<StagesEnum> Stages { get; set; }
        
        /// <value>
        /// A optional property indicating when the secret version was created, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// Example: 2019-04-03T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// An optional property indicating when to delete the secret version, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// Example: 2019-04-03T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeOfDeletion")]
        public System.Nullable<System.DateTime> TimeOfDeletion { get; set; }
        
        /// <value>
        /// An optional property indicating when the current secret version will expire, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// Example: 2019-04-03T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeOfCurrentVersionExpiry")]
        public System.Nullable<System.DateTime> TimeOfCurrentVersionExpiry { get; set; }
        
        /// <value>
        /// The version number of the secret.
        /// </value>
        [JsonProperty(PropertyName = "versionNumber")]
        public System.Nullable<long> VersionNumber { get; set; }
        
    }
}
