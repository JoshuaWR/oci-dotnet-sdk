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
using Newtonsoft.Json.Linq;

namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Summary of a host configuration for a resource.
    /// </summary>
    [JsonConverter(typeof(HostConfigurationSummaryModelConverter))]
    public class HostConfigurationSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the host insight resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HostInsightId is required.")]
        [JsonProperty(PropertyName = "hostInsightId")]
        public string HostInsightId { get; set; }
        
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The host name. The host name is unique amongst the hosts managed by the same management agent.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HostName is required.")]
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }
                ///
        /// <value>
        /// Platform type.
        /// Supported platformType(s) for MACS-managed external host insight: [LINUX].
        /// Supported platformType(s) for MACS-managed cloud host insight: [LINUX].
        /// Supported platformType(s) for EM-managed external host insight: [LINUX, SOLARIS, SUNOS, ZLINUX].
        /// 
        /// </value>
        ///
        public enum PlatformTypeEnum {
            [EnumMember(Value = "LINUX")]
            Linux,
            [EnumMember(Value = "SOLARIS")]
            Solaris,
            [EnumMember(Value = "SUNOS")]
            Sunos,
            [EnumMember(Value = "ZLINUX")]
            Zlinux
        };

        /// <value>
        /// Platform type.
        /// Supported platformType(s) for MACS-managed external host insight: [LINUX].
        /// Supported platformType(s) for MACS-managed cloud host insight: [LINUX].
        /// Supported platformType(s) for EM-managed external host insight: [LINUX, SOLARIS, SUNOS, ZLINUX].
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlatformType is required.")]
        [JsonProperty(PropertyName = "platformType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PlatformTypeEnum> PlatformType { get; set; }
        
        /// <value>
        /// Platform version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlatformVersion is required.")]
        [JsonProperty(PropertyName = "platformVersion")]
        public string PlatformVersion { get; set; }
        
        /// <value>
        /// Platform vendor.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlatformVendor is required.")]
        [JsonProperty(PropertyName = "platformVendor")]
        public string PlatformVendor { get; set; }
        
        /// <value>
        /// Total CPU on this host.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalCpus is required.")]
        [JsonProperty(PropertyName = "totalCpus")]
        public System.Nullable<int> TotalCpus { get; set; }
        
        /// <value>
        /// Total amount of usable physical memory in gibabytes
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalMemoryInGBs is required.")]
        [JsonProperty(PropertyName = "totalMemoryInGBs")]
        public System.Double TotalMemoryInGBs { get; set; }
        
        /// <value>
        /// CPU architechure
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuArchitecture is required.")]
        [JsonProperty(PropertyName = "cpuArchitecture")]
        public string CpuArchitecture { get; set; }
        
        /// <value>
        /// Size of cache memory in megabytes.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuCacheInMBs is required.")]
        [JsonProperty(PropertyName = "cpuCacheInMBs")]
        public System.Double CpuCacheInMBs { get; set; }
        
        /// <value>
        /// Name of the CPU vendor.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuVendor is required.")]
        [JsonProperty(PropertyName = "cpuVendor")]
        public string CpuVendor { get; set; }
        
        /// <value>
        /// Clock frequency of the processor in megahertz.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuFrequencyInMhz is required.")]
        [JsonProperty(PropertyName = "cpuFrequencyInMhz")]
        public System.Double CpuFrequencyInMhz { get; set; }
        
        /// <value>
        /// Model name of processor.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuImplementation is required.")]
        [JsonProperty(PropertyName = "cpuImplementation")]
        public string CpuImplementation { get; set; }
        
        /// <value>
        /// Number of cores per socket.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CoresPerSocket is required.")]
        [JsonProperty(PropertyName = "coresPerSocket")]
        public System.Nullable<int> CoresPerSocket { get; set; }
        
        /// <value>
        /// Number of total sockets.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalSockets is required.")]
        [JsonProperty(PropertyName = "totalSockets")]
        public System.Nullable<int> TotalSockets { get; set; }
        
        /// <value>
        /// Number of threads per socket.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ThreadsPerSocket is required.")]
        [JsonProperty(PropertyName = "threadsPerSocket")]
        public System.Nullable<int> ThreadsPerSocket { get; set; }
        
        /// <value>
        /// Indicates if hyper-threading is enabled or not
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsHyperThreadingEnabled is required.")]
        [JsonProperty(PropertyName = "isHyperThreadingEnabled")]
        public System.Nullable<bool> IsHyperThreadingEnabled { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefinedTags is required.")]
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FreeformTags is required.")]
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
    }

    public class HostConfigurationSummaryModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(HostConfigurationSummary);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(HostConfigurationSummary);
            var discriminator = jsonObject["entitySource"].Value<string>();
            switch (discriminator)
            {
                case "MACS_MANAGED_EXTERNAL_HOST":
                    obj = new MacsManagedExternalHostConfigurationSummary();
                    break;
                case "PE_COMANAGED_HOST":
                    obj = new PeComanagedHostConfigurationSummary();
                    break;
                case "EM_MANAGED_EXTERNAL_HOST":
                    obj = new EmManagedExternalHostConfigurationSummary();
                    break;
                case "MACS_MANAGED_CLOUD_HOST":
                    obj = new MacsManagedCloudHostConfigurationSummary();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under HostConfigurationSummary! Returning null value.");
            }
            return obj;
        }
    }
}
