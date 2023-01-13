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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The details used to  start an audit trail.
    /// </summary>
    public class StartAuditTrailDetails 
    {
        
        /// <value>
        /// The date from which the audit trail must start collecting data, in the format defined by RFC3339.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AuditCollectionStartTime is required.")]
        [JsonProperty(PropertyName = "auditCollectionStartTime")]
        public System.Nullable<System.DateTime> AuditCollectionStartTime { get; set; }
        
        /// <value>
        /// Indicates if auto purge is enabled on the target database, which helps delete audit data in the
        /// target database every seven days so that the database's audit trail does not become too large.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutoPurgeEnabled")]
        public System.Nullable<bool> IsAutoPurgeEnabled { get; set; }
        
    }
}
