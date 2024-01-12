/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.AdmService.Models;

namespace Oci.AdmService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/adm/ListApplicationDependencyVulnerabilities.cs.html">here</a> to see an example of how to use ListApplicationDependencyVulnerabilities request.
    /// </example>
    public class ListApplicationDependencyVulnerabilitiesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique Vulnerability Audit identifier path parameter.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VulnerabilityAuditId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "vulnerabilityAuditId")]
        public string VulnerabilityAuditId { get; set; }
        
        /// <value>
        /// A filter to return only Vulnerability Audits that match the specified id.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "vulnerabilityId")]
        public string VulnerabilityId { get; set; }
        
        /// <value>
        /// A filter that returns only Vulnerabilities that have a Common Vulnerability Scoring System Version 3 (CVSS V3) greater than or equal to the specified value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "cvssV3GreaterThanOrEqual")]
        public System.Nullable<float> CvssV3GreaterThanOrEqual { get; set; }
        
        /// <value>
        /// A filter that returns only Vulnerabilities that have a Common Vulnerability Scoring System Version 2 (CVSS V2) greater than or equal to the specified value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "cvssV2GreaterThanOrEqual")]
        public System.Nullable<float> CvssV2GreaterThanOrEqual { get; set; }
        
        /// <value>
        /// A filter that returns only Vulnerabilities that have a severity greater than or equal to the specified value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "severityGreaterThanOrEqual")]
        public System.Nullable<VulnerabilitySeverity> SeverityGreaterThanOrEqual { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// A token representing the position at which to start retrieving results. This must come from the `opc-next-page` header field of a previous response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The sort order to use, either 'ASC' or 'DESC'.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one sort order may be provided.
        /// If sort order is dfs, the nodes are returned by going through the application dependency tree in a depth-first manner. Children are sorted based on their GAV property alphabetically (either ascending or descending, depending on the order parameter). Default order is ascending.
        /// If sort order is bfs, the nodes are returned by going through the application dependency tree in a breadth-first manner. Children are sorted based on their GAV property alphabetically (either ascending or descending, depending on the order parameter). Default order is ascending.
        /// Default order for gav is ascending where ascending corresponds to alphanumerical order.
        /// Default order for purl is ascending where ascending corresponds to alphabetical order
        /// Default order for nodeId is ascending where ascending corresponds to alphanumerical order.
        /// Sorting by DFS or BFS cannot be used in conjunction with the following query parameters: \"gav\", \"cvssV2GreaterThanOrEqual\", \"cvssV3GreaterThanOrEqual\" and \"vulnerabilityId\".
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "gav")]
            Gav,
            [EnumMember(Value = "purl")]
            Purl,
            [EnumMember(Value = "nodeId")]
            NodeId,
            [EnumMember(Value = "dfs")]
            Dfs,
            [EnumMember(Value = "bfs")]
            Bfs
        };

        /// <value>
        /// The field to sort by. Only one sort order may be provided.
        /// If sort order is dfs, the nodes are returned by going through the application dependency tree in a depth-first manner. Children are sorted based on their GAV property alphabetically (either ascending or descending, depending on the order parameter). Default order is ascending.
        /// If sort order is bfs, the nodes are returned by going through the application dependency tree in a breadth-first manner. Children are sorted based on their GAV property alphabetically (either ascending or descending, depending on the order parameter). Default order is ascending.
        /// Default order for gav is ascending where ascending corresponds to alphanumerical order.
        /// Default order for purl is ascending where ascending corresponds to alphabetical order
        /// Default order for nodeId is ascending where ascending corresponds to alphanumerical order.
        /// Sorting by DFS or BFS cannot be used in conjunction with the following query parameters: \"gav\", \"cvssV2GreaterThanOrEqual\", \"cvssV3GreaterThanOrEqual\" and \"vulnerabilityId\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// A filter to override the top level root identifier with the new given value. The application dependency tree will only be traversed from the given node.
        /// Query parameters \"cvssV2GreaterThanOrEqual\", \"cvssV3GreaterThanOrEqual\", \"gav\" and \"vulnerabilityId\" cannot be used in conjunction with this parameter.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "rootNodeId")]
        public string RootNodeId { get; set; }
        
        /// <value>
        /// A filter to limit depth of the application dependencies tree traversal.
        /// Additionally query parameters such as \"cvssV2GreaterThanOrEqual\", \"cvssV3GreaterThanOrEqual\", \"gav\" and \"vulnerabilityId\" can't be used in conjunction with this latter.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "depth")]
        public System.Nullable<int> Depth { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the entire GAV (Group Artifact Version) identifier given.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "gav")]
        public string Gav { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the entire PURL given (https://github.com/package-url/purl-spec/).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "purl")]
        public string Purl { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
