/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Indicates user preferences for the various diagnostic collection options for the VM cluster.
    /// 
    /// </summary>
    public class DataCollectionOptions 
    {
        
        /// <value>
        /// Indicates whether diagnostic collection is enabled for the VM cluster. Enabling diagnostic collection allows you to receive Events service notifications for guest VM issues. Diagnostic collection also allows Oracle to provide enhanced service and proactive support for your Exadata system. You can enable diagnostic collection during VM cluster provisioning. You can also disable or enable it at any time using the `UpdateVmCluster` API.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDiagnosticsEventsEnabled")]
        public System.Nullable<bool> IsDiagnosticsEventsEnabled { get; set; }
        
    }
}