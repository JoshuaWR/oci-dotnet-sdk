/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.MarketplaceService.Models
{
    /// <summary>
    /// A package for image listings.
    /// </summary>
    public class ImageListingPackage : ListingPackage
    {
        
        /// <value>
        /// The ID of the listing resource associated with this listing package. For more information, see [AppCatalogListing](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/iaas/latest/AppCatalogListing/) in the Core Services API.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "appCatalogListingId")]
        public string AppCatalogListingId { get; set; }
        
        /// <value>
        /// The resource version of the listing resource associated with this listing package.
        /// </value>
        [JsonProperty(PropertyName = "appCatalogListingResourceVersion")]
        public string AppCatalogListingResourceVersion { get; set; }
        
        /// <value>
        /// The ID of the image corresponding to the package.
        /// </value>
        [JsonProperty(PropertyName = "imageId")]
        public string ImageId { get; set; }
        
        [JsonProperty(PropertyName = "packageType")]
        private readonly string packageType = "IMAGE";
    }
}
