/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.MarketplaceService.Models;

namespace Oci.MarketplaceService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/marketplace/ListPublicationPackages.cs.html">here</a> to see an example of how to use ListPublicationPackages request.
    /// </example>
    public class ListPublicationPackagesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The unique identifier for the publication.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PublicationId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "publicationId")]
        public string PublicationId { get; set; }
        
        /// <value>
        /// The version of the package. Package versions are unique within a listing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "packageVersion")]
        public string PackageVersion { get; set; }
        
        /// <value>
        /// A filter to return only packages that match the given package type exactly.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "packageType")]
        public string PackageType { get; set; }
        
        ///
        /// <value>
        /// The field to use to sort listed results. You can only specify one field to sort by.
        /// `TIMERELEASED` displays results in descending order by default.
        /// You can change your preference by specifying a different sort order.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "TIMERELEASED")]
            Timereleased
        };

        /// <value>
        /// The field to use to sort listed results. You can only specify one field to sort by.
        /// `TIMERELEASED` displays results in descending order by default.
        /// You can change your preference by specifying a different sort order.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The sort order to use, either `ASC` or `DESC`.
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use, either `ASC` or `DESC`.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// How many records to return. Specify a value greater than zero and less than or equal to 1000. The default is 30.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` response header from the previous \"List\" call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request,
        /// please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
