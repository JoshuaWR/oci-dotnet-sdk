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

namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// The CNI type and relevant network details potentially applicable to the node pools of the cluster
    /// </summary>
    [JsonConverter(typeof(ClusterPodNetworkOptionDetailsModelConverter))]
    public class ClusterPodNetworkOptionDetails 
    {
                ///
        /// <value>
        /// The CNI used by the node pools of this cluster
        /// </value>
        ///
        public enum CniTypeEnum {
            [EnumMember(Value = "OCI_VCN_IP_NATIVE")]
            OciVcnIpNative,
            [EnumMember(Value = "FLANNEL_OVERLAY")]
            FlannelOverlay
        };

        
    }

    public class ClusterPodNetworkOptionDetailsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ClusterPodNetworkOptionDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ClusterPodNetworkOptionDetails);
            var discriminator = jsonObject["cniType"].Value<string>();
            switch (discriminator)
            {
                case "FLANNEL_OVERLAY":
                    obj = new FlannelOverlayClusterPodNetworkOptionDetails();
                    break;
                case "OCI_VCN_IP_NATIVE":
                    obj = new OciVcnIpNativeClusterPodNetworkOptionDetails();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ClusterPodNetworkOptionDetails! Returning null value.");
            }
            return obj;
        }
    }
}
