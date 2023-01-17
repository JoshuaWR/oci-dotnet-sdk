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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// Metadata of a Crypto Event Analysis result. The analysis result is stored as the Object Storage object.
    /// </summary>
    public class CryptoAnalysisResult 
    {
        
        /// <value>
        /// The OCID to identify this analysis results.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the work request to start the analysis.
        /// </value>
        [JsonProperty(PropertyName = "workRequestId")]
        public string WorkRequestId { get; set; }
        
        /// <value>
        /// The result aggregation mode
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AggregationMode is required.")]
        [JsonProperty(PropertyName = "aggregationMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CryptoAnalysisResultMode> AggregationMode { get; set; }
        
        /// <value>
        /// The fleet OCID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FleetId is required.")]
        [JsonProperty(PropertyName = "fleetId")]
        public string FleetId { get; set; }
        
        /// <value>
        /// The managed instance OCID.
        /// </value>
        [JsonProperty(PropertyName = "managedInstanceId")]
        public string ManagedInstanceId { get; set; }
        
        /// <value>
        /// The hostname of the managed instance.
        /// </value>
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }
        
        /// <value>
        /// Time of the first event in the analysis.
        /// </value>
        [JsonProperty(PropertyName = "timeFirstEvent")]
        public System.Nullable<System.DateTime> TimeFirstEvent { get; set; }
        
        /// <value>
        /// Time of the last event in the analysis.
        /// </value>
        [JsonProperty(PropertyName = "timeLastEvent")]
        public System.Nullable<System.DateTime> TimeLastEvent { get; set; }
        
        /// <value>
        /// Total number of events in the analysis.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalEventCount is required.")]
        [JsonProperty(PropertyName = "totalEventCount")]
        public System.Nullable<int> TotalEventCount { get; set; }
        
        /// <value>
        /// Total number of summarized events. Summarized events are deduplicated events of interest.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SummarizedEventCount is required.")]
        [JsonProperty(PropertyName = "summarizedEventCount")]
        public System.Nullable<int> SummarizedEventCount { get; set; }
        
        /// <value>
        /// Total number of findings with the analysis.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FindingCount is required.")]
        [JsonProperty(PropertyName = "findingCount")]
        public System.Nullable<int> FindingCount { get; set; }
        
        /// <value>
        /// Total number of non-compliant findings with the analysis. A non-compliant finding means the
        /// application won't work properly with the changes introduced by the crypto roadmap version
        /// used the the analysis.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NonCompliantFindingCount is required.")]
        [JsonProperty(PropertyName = "nonCompliantFindingCount")]
        public System.Nullable<int> NonCompliantFindingCount { get; set; }
        
        /// <value>
        /// The time the result is compiled.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The Crypto Roadmap version used to perform the analysis.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CryptoRoadmapVersion is required.")]
        [JsonProperty(PropertyName = "cryptoRoadmapVersion")]
        public string CryptoRoadmapVersion { get; set; }
        
        /// <value>
        /// The Object Storage namespace of this analysis result.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// The Object Storage bucket name of this analysis result.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BucketName is required.")]
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }
        
        /// <value>
        /// The Object Storage object name of this analysis result.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectName is required.")]
        [JsonProperty(PropertyName = "objectName")]
        public string ObjectName { get; set; }
        
    }
}
