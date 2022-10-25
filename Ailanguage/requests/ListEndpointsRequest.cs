/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.AilanguageService.Models;

namespace Oci.AilanguageService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/ailanguage/ListEndpoints.cs.html">here</a> to see an example of how to use ListEndpoints request.
    /// </example>
    public class ListEndpointsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The ID of the compartment in which to list resources.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The OCID of the endpoint.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "endpointId")]
        public string EndpointId { get; set; }
        
        /// <value>
        /// The ID of the project for which to list the objects.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "projectId")]
        public string ProjectId { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the entire display name given.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The ID of the trained model for which to list the endpoints.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "modelId")]
        public string ModelId { get; set; }
        
        /// <value>
        /// <b>Filter</b> results by the specified lifecycle state. Must be a valid
        /// state for the resource type.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<Endpoint.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The sort order to use, either 'asc' or 'desc'.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        ///
        /// <value>
        /// Specifies the field to sort by. Accepts only one field.
        /// By default, when you sort by `timeCreated`, the results are shown
        /// in descending order. When you sort by `displayName`, the results are
        /// shown in ascending order. Sort order for the `displayName` field is case sensitive.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "displayName")]
            DisplayName
        };

        /// <value>
        /// Specifies the field to sort by. Accepts only one field.
        /// By default, when you sort by `timeCreated`, the results are shown
        /// in descending order. When you sort by `displayName`, the results are
        /// shown in ascending order. Sort order for the `displayName` field is case sensitive.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
