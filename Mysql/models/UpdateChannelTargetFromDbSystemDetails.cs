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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// Parameters detailing how to provision the target endpoint that is a DB System.
    /// </summary>
    public class UpdateChannelTargetFromDbSystemDetails : UpdateChannelTargetDetails
    {
        
        /// <value>
        /// The case-insensitive name that identifies the replication channel. Channel names
        /// must follow the rules defined for [MySQL identifiers](https://dev.mysql.com/doc/refman/8.0/en/identifiers.html).
        /// The names of non-Deleted Channels must be unique for each DB System.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "channelName")]
        public string ChannelName { get; set; }
        
        /// <value>
        /// The username for the replication applier of the target MySQL DB System.
        /// </value>
        [JsonProperty(PropertyName = "applierUsername")]
        public string ApplierUsername { get; set; }
        
        /// <value>
        /// Replication filter rules to be applied at the DB System Channel target.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "filters")]
        public System.Collections.Generic.List<ChannelFilter> Filters { get; set; }
        
        [JsonProperty(PropertyName = "targetType")]
        private readonly string targetType = "DBSYSTEM";
    }
}
