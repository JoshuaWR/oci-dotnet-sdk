/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.OptimizerService.Models;

namespace Oci.OptimizerService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/optimizer/ListResourceActions.cs.html">here</a> to see an example of how to use ListResourceActions request.
    /// </example>
    public class ListResourceActionsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// When set to true, the hierarchy of compartments is traversed and all compartments and subcompartments in the tenancy are returned depending on the the setting of `accessLevel`.
        /// <br/>
        /// Can only be set to true when performing ListCompartments on the tenancy (root compartment).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentIdInSubtree is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
        
        /// <value>
        /// The unique OCID associated with the recommendation.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "recommendationId")]
        public string RecommendationId { get; set; }
        
        /// <value>
        /// Optional. A filter that returns results that match the recommendation name specified.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "recommendationName")]
        public string RecommendationName { get; set; }
        
        /// <value>
        /// A list of child tenancies for which the respective data will be returned. Please note that 
        /// the parent tenancy id can also be included in this list. For example, if there is a parent P with two
        /// children A and B, to return results of only parent P and child A, this list should be populated with 
        /// tenancy id of parent P and child A. 
        /// <br/>
        /// If this list contains a tenancy id that isn't part of the organization of parent P, the request will 
        /// fail. That is, let's say there is an organization with parent P with children A and B, and also one 
        /// other tenant T that isn't part of the organization. If T is included in the list of 
        /// childTenancyIds, the request will fail.
        /// <br/>
        /// It is important to note that if you are setting the includeOrganization parameter value as true and 
        /// also populating the childTenancyIds parameter with a list of child tenancies, the request will fail.
        /// The childTenancyIds and includeOrganization should be used exclusively.
        /// <br/>
        /// When using this parameter, please make sure to set the compartmentId with the parent tenancy ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "childTenancyIds", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> ChildTenancyIds { get; set; }
        
        /// <value>
        /// When set to true, the data for all child tenancies including the parent is returned. That is, if 
        /// there is an organization with parent P and children A and B, to return the data for the parent P, child 
        /// A and child B, this parameter value should be set to true.
        /// <br/>
        /// Please note that this parameter shouldn't be used along with childTenancyIds parameter. If you would like 
        /// to get results specifically for parent P and only child A, use the childTenancyIds parameter and populate
        /// the list with tenancy id of P and A.
        /// <br/>
        /// When using this parameter, please make sure to set the compartmentId with the parent tenancy ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "includeOrganization")]
        public System.Nullable<bool> IncludeOrganization { get; set; }
        
        /// <value>
        /// Optional. A filter that returns results that match the name specified.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Optional. A filter that returns results that match the resource type specified.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// The maximum number of items to return in a paginated \"List\" call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` response header from the previous \"List\" call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. You can provide one sort order (`sortOrder`). Default order for TIMECREATED is descending. Default order for NAME is ascending. The NAME sort order is case sensitive.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "NAME")]
            Name,
            [EnumMember(Value = "TIMECREATED")]
            Timecreated
        };

        /// <value>
        /// The field to sort by. You can provide one sort order (`sortOrder`). Default order for TIMECREATED is descending. Default order for NAME is ascending. The NAME sort order is case sensitive.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// A filter that returns results that match the lifecycle state specified.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A filter that returns recommendations that match the status specified.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "status")]
        public System.Nullable<Status> Status { get; set; }
        
        /// <value>
        /// Supplement additional resource information in extended metadata response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "includeResourceMetadata")]
        public System.Nullable<bool> IncludeResourceMetadata { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request.
        /// If you need to contact Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
