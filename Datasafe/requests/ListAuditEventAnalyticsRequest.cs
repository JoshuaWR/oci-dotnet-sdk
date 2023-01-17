/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatasafeService.Models;

namespace Oci.DatasafeService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datasafe/ListAuditEventAnalytics.cs.html">here</a> to see an example of how to use ListAuditEventAnalytics request.
    /// </example>
    public class ListAuditEventAnalyticsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// A filter to return only resources that match the specified compartment OCID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// For optimistic concurrency control. In the PUT or DELETE call
        /// for a resource, set the if-match parameter to the value of the
        /// etag from a previous GET or POST response for that resource.
        /// The resource will be updated or deleted only if the etag you
        /// provide matches the resource's current etag value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// It is usually retrieved from a previous \"List\" call. For details about how pagination works,
        /// see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// Default is false.
        /// When set to true, the hierarchy of compartments is traversed and all compartments and subcompartments in the tenancy are returned. Depends on the 'accessLevel' setting.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
        
        ///
        /// <value>
        /// Valid values are RESTRICTED and ACCESSIBLE. Default is RESTRICTED.
        /// Setting this to ACCESSIBLE returns only those compartments for which the
        /// user has INSPECT permissions directly or indirectly (permissions can be on a
        /// resource in a subcompartment). When set to RESTRICTED permissions are checked and no partial results are displayed.
        /// 
        /// </value>
        ///
        public enum AccessLevelEnum {
            [EnumMember(Value = "RESTRICTED")]
            Restricted,
            [EnumMember(Value = "ACCESSIBLE")]
            Accessible
        };

        /// <value>
        /// Valid values are RESTRICTED and ACCESSIBLE. Default is RESTRICTED.
        /// Setting this to ACCESSIBLE returns only those compartments for which the
        /// user has INSPECT permissions directly or indirectly (permissions can be on a
        /// resource in a subcompartment). When set to RESTRICTED permissions are checked and no partial results are displayed.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "accessLevel")]
        public System.Nullable<AccessLevelEnum> AccessLevel { get; set; }
        
        /// <value>
        /// The scimQuery query parameter accepts filter expressions that use the syntax described in Section 3.2.2.2
        /// of the System for Cross-Domain Identity Management (SCIM) specification, which is available
        /// at [RFC3339](https://tools.ietf.org/html/draft-ietf-scim-api-12). In SCIM filtering expressions,
        /// text, date, and time values must be enclosed in quotation marks, with date and time values using ISO-8601 format.
        /// (Numeric and boolean values should not be quoted.)
        /// <br/>
        /// **Example: ** query=(operationTime ge '2021-06-04T01-00-26') and (eventName eq 'LOGON')
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "scimQuery")]
        public string ScimQuery { get; set; }
        
        ///
        /// <value>
        /// Specifies a subset of summarized fields to be returned in the response.
        /// </value>
        ///
        public enum SummaryFieldEnum {
            [EnumMember(Value = "auditEventTime")]
            AuditEventTime,
            [EnumMember(Value = "dbUserName")]
            DbUserName,
            [EnumMember(Value = "targetId")]
            TargetId,
            [EnumMember(Value = "targetName")]
            TargetName,
            [EnumMember(Value = "targetClass")]
            TargetClass,
            [EnumMember(Value = "objectType")]
            ObjectType,
            [EnumMember(Value = "clientHostname")]
            ClientHostname,
            [EnumMember(Value = "clientProgram")]
            ClientProgram,
            [EnumMember(Value = "clientId")]
            ClientId,
            [EnumMember(Value = "auditType")]
            AuditType,
            [EnumMember(Value = "eventName")]
            EventName,
            [EnumMember(Value = "allRecord")]
            AllRecord,
            [EnumMember(Value = "auditSettingsChange")]
            AuditSettingsChange,
            [EnumMember(Value = "dbSchemaChange")]
            DbSchemaChange,
            [EnumMember(Value = "entitlementChange")]
            EntitlementChange,
            [EnumMember(Value = "loginFailure")]
            LoginFailure,
            [EnumMember(Value = "loginSuccess")]
            LoginSuccess,
            [EnumMember(Value = "allViolations")]
            AllViolations,
            [EnumMember(Value = "realmViolations")]
            RealmViolations,
            [EnumMember(Value = "ruleViolations")]
            RuleViolations,
            [EnumMember(Value = "dvconfigActivities")]
            DvconfigActivities,
            [EnumMember(Value = "ddls")]
            Ddls,
            [EnumMember(Value = "dmls")]
            Dmls,
            [EnumMember(Value = "privilegeChanges")]
            PrivilegeChanges,
            [EnumMember(Value = "auditSettingsEnables")]
            AuditSettingsEnables,
            [EnumMember(Value = "auditSettingsDisables")]
            AuditSettingsDisables,
            [EnumMember(Value = "selects")]
            Selects,
            [EnumMember(Value = "creates")]
            Creates,
            [EnumMember(Value = "alters")]
            Alters,
            [EnumMember(Value = "drops")]
            Drops,
            [EnumMember(Value = "grants")]
            Grants,
            [EnumMember(Value = "revokes")]
            Revokes
        };

        /// <value>
        /// Specifies a subset of summarized fields to be returned in the response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "summaryField", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<SummaryFieldEnum> SummaryField { get; set; }
        
        /// <value>
        /// An optional filter to return audit events whose creation time in the database is greater than and equal to the date-time specified,
        /// in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// An optional filter to return audit events whose creation time in the database is less than and equal to the date-time specified,
        /// in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeEnded")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }
        
        /// <value>
        /// Default time zone is UTC if no time zone provided. The date-time considerations of the resource will be in accordance with the specified time zone.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "queryTimeZone")]
        public string QueryTimeZone { get; set; }
        
        ///
        /// <value>
        /// A groupBy can only be used in combination with summaryField parameter.
        /// A groupBy value has to be a subset of the values mentioned in summaryField parameter.
        /// 
        /// </value>
        ///
        public enum GroupByEnum {
            [EnumMember(Value = "auditEventTime")]
            AuditEventTime,
            [EnumMember(Value = "dbUserName")]
            DbUserName,
            [EnumMember(Value = "targetId")]
            TargetId,
            [EnumMember(Value = "targetName")]
            TargetName,
            [EnumMember(Value = "targetClass")]
            TargetClass,
            [EnumMember(Value = "objectType")]
            ObjectType,
            [EnumMember(Value = "clientHostname")]
            ClientHostname,
            [EnumMember(Value = "clientProgram")]
            ClientProgram,
            [EnumMember(Value = "clientId")]
            ClientId,
            [EnumMember(Value = "auditType")]
            AuditType,
            [EnumMember(Value = "eventName")]
            EventName
        };

        /// <value>
        /// A groupBy can only be used in combination with summaryField parameter.
        /// A groupBy value has to be a subset of the values mentioned in summaryField parameter.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "groupBy", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<GroupByEnum> GroupBy { get; set; }
        
        /// <value>
        /// A token that uniquely identifies a request so it can be retried in case of a timeout or
        /// server error without risk of executing that same action again. Retry tokens expire after 24
        /// hours, but can be invalidated before then due to conflicting operations. For example, if a resource
        /// has been deleted and purged from the system, then a retry of the original creation request might be rejected.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
        
        ///
        /// <value>
        /// The sort order to use, either ascending (ASC) or descending (DESC).
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use, either ascending (ASC) or descending (DESC).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        ///
        /// <value>
        /// If this query parameter is specified, the result is ordered based on this query parameter value.
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "targetId")]
            TargetId,
            [EnumMember(Value = "targetClass")]
            TargetClass,
            [EnumMember(Value = "targetName")]
            TargetName,
            [EnumMember(Value = "objectType")]
            ObjectType,
            [EnumMember(Value = "dbUserName")]
            DbUserName,
            [EnumMember(Value = "eventName")]
            EventName,
            [EnumMember(Value = "auditEventTime")]
            AuditEventTime,
            [EnumMember(Value = "clientHostname")]
            ClientHostname,
            [EnumMember(Value = "clientProgram")]
            ClientProgram,
            [EnumMember(Value = "clientId")]
            ClientId,
            [EnumMember(Value = "auditType")]
            AuditType
        };

        /// <value>
        /// If this query parameter is specified, the result is ordered based on this query parameter value.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
    }
}
