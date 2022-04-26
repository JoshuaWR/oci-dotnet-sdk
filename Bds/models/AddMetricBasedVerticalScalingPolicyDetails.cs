/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.BdsService.Models
{
    /// <summary>
    /// Details of a metric based vertical autoscaling policy.
    /// <br/>
    /// In a metric-based autoscaling policy, an autoscaling action is triggered when a performance metric exceeds a threshold.
    /// 
    /// </summary>
    public class AddMetricBasedVerticalScalingPolicyDetails : AddAutoScalePolicyDetails
    {
        
        [JsonProperty(PropertyName = "scaleUpConfig")]
        public MetricBasedVerticalScaleUpConfig ScaleUpConfig { get; set; }
        
        [JsonProperty(PropertyName = "scaleDownConfig")]
        public MetricBasedVerticalScaleDownConfig ScaleDownConfig { get; set; }
        
        [JsonProperty(PropertyName = "policyType")]
        private readonly string policyType = "METRIC_BASED_VERTICAL_SCALING_POLICY";
    }
}
