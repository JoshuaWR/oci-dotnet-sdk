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


namespace Oci.CoreService.Models
{
    
    public class CreateVolumeBackupPolicyAssignmentDetails 
    {
        
        /// <value>
        /// The OCID of the volume to assign the policy to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AssetId is required.")]
        [JsonProperty(PropertyName = "assetId")]
        public string AssetId { get; set; }
        
        /// <value>
        /// The OCID of the volume backup policy to assign to the volume.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PolicyId is required.")]
        [JsonProperty(PropertyName = "policyId")]
        public string PolicyId { get; set; }
        
        /// <value>
        /// The OCID of the Vault service key which is the master encryption key for the block / boot volume cross region backups, which will be used in the destination region to encrypt the backup's encryption keys.
        /// For more information about the Vault service and encryption keys, see
        /// [Overview of Vault service](https://docs.cloud.oracle.com/iaas/Content/KeyManagement/Concepts/keyoverview.htm) and
        /// [Using Keys](https://docs.cloud.oracle.com/iaas/Content/KeyManagement/Tasks/usingkeys.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "xrcKmsKeyId")]
        public string XrcKmsKeyId { get; set; }
        
    }
}
