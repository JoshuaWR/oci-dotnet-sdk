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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datasafe/ListSensitiveTypes.cs.html">here</a> to see an example of how to use ListSensitiveTypes request.
    /// </example>
    public class ListSensitiveTypesRequest : Oci.Common.IOciRequest
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
        /// A filter to return only resources that match the specified display name.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A filter to return only items related to a specific sensitive type OCID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sensitiveTypeId")]
        public string SensitiveTypeId { get; set; }
        
        /// <value>
        /// A filter to return the sensitive type resources based on the value of their source attribute.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sensitiveTypeSource")]
        public System.Nullable<SensitiveTypeSource> SensitiveTypeSource { get; set; }
        
        /// <value>
        /// A filter to return the sensitive type resources based on the value of their entityType attribute.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "entityType")]
        public System.Nullable<SensitiveTypeEntity> EntityType { get; set; }
        
        /// <value>
        /// A filter to return only the sensitive types that are children of the sensitive category identified by the specified OCID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "parentCategoryId")]
        public string ParentCategoryId { get; set; }
        
        /// <value>
        /// A filter to return only the sensitive types that have the default masking format identified by the specified OCID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "defaultMaskingFormatId")]
        public string DefaultMaskingFormatId { get; set; }
        
        /// <value>
        /// A filter to return only the resources that were created after the specified date and time, as defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Using TimeCreatedGreaterThanOrEqualToQueryParam parameter retrieves all resources created after that date.
        /// <br/>
        /// **Example: ** 2016-12-19T16:39:57.600Z
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeCreatedGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeCreatedGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// Search for resources that were created before a specific date.
        /// Specifying this parameter corresponding `timeCreatedLessThan`
        /// parameter will retrieve all resources created before the
        /// specified created date, in \"YYYY-MM-ddThh:mmZ\" format with a Z offset, as
        /// defined by RFC 3339.
        /// <br/>
        /// **Example: ** 2016-12-19T16:39:57.600Z
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeCreatedLessThan")]
        public System.Nullable<System.DateTime> TimeCreatedLessThan { get; set; }
        
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
        /// The field to sort by. You can specify only one sort order (sortOrder). The default order for timeCreated is descending.
        /// The default order for displayName is ascending.
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
        /// The field to sort by. You can specify only one sort order (sortOrder). The default order for timeCreated is descending.
        /// The default order for displayName is ascending.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// For list pagination. The maximum number of items to return per page in a paginated \"List\" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// For list pagination. The page token representing the page at which to start retrieving results. It is usually retrieved from a previous \"List\" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// A filter to return only the resources that match the specified lifecycle state.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<DiscoveryLifecycleState> LifecycleState { get; set; }
    }
}
