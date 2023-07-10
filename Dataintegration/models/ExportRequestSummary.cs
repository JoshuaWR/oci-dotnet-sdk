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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Export metadata object response summary.
    /// </summary>
    public class ExportRequestSummary 
    {
        
        /// <value>
        /// Export object request key
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The list of the objects to be exported
        /// </value>
        [JsonProperty(PropertyName = "objectKeys")]
        public System.Collections.Generic.List<string> ObjectKeys { get; set; }
        
        /// <value>
        /// The name of the Object Storage Bucket where the objects will be exported to
        /// </value>
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }
        
        /// <value>
        /// Name of the exported zip file.
        /// </value>
        [JsonProperty(PropertyName = "fileName")]
        public string FileName { get; set; }
        
        /// <value>
        /// Optional parameter to point to object storage tenancy (if using Object Storage of different tenancy)
        /// </value>
        [JsonProperty(PropertyName = "objectStorageTenancyId")]
        public string ObjectStorageTenancyId { get; set; }
        
        /// <value>
        /// Region of the object storage (if using object storage of different region)
        /// </value>
        [JsonProperty(PropertyName = "objectStorageRegion")]
        public string ObjectStorageRegion { get; set; }
        
        /// <value>
        /// Controls if the references will be exported along with the objects
        /// </value>
        [JsonProperty(PropertyName = "areReferencesIncluded")]
        public System.Nullable<bool> AreReferencesIncluded { get; set; }
        
        /// <value>
        /// Flag to control whether to overwrite the object if it is already present at the provided object storage location.
        /// </value>
        [JsonProperty(PropertyName = "isObjectOverwriteEnabled")]
        public System.Nullable<bool> IsObjectOverwriteEnabled { get; set; }
        
        /// <value>
        /// Export multiple objects based on filters.
        /// </value>
        [JsonProperty(PropertyName = "filters")]
        public System.Collections.Generic.List<string> Filters { get; set; }
                ///
        /// <value>
        /// Export Objects request status.
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SUCCESSFUL")]
            Successful,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "QUEUED")]
            Queued
        };

        /// <value>
        /// Export Objects request status.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// Name of the user who initiated export request.
        /// </value>
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }
        
        /// <value>
        /// Number of objects that are exported.
        /// </value>
        [JsonProperty(PropertyName = "totalExportedObjectCount")]
        public System.Nullable<int> TotalExportedObjectCount { get; set; }
        
        /// <value>
        /// Time at which the request started getting processed.
        /// </value>
        [JsonProperty(PropertyName = "timeStartedInMillis")]
        public System.Nullable<long> TimeStartedInMillis { get; set; }
        
        /// <value>
        /// Time at which the request was completely processed.
        /// </value>
        [JsonProperty(PropertyName = "timeEndedInMillis")]
        public System.Nullable<long> TimeEndedInMillis { get; set; }
        
        /// <value>
        /// Contains key of the error
        /// </value>
        [JsonProperty(PropertyName = "errorMessages")]
        public System.Collections.Generic.Dictionary<string, string> ErrorMessages { get; set; }
        
        /// <value>
        /// The array of exported object details.
        /// </value>
        [JsonProperty(PropertyName = "exportedItems")]
        public System.Collections.Generic.List<ExportObjectMetadataSummary> ExportedItems { get; set; }
        
        /// <value>
        /// The array of exported referenced objects.
        /// </value>
        [JsonProperty(PropertyName = "referencedItems")]
        public string ReferencedItems { get; set; }
        
        /// <value>
        /// Name of the export request.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
    }
}
