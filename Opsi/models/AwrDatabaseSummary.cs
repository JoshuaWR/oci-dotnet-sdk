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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// The AWR summary for a database.
    /// </summary>
    public class AwrDatabaseSummary 
    {
        
        /// <value>
        /// The internal ID of the database. The internal ID of the database is not the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// It can be retrieved from the following endpoint:
        /// /awrHubs/{awrHubId}/awrDatabases
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AwrSourceDatabaseIdentifier is required.")]
        [JsonProperty(PropertyName = "awrSourceDatabaseIdentifier")]
        public string AwrSourceDatabaseIdentifier { get; set; }
        
        /// <value>
        /// The name of the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbName is required.")]
        [JsonProperty(PropertyName = "dbName")]
        public string DbName { get; set; }
        
        /// <value>
        /// The database instance numbers.
        /// </value>
        [JsonProperty(PropertyName = "instanceList")]
        public System.Collections.Generic.List<int> InstanceList { get; set; }
        
        /// <value>
        /// The timestamp of the database startup.
        /// </value>
        [JsonProperty(PropertyName = "timeDbStartup")]
        public System.Nullable<System.DateTime> TimeDbStartup { get; set; }
        
        /// <value>
        /// The start time of the earliest snapshot.
        /// </value>
        [JsonProperty(PropertyName = "timeFirstSnapshotBegin")]
        public System.Nullable<System.DateTime> TimeFirstSnapshotBegin { get; set; }
        
        /// <value>
        /// The end time of the latest snapshot.
        /// </value>
        [JsonProperty(PropertyName = "timeLatestSnapshotEnd")]
        public System.Nullable<System.DateTime> TimeLatestSnapshotEnd { get; set; }
        
        /// <value>
        /// The ID of the earliest snapshot. The snapshot identifier is not the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// It can be retrieved from the following endpoint:
        /// /awrHubs/{awrHubId}/awrDatabaseSnapshots
        /// 
        /// </value>
        [JsonProperty(PropertyName = "firstSnapshotIdentifier")]
        public System.Nullable<int> FirstSnapshotIdentifier { get; set; }
        
        /// <value>
        /// The ID of the latest snapshot. The snapshot identifier is not the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// It can be retrieved from the following endpoint:
        /// /awrHubs/{awrHubId}/awrDatabaseSnapshots
        /// 
        /// </value>
        [JsonProperty(PropertyName = "latestSnapshotIdentifier")]
        public System.Nullable<int> LatestSnapshotIdentifier { get; set; }
        
        /// <value>
        /// The total number of snapshots.
        /// </value>
        [JsonProperty(PropertyName = "snapshotCount")]
        public System.Nullable<long> SnapshotCount { get; set; }
        
        /// <value>
        /// The interval time between snapshots (in minutes).
        /// </value>
        [JsonProperty(PropertyName = "snapshotIntervalInMin")]
        public System.Nullable<int> SnapshotIntervalInMin { get; set; }
        
        /// <value>
        /// The version of the database.
        /// </value>
        [JsonProperty(PropertyName = "dbVersion")]
        public string DbVersion { get; set; }
        
        /// <value>
        /// The time zone of the snapshot. sample -  snapshotTimezone=+0 00:00:00
        /// </value>
        [JsonProperty(PropertyName = "snapshotTimezone")]
        public string SnapshotTimezone { get; set; }
        
    }
}
