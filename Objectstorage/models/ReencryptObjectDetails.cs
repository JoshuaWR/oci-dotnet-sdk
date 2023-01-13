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


namespace Oci.ObjectstorageService.Models
{
    /// <summary>
    /// The details used to re-encrypt the data encryption keys associated with an object.
    /// You can only specify either a kmsKeyId or an sseCustomerKey in the request payload, not both.
    /// If the request payload is empty, the object is encrypted using the encryption key assigned to the
    /// bucket. The bucket encryption mechanism can either be a master encryption key managed by Oracle or the Vault service.
    /// <br/>
    /// - The sseCustomerKey field specifies the customer-provided encryption key (SSE-C) that will be used to re-encrypt the data encryption keys of the
    ///   object and its chunks.
    /// <br/>
    /// - The sourceSSECustomerKey field specifies information about the customer-provided encryption key that is currently
    ///   associated with the object source. Specify a value for the sourceSSECustomerKey only if the object
    ///   is encrypted with a customer-provided encryption key.
    /// 
    /// </summary>
    public class ReencryptObjectDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the master encryption key used to call the Vault
        /// service to re-encrypt the data encryption keys associated with the object and its chunks. If the kmsKeyId value is
        /// empty, whether null or an empty string, the API will perform re-encryption by using the kmsKeyId associated with the
        /// bucket or the master encryption key managed by Oracle, depending on the bucket encryption mechanism.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
        [JsonProperty(PropertyName = "sseCustomerKey")]
        public SSECustomerKeyDetails SseCustomerKey { get; set; }
        
        [JsonProperty(PropertyName = "sourceSseCustomerKey")]
        public SSECustomerKeyDetails SourceSseCustomerKey { get; set; }
        
    }
}
