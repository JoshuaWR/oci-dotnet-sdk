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


namespace Oci.OspgatewayService.Models
{
    /// <summary>
    /// Product items of the invoice
    /// </summary>
    public class InvoiceLineSummary 
    {
        
        /// <value>
        /// Product of the item
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Product is required.")]
        [JsonProperty(PropertyName = "product")]
        public string Product { get; set; }
        
        /// <value>
        /// Product of the item
        /// </value>
        [JsonProperty(PropertyName = "orderNo")]
        public string OrderNo { get; set; }
        
        /// <value>
        /// Part number
        /// </value>
        [JsonProperty(PropertyName = "partNumber")]
        public string PartNumber { get; set; }
        
        /// <value>
        /// Start date
        /// </value>
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// End date
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
        /// <value>
        /// Quantity of the ordered product
        /// </value>
        [JsonProperty(PropertyName = "quantity")]
        public System.Nullable<decimal> Quantity { get; set; }
        
        /// <value>
        /// Unit price of the ordered product
        /// </value>
        [JsonProperty(PropertyName = "netUnitPrice")]
        public System.Nullable<decimal> NetUnitPrice { get; set; }
        
        /// <value>
        /// Total price of the ordered product (Net unit price x quantity)
        /// </value>
        [JsonProperty(PropertyName = "totalPrice")]
        public System.Nullable<decimal> TotalPrice { get; set; }
        
        [JsonProperty(PropertyName = "currency")]
        public Currency Currency { get; set; }
        
    }
}
