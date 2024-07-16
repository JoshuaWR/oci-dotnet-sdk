/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatabaseService.Models;

namespace Oci.DatabaseService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/database/ListGiVersionMinorVersions.cs.html">here</a> to see an example of how to use ListGiVersionMinorVersions request.
    /// </example>
    public class ListGiVersionMinorVersionsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The Oracle Grid Infrastructure major version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "version")]
        public string Version { get; set; }
        
        /// <value>
        /// The target availability domain. Only passed if the limit is AD-specific.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The compartment [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        ///
        /// <value>
        /// If provided, filters the results to the set of database versions which are supported for the given shape family.
        /// </value>
        ///
        public enum ShapeFamilyEnum {
            [EnumMember(Value = "SINGLENODE")]
            Singlenode,
            [EnumMember(Value = "YODA")]
            Yoda,
            [EnumMember(Value = "VIRTUALMACHINE")]
            Virtualmachine,
            [EnumMember(Value = "EXADATA")]
            Exadata,
            [EnumMember(Value = "EXACC")]
            Exacc,
            [EnumMember(Value = "EXADB_XS")]
            ExadbXs
        };

        /// <value>
        /// If provided, filters the results to the set of database versions which are supported for the given shape family.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "shapeFamily")]
        public System.Nullable<ShapeFamilyEnum> ShapeFamily { get; set; }
        
        /// <value>
        /// If true, returns the Grid Infrastructure versions that can be used for provisioning a cluster
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isGiVersionForProvisioning")]
        public System.Nullable<bool> IsGiVersionForProvisioning { get; set; }
        
        /// <value>
        /// If provided, filters the results for the given shape.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "shape")]
        public string Shape { get; set; }
        
        ///
        /// <value>
        /// Sort by VERSION.  Default order for VERSION is descending.
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "VERSION")]
            Version
        };

        /// <value>
        /// Sort by VERSION.  Default order for VERSION is descending.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// The maximum number of items to return per page.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The pagination token to continue listing from.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
    }
}