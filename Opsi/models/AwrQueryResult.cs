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
using Newtonsoft.Json.Linq;

namespace Oci.OpsiService.Models
{
    /// <summary>
    /// The AWR query result.
    /// </summary>
    [JsonConverter(typeof(AwrQueryResultModelConverter))]
    public class AwrQueryResult 
    {
        
        /// <value>
        /// The name of the query result.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The version of the query result.
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// The time taken to query the database tier (in seconds).
        /// </value>
        [JsonProperty(PropertyName = "dbQueryTimeInSecs")]
        public System.Double DbQueryTimeInSecs { get; set; }
                ///
        /// <value>
        /// The result type of AWR query.
        /// </value>
        ///
        public enum AwrResultTypeEnum {
            [EnumMember(Value = "AWRDB_SET")]
            AwrdbSet,
            [EnumMember(Value = "AWRDB_SNAPSHOT_RANGE_SET")]
            AwrdbSnapshotRangeSet,
            [EnumMember(Value = "AWRDB_SNAPSHOT_SET")]
            AwrdbSnapshotSet,
            [EnumMember(Value = "AWRDB_METRICS_SET")]
            AwrdbMetricsSet,
            [EnumMember(Value = "AWRDB_SYSSTAT_SET")]
            AwrdbSysstatSet,
            [EnumMember(Value = "AWRDB_TOP_EVENT_SET")]
            AwrdbTopEventSet,
            [EnumMember(Value = "AWRDB_EVENT_SET")]
            AwrdbEventSet,
            [EnumMember(Value = "AWRDB_EVENT_HISTOGRAM")]
            AwrdbEventHistogram,
            [EnumMember(Value = "AWRDB_DB_PARAMETER_SET")]
            AwrdbDbParameterSet,
            [EnumMember(Value = "AWRDB_DB_PARAMETER_CHANGE")]
            AwrdbDbParameterChange,
            [EnumMember(Value = "AWRDB_ASH_CPU_USAGE_SET")]
            AwrdbAshCpuUsageSet,
            [EnumMember(Value = "AWRDB_DB_REPORT")]
            AwrdbDbReport,
            [EnumMember(Value = "AWRDB_SQL_REPORT")]
            AwrdbSqlReport
        };

        
    }

    public class AwrQueryResultModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(AwrQueryResult);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(AwrQueryResult);
            var discriminator = jsonObject["awrResultType"].Value<string>();
            switch (discriminator)
            {
                case "AWRDB_ASH_CPU_USAGE_SET":
                    obj = new AwrDatabaseCpuUsageCollection();
                    break;
                case "AWRDB_DB_PARAMETER_SET":
                    obj = new AwrDatabaseParameterCollection();
                    break;
                case "AWRDB_EVENT_HISTOGRAM_SET":
                    obj = new AwrDatabaseWaitEventBucketCollection();
                    break;
                case "AWRDB_SNAPSHOT_RANGE_SET":
                    obj = new AwrDatabaseSnapshotRangeCollection();
                    break;
                case "AWRDB_SNAPSHOT_SET":
                    obj = new AwrDatabaseSnapshotCollection();
                    break;
                case "AWRDB_SYSSTAT_SET":
                    obj = new AwrDatabaseSysstatCollection();
                    break;
                case "AWRDB_METRICS_SET":
                    obj = new AwrDatabaseMetricCollection();
                    break;
                case "AWRDB_EVENT_SET":
                    obj = new AwrDatabaseWaitEventCollection();
                    break;
                case "AWRDB_SET":
                    obj = new AwrDatabaseCollection();
                    break;
                case "AWRDB_TOP_EVENT_SET":
                    obj = new AwrDatabaseTopWaitEventCollection();
                    break;
                case "AWRDB_DB_PARAMETER_CHANGE":
                    obj = new AwrDatabaseParameterChangeCollection();
                    break;
                case "AWRDB_DB_REPORT":
                    obj = new AwrDatabaseReport();
                    break;
                case "AWRDB_SQL_REPORT":
                    obj = new AwrDatabaseSqlReport();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under AwrQueryResult! Returning null value.");
            }
            return obj;
        }
    }
}
