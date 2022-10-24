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


namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// Run Object Store Script step details.
    /// </summary>
    public class RunObjectStoreScriptUserDefinedStep : DrPlanUserDefinedStep
    {
        
        /// <value>
        /// The OCID of the instance where this script or command should be executed.
        /// <br/>
        /// Example: ocid1.instance.oc1.phx.exampleocid1
        /// </value>
        [JsonProperty(PropertyName = "runOnInstanceId")]
        public string RunOnInstanceId { get; set; }
        
        /// <value>
        /// The region of the instance where this script or command should be executed.
        /// <br/>
        /// Example: us-phoenix-1
        /// </value>
        [JsonProperty(PropertyName = "runOnInstanceRegion")]
        public string RunOnInstanceRegion { get; set; }
        
        [JsonProperty(PropertyName = "objectStorageScriptLocation")]
        public ObjectStorageScriptLocation ObjectStorageScriptLocation { get; set; }
        
        [JsonProperty(PropertyName = "stepType")]
        private readonly string stepType = "RUN_OBJECTSTORE_SCRIPT";
    }
}
