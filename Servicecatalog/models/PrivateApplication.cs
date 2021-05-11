/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ServicecatalogService.Models
{
    /// <summary>
    /// Full details of an application or a solution, which lives inside the tenancy and may be included into service catalogs.
    /// 
    /// </summary>
    public class PrivateApplication 
    {
                ///
        /// <value>
        /// The lifecycle state of the private application.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The lifecycle state of the private application.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment where the private application resides.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The unique identifier for the private application in Marketplace.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name of the private application.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A short description of the private application.
        /// </value>
        [JsonProperty(PropertyName = "shortDescription")]
        public string ShortDescription { get; set; }
        
        /// <value>
        /// A long description of the private application.
        /// </value>
        [JsonProperty(PropertyName = "longDescription")]
        public string LongDescription { get; set; }
        
        [JsonProperty(PropertyName = "logo")]
        public UploadData Logo { get; set; }
        
        /// <value>
        /// Type of packages within this private application.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PackageType is required.")]
        [JsonProperty(PropertyName = "packageType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PackageTypeEnum> PackageType { get; set; }
        
        /// <value>
        /// The date and time the private application was created, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// timestamp format.
        /// <br/>
        /// Example: 2021-05-26T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the private application was last modified, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// timestamp format.
        /// <br/>
        /// Example: 2021-12-10T05:10:29.721Z
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
    }
}