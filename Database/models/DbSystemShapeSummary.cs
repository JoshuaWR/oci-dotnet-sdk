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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// The shape of the DB system. The shape determines resources to allocate to the DB system - CPU cores and memory for VM shapes; CPU cores, memory and storage for non-VM (or bare metal) shapes.
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized, talk to an administrator.
    /// If you're an administrator who needs to write policies to give users access,
    /// see [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class DbSystemShapeSummary 
    {
        
        /// <value>
        /// The name of the shape used for the DB system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The family of the shape used for the DB system.
        /// </value>
        [JsonProperty(PropertyName = "shapeFamily")]
        public string ShapeFamily { get; set; }
                ///
        /// <value>
        /// The shape type for the virtual machine DB system. Shape type is determined by CPU hardware. Valid values are `AMD` , `INTEL`, `INTEL_FLEX_X9` or `AMPERE_FLEX_A1`.
        /// </value>
        ///
        public enum ShapeTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AMD")]
            Amd,
            [EnumMember(Value = "INTEL")]
            Intel,
            [EnumMember(Value = "INTEL_FLEX_X9")]
            IntelFlexX9,
            [EnumMember(Value = "AMPERE_FLEX_A1")]
            AmpereFlexA1
        };

        /// <value>
        /// The shape type for the virtual machine DB system. Shape type is determined by CPU hardware. Valid values are `AMD` , `INTEL`, `INTEL_FLEX_X9` or `AMPERE_FLEX_A1`.
        /// </value>
        [JsonProperty(PropertyName = "shapeType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ShapeTypeEnum> ShapeType { get; set; }
        
        /// <value>
        /// Deprecated. Use `name` instead of `shape`.
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// The maximum number of CPU cores that can be enabled on the DB system for this shape.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailableCoreCount is required.")]
        [JsonProperty(PropertyName = "availableCoreCount")]
        public System.Nullable<int> AvailableCoreCount { get; set; }
        
        /// <value>
        /// The minimum number of CPU cores that can be enabled on the DB system for this shape.
        /// </value>
        [JsonProperty(PropertyName = "minimumCoreCount")]
        public System.Nullable<int> MinimumCoreCount { get; set; }
        
        /// <value>
        /// The discrete number by which the CPU core count for this shape can be increased or decreased.
        /// </value>
        [JsonProperty(PropertyName = "coreCountIncrement")]
        public System.Nullable<int> CoreCountIncrement { get; set; }
        
        /// <value>
        /// The minimum number of Exadata storage servers available for the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "minStorageCount")]
        public System.Nullable<int> MinStorageCount { get; set; }
        
        /// <value>
        /// The maximum number of Exadata storage servers available for the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "maxStorageCount")]
        public System.Nullable<int> MaxStorageCount { get; set; }
        
        /// <value>
        /// The maximum data storage available per storage server for this shape. Only applicable to ExaCC Elastic shapes.
        /// </value>
        [JsonProperty(PropertyName = "availableDataStoragePerServerInTBs")]
        public System.Double AvailableDataStoragePerServerInTBs { get; set; }
        
        /// <value>
        /// The maximum memory available per database node for this shape. Only applicable to ExaCC Elastic shapes.
        /// </value>
        [JsonProperty(PropertyName = "availableMemoryPerNodeInGBs")]
        public System.Nullable<int> AvailableMemoryPerNodeInGBs { get; set; }
        
        /// <value>
        /// The maximum Db Node storage available per database node for this shape. Only applicable to ExaCC Elastic shapes.
        /// </value>
        [JsonProperty(PropertyName = "availableDbNodePerNodeInGBs")]
        public System.Nullable<int> AvailableDbNodePerNodeInGBs { get; set; }
        
        /// <value>
        /// The minimum number of CPU cores that can be enabled per node for this shape.
        /// </value>
        [JsonProperty(PropertyName = "minCoreCountPerNode")]
        public System.Nullable<int> MinCoreCountPerNode { get; set; }
        
        /// <value>
        /// The maximum memory that can be enabled for this shape.
        /// </value>
        [JsonProperty(PropertyName = "availableMemoryInGBs")]
        public System.Nullable<int> AvailableMemoryInGBs { get; set; }
        
        /// <value>
        /// The minimum memory that need be allocated per node for this shape.
        /// </value>
        [JsonProperty(PropertyName = "minMemoryPerNodeInGBs")]
        public System.Nullable<int> MinMemoryPerNodeInGBs { get; set; }
        
        /// <value>
        /// The maximum Db Node storage that can be enabled for this shape.
        /// </value>
        [JsonProperty(PropertyName = "availableDbNodeStorageInGBs")]
        public System.Nullable<int> AvailableDbNodeStorageInGBs { get; set; }
        
        /// <value>
        /// The minimum Db Node storage that need be allocated per node for this shape.
        /// </value>
        [JsonProperty(PropertyName = "minDbNodeStoragePerNodeInGBs")]
        public System.Nullable<int> MinDbNodeStoragePerNodeInGBs { get; set; }
        
        /// <value>
        /// The maximum DATA storage that can be enabled for this shape.
        /// </value>
        [JsonProperty(PropertyName = "availableDataStorageInTBs")]
        public System.Nullable<int> AvailableDataStorageInTBs { get; set; }
        
        /// <value>
        /// The minimum data storage that need be allocated for this shape.
        /// </value>
        [JsonProperty(PropertyName = "minDataStorageInTBs")]
        public System.Nullable<int> MinDataStorageInTBs { get; set; }
        
        /// <value>
        /// The minimum number of compute servers available for this shape.
        /// </value>
        [JsonProperty(PropertyName = "minimumNodeCount")]
        public System.Nullable<int> MinimumNodeCount { get; set; }
        
        /// <value>
        /// The maximum number of compute servers available for this shape.
        /// </value>
        [JsonProperty(PropertyName = "maximumNodeCount")]
        public System.Nullable<int> MaximumNodeCount { get; set; }
        
        /// <value>
        /// The maximum number of CPU cores per database node that can be enabled for this shape. Only applicable to the flex Exadata shape, ExaCC Elastic shapes and VM Flex shapes.
        /// </value>
        [JsonProperty(PropertyName = "availableCoreCountPerNode")]
        public System.Nullable<int> AvailableCoreCountPerNode { get; set; }
        
    }
}
