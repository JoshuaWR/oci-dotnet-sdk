/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// The scaling configuration for the custom metric expression rule.
    /// 
    /// </summary>
    public class CustomExpressionQueryScalingConfiguration : ScalingConfiguration
    {
        
        /// <value>
        /// The Monitoring Query Language (MQL) expression to evaluate for the alarm. The Alarms feature of
        /// the Monitoring service interprets results for each returned time series as Boolean values,
        /// where zero represents false and a non-zero value represents true. A true value means that the trigger
        /// rule condition has been met. The query must specify a metric, statistic, interval, and trigger
        /// rule (threshold or absence). Supported values for interval: `1m`-`60m` (also `1h`). You can optionally
        /// specify dimensions and grouping functions. Supported grouping functions: `grouping()`, `groupBy()`.
        /// <br/>
        /// Example of threshold alarm:
        /// <br/>
        ///   -----
        /// <br/>
        ///     CPUUtilization[1m]{resourceId = \"MODEL_DEPLOYMENT_OCID\"}.grouping().mean() < 25
        ///     CPUUtilization[1m]{resourceId = \"MODEL_DEPLOYMENT_OCID\"}.grouping().mean() > 75
        /// <br/>
        ///   -----
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Query is required.")]
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }
        
        [JsonProperty(PropertyName = "scalingConfigurationType")]
        private readonly string scalingConfigurationType = "QUERY";
    }
}