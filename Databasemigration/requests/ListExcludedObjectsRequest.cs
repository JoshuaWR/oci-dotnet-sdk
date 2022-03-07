/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatabasemigrationService.Models;

namespace Oci.DatabasemigrationService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/databasemigration/ListExcludedObjects.cs.html">here</a> to see an example of how to use ListExcludedObjects request.
    /// </example>
    public class ListExcludedObjectsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the job
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JobId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "jobId")]
        public string JobId { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a
        /// particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The sort order to use, either 'asc' or 'desc'.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrders> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one sort order may be provided.
        /// Default order for reasonCategory is ascending.
        /// If no value is specified reasonCategory is default.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "type")]
            Type,
            [EnumMember(Value = "reasonCategory")]
            ReasonCategory
        };

        /// <value>
        /// The field to sort by. Only one sort order may be provided.
        /// Default order for reasonCategory is ascending.
        /// If no value is specified reasonCategory is default.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// Excluded object type.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "type")]
        public string Type { get; set; }
        
        /// <value>
        /// Excluded object owner
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "owner")]
        public string Owner { get; set; }
        
        /// <value>
        /// Excluded object name
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "object")]
        public string Object { get; set; }
        
        /// <value>
        /// Excluded object owner which contains provided value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "ownerContains")]
        public string OwnerContains { get; set; }
        
        /// <value>
        /// Excluded object name which contains provided value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "objectContains")]
        public string ObjectContains { get; set; }
        
        /// <value>
        /// Reason category for the excluded object
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "reasonCategory")]
        public System.Nullable<ReasonKeywords> ReasonCategory { get; set; }
        
        /// <value>
        /// Exclude object rule that matches the excluded object, if applicable.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sourceRule")]
        public string SourceRule { get; set; }
    }
}
