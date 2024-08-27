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


namespace Oci.DelegateaccesscontrolService.Models
{
    /// <summary>
    /// Summary of why the already approved Delegated Resource Access Request was revoked.
    /// </summary>
    public class RevokeDelegatedResourceAccessRequestDetails 
    {
        
        /// <value>
        /// Comment specified by the approver explaining why the approval is revoked.
        /// </value>
        [JsonProperty(PropertyName = "approverComment")]
        public string ApproverComment { get; set; }
        
    }
}
