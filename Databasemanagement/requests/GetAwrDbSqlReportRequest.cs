/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatabasemanagementService.Models;

namespace Oci.DatabasemanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/databasemanagement/GetAwrDbSqlReport.cs.html">here</a> to see an example of how to use GetAwrDbSqlReport request.
    /// </example>
    public class GetAwrDbSqlReportRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagedDatabaseId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "managedDatabaseId")]
        public string ManagedDatabaseId { get; set; }
        
        /// <value>
        /// The parameter to filter the database by internal ID.
        /// Note that the internal ID of the database can be retrieved from the following endpoint:
        /// /managedDatabases/{managedDatabaseId}/awrDbs:
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AwrDbId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "awrDbId")]
        public string AwrDbId { get; set; }
        
        /// <value>
        /// The parameter to filter SQL by ID. Note that the SQL ID is generated internally by Oracle for each SQL statement and can be retrieved from AWR Report API (/managedDatabases/{managedDatabaseId}/awrDbs/{awrDbId}/awrDbReport) or Performance Hub API (/internal/managedDatabases/{managedDatabaseId}/actions/retrievePerformanceData)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sqlId")]
        public string SqlId { get; set; }
        
        /// <value>
        /// The optional single value query parameter to filter the database instance number.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "instNum")]
        public string InstNum { get; set; }
        
        /// <value>
        /// The optional greater than or equal to filter on the snapshot ID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "beginSnIdGreaterThanOrEqualTo")]
        public System.Nullable<int> BeginSnIdGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// The optional less than or equal to query parameter to filter the snapshot ID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "endSnIdLessThanOrEqualTo")]
        public System.Nullable<int> EndSnIdLessThanOrEqualTo { get; set; }
        
        /// <value>
        /// The optional greater than or equal to query parameter to filter the timestamp.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// The optional less than or equal to query parameter to filter the timestamp.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeLessThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeLessThanOrEqualTo { get; set; }
        
        ///
        /// <value>
        /// The format of the AWR report.
        /// </value>
        ///
        public enum ReportFormatEnum {
            [EnumMember(Value = "HTML")]
            Html,
            [EnumMember(Value = "TEXT")]
            Text
        };

        /// <value>
        /// The format of the AWR report.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "reportFormat")]
        public System.Nullable<ReportFormatEnum> ReportFormat { get; set; }
        
        /// <value>
        /// The optional query parameter to filter the database container by an exact ID value.
        /// Note that the database container ID can be retrieved from the following endpoint:
        /// /managedDatabases/{managedDatabaseId}/awrDbSnapshotRanges
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "containerId")]
        public System.Nullable<int> ContainerId { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// A token that uniquely identifies a request so it can be retried in case of a timeout or
        /// server error without risk of executing that same action again. Retry tokens expire after 24
        /// hours, but can be invalidated before then due to conflicting operations. For example, if a resource
        /// has been deleted and purged from the system, then a retry of the original creation request
        /// might be rejected.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
    }
}
