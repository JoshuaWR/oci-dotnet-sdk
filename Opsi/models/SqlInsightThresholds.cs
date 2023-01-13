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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Inventory details.
    /// </summary>
    public class SqlInsightThresholds 
    {
        
        /// <value>
        /// Degradation Percent Threshold is used to derive degrading SQLs.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DegradationInPct is required.")]
        [JsonProperty(PropertyName = "degradationInPct")]
        public System.Nullable<int> DegradationInPct { get; set; }
        
        /// <value>
        /// Variability Percent Threshold is used to derive variant SQLs.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Variability is required.")]
        [JsonProperty(PropertyName = "variability")]
        public System.Nullable<float> Variability { get; set; }
        
        /// <value>
        /// Inefficiency Percent Threshold is used to derive inefficient SQLs.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InefficiencyInPct is required.")]
        [JsonProperty(PropertyName = "inefficiencyInPct")]
        public System.Nullable<int> InefficiencyInPct { get; set; }
        
        /// <value>
        /// PctIncreaseInIO is used for deriving insights for SQLs which are degrading or
        /// variant or inefficient. And these SQLs should also have increasing change in IO Time
        /// beyond threshold. Insights are derived using linear regression.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IncreaseInIOInPct is required.")]
        [JsonProperty(PropertyName = "increaseInIOInPct")]
        public System.Nullable<int> IncreaseInIOInPct { get; set; }
        
        /// <value>
        /// PctIncreaseInCPU is used for deriving insights for SQLs which are degrading or
        /// variant or inefficient. And these SQLs should also have increasing change in CPU Time
        /// beyond threshold. Insights are derived using linear regression.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IncreaseInCPUInPct is required.")]
        [JsonProperty(PropertyName = "increaseInCPUInPct")]
        public System.Nullable<int> IncreaseInCPUInPct { get; set; }
        
        /// <value>
        /// PctIncreaseInIO is used for deriving insights for SQLs which are degrading or
        /// variant or inefficient. And these SQLs should also have increasing change in
        /// Other Wait Time beyond threshold. Insights are derived using linear regression.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IncreaseInInefficientWaitInPct is required.")]
        [JsonProperty(PropertyName = "increaseInInefficientWaitInPct")]
        public System.Nullable<int> IncreaseInInefficientWaitInPct { get; set; }
        
        /// <value>
        /// Improved Percent Threshold is used to derive improving SQLs.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImprovedInPct is required.")]
        [JsonProperty(PropertyName = "improvedInPct")]
        public System.Nullable<int> ImprovedInPct { get; set; }
        
    }
}
