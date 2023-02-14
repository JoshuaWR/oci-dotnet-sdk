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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Instance launch details.
    /// Use the `sourceDetails` parameter to specify whether a boot volume or an image should be used to launch a new instance.
    /// 
    /// </summary>
    public class LaunchInstanceDetails 
    {
        
        /// <value>
        /// The availability domain of the instance.
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
        /// The OCID of the compute capacity reservation this instance is launched under.
        /// You can opt out of all default reservations by specifying an empty string as input for this field.
        /// For more information, see [Capacity Reservations](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/reserve-capacity.htm#default).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "capacityReservationId")]
        public string CapacityReservationId { get; set; }
        
        /// <value>
        /// The OCID of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        [JsonProperty(PropertyName = "createVnicDetails")]
        public CreateVnicDetails CreateVnicDetails { get; set; }
        
        /// <value>
        /// The OCID of the dedicated virtual machine host to place the instance on.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dedicatedVmHostId")]
        public string DedicatedVmHostId { get; set; }
        
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
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Additional metadata key/value pairs that you provide. They serve the same purpose and
        /// functionality as fields in the `metadata` object.
        /// <br/>
        /// They are distinguished from `metadata` fields in that these can be nested JSON objects
        /// (whereas `metadata` fields are string/string maps only).
        /// <br/>
        /// The combined size of the `metadata` and `extendedMetadata` objects can be a maximum of
        /// 32,000 bytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "extendedMetadata")]
        public System.Collections.Generic.Dictionary<string, System.Object> ExtendedMetadata { get; set; }
        
        /// <value>
        /// A fault domain is a grouping of hardware and infrastructure within an availability domain.
        /// Each availability domain contains three fault domains. Fault domains let you distribute your
        /// instances so that they are not on the same physical hardware within a single availability domain.
        /// A hardware failure or Compute hardware maintenance that affects one fault domain does not affect
        /// instances in other fault domains.
        /// <br/>
        /// If you do not specify the fault domain, the system selects one for you.
        /// <br/>
        /// 
        /// To get a list of fault domains, use the
        /// {@link #listFaultDomains(ListFaultDomainsRequest) listFaultDomains} operation in the
        /// Identity and Access Management Service API.
        /// <br/>
        /// Example: FAULT-DOMAIN-1
        /// </value>
        [JsonProperty(PropertyName = "faultDomain")]
        public string FaultDomain { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Deprecated. Instead use `hostnameLabel` in
        /// {@link CreateVnicDetails}.
        /// If you provide both, the values must match.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hostnameLabel")]
        public string HostnameLabel { get; set; }
        
        /// <value>
        /// Deprecated. Use `sourceDetails` with {@link #instanceSourceViaImageDetails(InstanceSourceViaImageDetailsRequest) instanceSourceViaImageDetails}
        /// source type instead. If you specify values for both, the values must match.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "imageId")]
        public string ImageId { get; set; }
        
        /// <value>
        /// This is an advanced option.
        /// <br/>
        /// When a bare metal or virtual machine
        /// instance boots, the iPXE firmware that runs on the instance is
        /// configured to run an iPXE script to continue the boot process.
        /// <br/>
        /// If you want more control over the boot process, you can provide
        /// your own custom iPXE script that will run when the instance boots.
        /// Be aware that the same iPXE script will run
        /// every time an instance boots, not only after the initial
        /// LaunchInstance call.
        /// <br/>
        /// The default iPXE script connects to the instance's local boot
        /// volume over iSCSI and performs a network boot. If you use a custom iPXE
        /// script and want to network-boot from the instance's local boot volume
        /// over iSCSI the same way as the default iPXE script, use the
        /// following iSCSI IP address: 169.254.0.2, and boot volume IQN:
        /// iqn.2015-02.oracle.boot.
        /// <br/>
        /// If your instance boot volume type is paravirtualized,
        /// the boot volume is attached to the instance through virtio-scsi and no iPXE script is used.
        /// If your instance boot volume type is paravirtualized
        /// and you use custom iPXE to network boot into your instance,
        /// the primary boot volume is attached as a data volume through virtio-scsi drive.
        /// <br/>
        /// For more information about the Bring Your Own Image feature of
        /// Oracle Cloud Infrastructure, see
        /// [Bring Your Own Image](https://docs.cloud.oracle.com/iaas/Content/Compute/References/bringyourownimage.htm).
        /// <br/>
        /// For more information about iPXE, see http://ipxe.org.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ipxeScript")]
        public string IpxeScript { get; set; }
        
        [JsonProperty(PropertyName = "launchOptions")]
        public LaunchOptions LaunchOptions { get; set; }
        
        [JsonProperty(PropertyName = "instanceOptions")]
        public InstanceOptions InstanceOptions { get; set; }
        
        [JsonProperty(PropertyName = "availabilityConfig")]
        public LaunchInstanceAvailabilityConfigDetails AvailabilityConfig { get; set; }
        
        [JsonProperty(PropertyName = "preemptibleInstanceConfig")]
        public PreemptibleInstanceConfigDetails PreemptibleInstanceConfig { get; set; }
        
        /// <value>
        /// Custom metadata key/value pairs that you provide, such as the SSH public key
        /// required to connect to the instance.
        /// <br/>
        /// A metadata service runs on every launched instance. The service is an HTTP
        /// endpoint listening on 169.254.169.254. You can use the service to:
        /// <br/>
        /// * Provide information to [Cloud-Init](https://cloudinit.readthedocs.org/en/latest/)
        ///   to be used for various system initialization tasks.
        /// <br/>
        /// * Get information about the instance, including the custom metadata that you
        ///   provide when you launch the instance.
        /// <br/>
        ///  **Providing Cloud-Init Metadata**
        /// <br/>
        ///  You can use the following metadata key names to provide information to
        ///  Cloud-Init:
        /// <br/>
        ///  **\"ssh_authorized_keys\"** - Provide one or more public SSH keys to be
        ///  included in the `~/.ssh/authorized_keys` file for the default user on the
        ///  instance. Use a newline character to separate multiple keys. The SSH
        ///  keys must be in the format necessary for the `authorized_keys` file, as shown
        ///  in the example below.
        /// <br/>
        ///  **\"user_data\"** - Provide your own base64-encoded data to be used by
        ///  Cloud-Init to run custom scripts or provide custom Cloud-Init configuration. For
        ///  information about how to take advantage of user data, see the
        ///  [Cloud-Init Documentation](http://cloudinit.readthedocs.org/en/latest/topics/format.html).
        /// <br/>
        ///  **Metadata Example**
        /// <br/>
        ///       \"metadata\" : {
        ///          \"quake_bot_level\" : \"Severe\",
        ///          \"ssh_authorized_keys\" : \"ssh-rsa <your_public_SSH_key>== rsa-key-20160227\",
        ///          \"user_data\" : \"<your_public_SSH_key>==\"
        ///       }
        ///  **Getting Metadata on the Instance**
        /// <br/>
        ///  To get information about your instance, connect to the instance using SSH and issue any of the
        ///  following GET requests:
        /// <br/>
        ///      curl -H \"Authorization: Bearer Oracle\" http://169.254.169.254/opc/v2/instance/
        ///      curl -H \"Authorization: Bearer Oracle\" http://169.254.169.254/opc/v2/instance/metadata/
        ///      curl -H \"Authorization: Bearer Oracle\" http://169.254.169.254/opc/v2/instance/metadata/<any-key-name>
        /// <br/>
        ///  You'll get back a response that includes all the instance information; only the metadata information; or
        ///  the metadata information for the specified key name, respectively.
        /// <br/>
        ///  The combined size of the `metadata` and `extendedMetadata` objects can be a maximum of 32,000 bytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }
        
        [JsonProperty(PropertyName = "agentConfig")]
        public LaunchInstanceAgentConfigDetails AgentConfig { get; set; }
        
        /// <value>
        /// The shape of an instance. The shape determines the number of CPUs, amount of memory,
        /// and other resources allocated to the instance.
        /// <br/>
        /// You can enumerate all available shapes by calling {@link #listShapes(ListShapesRequest) listShapes}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Shape is required.")]
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        [JsonProperty(PropertyName = "shapeConfig")]
        public LaunchInstanceShapeConfigDetails ShapeConfig { get; set; }
        
        [JsonProperty(PropertyName = "sourceDetails")]
        public InstanceSourceDetails SourceDetails { get; set; }
        
        /// <value>
        /// Deprecated. Instead use `subnetId` in
        /// {@link CreateVnicDetails}.
        /// At least one of them is required; if you provide both, the values must match.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// Whether to enable in-transit encryption for the data volume's paravirtualized attachment. This field applies to both block volumes and boot volumes. The default value is false.
        /// </value>
        [JsonProperty(PropertyName = "isPvEncryptionInTransitEnabled")]
        public System.Nullable<bool> IsPvEncryptionInTransitEnabled { get; set; }
        
        [JsonProperty(PropertyName = "platformConfig")]
        public LaunchInstancePlatformConfig PlatformConfig { get; set; }
        
    }
}
