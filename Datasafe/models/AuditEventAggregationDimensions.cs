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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Details of aggregation dimensions used for summarizing audit events.
    /// </summary>
    public class AuditEventAggregationDimensions 
    {
        
        /// <value>
        /// Time of audit event occurrence in the target database.
        /// </value>
        [JsonProperty(PropertyName = "auditEventTime")]
        public System.Collections.Generic.List<System.DateTime> AuditEventTime { get; set; }
        
        /// <value>
        /// Name of the database user whose actions were audited.
        /// </value>
        [JsonProperty(PropertyName = "dbUserName")]
        public System.Collections.Generic.List<string> DbUserName { get; set; }
        
        /// <value>
        /// The OCID of the target database that was audited.
        /// </value>
        [JsonProperty(PropertyName = "targetId")]
        public System.Collections.Generic.List<string> TargetId { get; set; }
        
        /// <value>
        /// The name of the target database that was audited.
        /// </value>
        [JsonProperty(PropertyName = "targetName")]
        public System.Collections.Generic.List<string> TargetName { get; set; }
                ///
        ///
        public enum TargetClassEnum {
            [EnumMember(Value = "DATABASE")]
            Database
        };

        /// <value>
        /// Class of the target that was audited.
        /// </value>
        [JsonProperty(PropertyName = "targetClass", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<TargetClassEnum> TargetClass { get; set; }
        
        /// <value>
        /// Type of object in the source database affected by the action. i.e PL/SQL, SYNONYM, PACKAGE BODY.
        /// </value>
        [JsonProperty(PropertyName = "objectType")]
        public System.Collections.Generic.List<string> ObjectType { get; set; }
        
        /// <value>
        /// Name of the host machine from which the session was spawned.
        /// </value>
        [JsonProperty(PropertyName = "clientHostname")]
        public System.Collections.Generic.List<string> ClientHostname { get; set; }
        
        /// <value>
        /// The application from which the audit event was generated. Examples SQL Plus or SQL Developer.
        /// </value>
        [JsonProperty(PropertyName = "clientProgram")]
        public System.Collections.Generic.List<string> ClientProgram { get; set; }
        
        /// <value>
        /// The client identifier in each Oracle session.
        /// </value>
        [JsonProperty(PropertyName = "clientId")]
        public System.Collections.Generic.List<string> ClientId { get; set; }
                ///
        ///
        public enum AuditTypeEnum {
            [EnumMember(Value = "STANDARD")]
            Standard,
            [EnumMember(Value = "FINE_GRAINED")]
            FineGrained,
            [EnumMember(Value = "XS")]
            Xs,
            [EnumMember(Value = "DATABASE_VAULT")]
            DatabaseVault,
            [EnumMember(Value = "LABEL_SECURITY")]
            LabelSecurity,
            [EnumMember(Value = "RMAN")]
            Rman,
            [EnumMember(Value = "DATAPUMP")]
            Datapump,
            [EnumMember(Value = "DIRECT_PATH_API")]
            DirectPathApi
        };

        /// <value>
        /// Type of auditing.
        /// </value>
        [JsonProperty(PropertyName = "auditType", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<AuditTypeEnum> AuditType { get; set; }
        
        /// <value>
        /// Name of the detail action executed by the user on the target database. i.e ALTER SEQUENCE, CREATE TRIGGER, CREATE INDEX.
        /// </value>
        [JsonProperty(PropertyName = "eventName")]
        public System.Collections.Generic.List<string> EventName { get; set; }
        
    }
}
