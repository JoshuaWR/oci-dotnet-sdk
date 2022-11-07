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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// Individual worker nodes groups details.
    /// </summary>
    public class ChangeShapeNodes 
    {
        
        /// <value>
        /// Change shape of worker nodes to the desired target shape. Both VM_STANDARD and E4 Flex shapes are allowed here.
        /// </value>
        [JsonProperty(PropertyName = "worker")]
        public string Worker { get; set; }
        
        [JsonProperty(PropertyName = "workerShapeConfig")]
        public ShapeConfigDetails WorkerShapeConfig { get; set; }
        
        /// <value>
        /// Change shape of compute only worker nodes to the desired target shape. Both VM_STANDARD and E4 Flex shapes are allowed here.
        /// </value>
        [JsonProperty(PropertyName = "computeOnlyWorker")]
        public string ComputeOnlyWorker { get; set; }
        
        [JsonProperty(PropertyName = "computeOnlyWorkerShapeConfig")]
        public ShapeConfigDetails ComputeOnlyWorkerShapeConfig { get; set; }
        
        /// <value>
        /// Change shape of master nodes to the desired target shape. Both VM_STANDARD and E4 Flex shapes are allowed here.
        /// </value>
        [JsonProperty(PropertyName = "master")]
        public string Master { get; set; }
        
        [JsonProperty(PropertyName = "masterShapeConfig")]
        public ShapeConfigDetails MasterShapeConfig { get; set; }
        
        /// <value>
        /// Change shape of utility nodes to the desired target shape. Both VM_STANDARD and E4 Flex shapes are allowed here.
        /// </value>
        [JsonProperty(PropertyName = "utility")]
        public string Utility { get; set; }
        
        [JsonProperty(PropertyName = "utilityShapeConfig")]
        public ShapeConfigDetails UtilityShapeConfig { get; set; }
        
        /// <value>
        /// Change shape of the Cloud SQL node to the desired target shape. Both VM_STANDARD and E4 Flex shapes are allowed here.
        /// </value>
        [JsonProperty(PropertyName = "cloudsql")]
        public string Cloudsql { get; set; }
        
        [JsonProperty(PropertyName = "cloudsqlShapeConfig")]
        public ShapeConfigDetails CloudsqlShapeConfig { get; set; }
        
        /// <value>
        /// Change shape of edge nodes to the desired target shape. Both VM_STANDARD and E4 Flex shapes are allowed here.
        /// </value>
        [JsonProperty(PropertyName = "edge")]
        public string Edge { get; set; }
        
        [JsonProperty(PropertyName = "edgeShapeConfig")]
        public ShapeConfigDetails EdgeShapeConfig { get; set; }
        
    }
}
