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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// An Object Storage PAR from which to import the DB System initial data.
    /// 
    /// </summary>
    public class CreateDbSystemSourceImportFromUrlDetails : CreateDbSystemSourceDetails
    {
        
        /// <value>
        /// The Pre-Authenticated Request (PAR) of a bucket/prefix or PAR of a @.manifest.json object from the Object Storage.
        /// Check [Using Pre-Authenticated Requests](https://docs.oracle.com/en-us/iaas/Content/Object/Tasks/usingpreauthenticatedrequests.htm)
        /// for information related to PAR creation.
        /// Please create PAR with \"Permit object reads\" access type and \"Enable Object Listing\" permission when using a bucket/prefix PAR.
        /// Please create PAR with \"Permit object reads\" access type when using a @.manifest.json object PAR.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceUrl is required.")]
        [JsonProperty(PropertyName = "sourceUrl")]
        public string SourceUrl { get; set; }
        
        [JsonProperty(PropertyName = "sourceType")]
        private readonly string sourceType = "IMPORTURL";
    }
}
