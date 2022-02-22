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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// A detachable block volume device that allows you to dynamically expand
    /// the storage capacity of an instance. For more information, see
    /// [Overview of Cloud Volume Storage](https://docs.cloud.oracle.com/iaas/Content/Block/Concepts/overview.htm).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator. If you're an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/iaas/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you
    /// supply string values using the API.
    /// 
    /// </summary>
    public class Volume 
    {
        
        /// <value>
        /// The availability domain of the volume.
        /// <br/>
        /// Example: Uocm:PHX-AD-1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the volume.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
        /// <value>
        /// The OCID of the volume.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Specifies whether the cloned volume's data has finished copying from the source volume or backup.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isHydrated")]
        public System.Nullable<bool> IsHydrated { get; set; }
        
        /// <value>
        /// The OCID of the Key Management key which is the master encryption key for the volume.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
                ///
        /// <value>
        /// The current state of a volume.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "RESTORING")]
            Restoring,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "FAULTY")]
            Faulty
        };

        /// <value>
        /// The current state of a volume.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The number of volume performance units (VPUs) that will be applied to this volume per GB,
        /// representing the Block Volume service's elastic performance options.
        /// See [Block Volume Elastic Performance](https://docs.cloud.oracle.com/iaas/Content/Block/Concepts/blockvolumeelasticperformance.htm) for more information.
        /// <br/>
        /// Allowed values:
        /// <br/>
        ///   * `0`: Represents Lower Cost option.
        /// <br/>
        ///   * `10`: Represents Balanced option.
        /// <br/>
        ///   * `20`: Represents Higher Performance option.
        /// <br/>
        /// For performance autotune enabled volumes, It would be the Default(Minimum) VPUs/GB.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vpusPerGB")]
        public System.Nullable<long> VpusPerGB { get; set; }
        
        /// <value>
        /// The size of the volume in GBs.
        /// </value>
        [JsonProperty(PropertyName = "sizeInGBs")]
        public System.Nullable<long> SizeInGBs { get; set; }
        
        /// <value>
        /// The size of the volume in MBs. This field is deprecated. Use
        /// sizeInGBs instead.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SizeInMBs is required.")]
        [JsonProperty(PropertyName = "sizeInMBs")]
        public System.Nullable<long> SizeInMBs { get; set; }
        
        [JsonProperty(PropertyName = "sourceDetails")]
        public VolumeSourceDetails SourceDetails { get; set; }
        
        /// <value>
        /// The date and time the volume was created. Format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The OCID of the source volume group.
        /// </value>
        [JsonProperty(PropertyName = "volumeGroupId")]
        public string VolumeGroupId { get; set; }
        
        /// <value>
        /// Specifies whether the auto-tune performance is enabled for this volume. This field is deprecated.
        /// Use the `DetachedVolumeAutotunePolicy` instead to enable the volume for detached autotune.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutoTuneEnabled")]
        public System.Nullable<bool> IsAutoTuneEnabled { get; set; }
        
        /// <value>
        /// The number of Volume Performance Units per GB that this volume is effectively tuned to.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "autoTunedVpusPerGB")]
        public System.Nullable<long> AutoTunedVpusPerGB { get; set; }
        
        /// <value>
        /// The list of block volume replicas of this volume.
        /// </value>
        [JsonProperty(PropertyName = "blockVolumeReplicas")]
        public System.Collections.Generic.List<BlockVolumeReplicaInfo> BlockVolumeReplicas { get; set; }
        
    }
}
