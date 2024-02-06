/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ManagementagentService.Models
{
    /// <summary>
    /// A Kubernetes collection data source summary.
    /// 
    /// </summary>
    public class KubernetesClusterDataSourceSummaryItem : DataSourceSummaryItem
    {
        
        /// <value>
        /// true if the Kubernetes cluster type is Daemon set
        /// </value>
        [JsonProperty(PropertyName = "isDaemonSet")]
        public System.Nullable<bool> IsDaemonSet { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "KUBERNETES_CLUSTER";
    }
}