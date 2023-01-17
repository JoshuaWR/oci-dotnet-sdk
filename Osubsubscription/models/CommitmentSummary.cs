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


namespace Oci.OsubsubscriptionService.Models
{
    /// <summary>
    /// Subscribed Service commitment summary
    /// 
    /// </summary>
    public class CommitmentSummary 
    {
        
        /// <value>
        /// SPM internal Commitment ID
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Commitment start date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// Commitment end date
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
        /// <value>
        /// Commitment quantity
        /// 
        /// </value>
        [JsonProperty(PropertyName = "quantity")]
        public string Quantity { get; set; }
        
        /// <value>
        /// Commitment used amount
        /// 
        /// </value>
        [JsonProperty(PropertyName = "usedAmount")]
        public string UsedAmount { get; set; }
        
        /// <value>
        /// Commitment available amount
        /// 
        /// </value>
        [JsonProperty(PropertyName = "availableAmount")]
        public string AvailableAmount { get; set; }
        
        /// <value>
        /// Funded Allocation line value
        /// Example: 12000.00
        /// </value>
        [JsonProperty(PropertyName = "fundedAllocationValue")]
        public string FundedAllocationValue { get; set; }
        
    }
}
