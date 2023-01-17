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


namespace Oci.UsageService.Models
{
    /// <summary>
    /// Provides details about product rewards and the usage amount.
    /// </summary>
    public class ProductSummary 
    {
        
        /// <value>
        /// The rate card product number.
        /// </value>
        [JsonProperty(PropertyName = "productNumber")]
        public string ProductNumber { get; set; }
        
        /// <value>
        /// The rate card product name.
        /// </value>
        [JsonProperty(PropertyName = "productName")]
        public string ProductName { get; set; }
        
        /// <value>
        /// The rate card product usage amount.
        /// </value>
        [JsonProperty(PropertyName = "usageAmount")]
        public System.Double UsageAmount { get; set; }
        
        /// <value>
        /// The earned rewards for the product.
        /// </value>
        [JsonProperty(PropertyName = "earnedRewards")]
        public System.Nullable<float> EarnedRewards { get; set; }
        
        /// <value>
        /// The boolean parameter to indicate if the product is eligible to earn rewards.
        /// </value>
        [JsonProperty(PropertyName = "isEligibleToEarnRewards")]
        public System.Nullable<bool> IsEligibleToEarnRewards { get; set; }
        
    }
}
