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


namespace Oci.CloudmigrationsService.Models
{
    /// <summary>
    /// Descriptor of a connection to an asset source.
    /// </summary>
    public class AssetSourceConnection 
    {
        
        /// <value>
        /// The type of connection for an asset source.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectionType is required.")]
        [JsonProperty(PropertyName = "connectionType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AssetSourceConnectionType> ConnectionType { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the cloud bridge connector used for migration operations.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectorId is required.")]
        [JsonProperty(PropertyName = "connectorId")]
        public string ConnectorId { get; set; }
        
        /// <value>
        /// Type-specific identifier for an asset source.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AssetSourceKey is required.")]
        [JsonProperty(PropertyName = "assetSourceKey")]
        public string AssetSourceKey { get; set; }
        
        /// <value>
        /// The current state of the connection.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AssetSourceConnectionLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The detailed sub-state of the connection.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleDetails is required.")]
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
    }
}
