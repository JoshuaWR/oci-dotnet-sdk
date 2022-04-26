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
using Newtonsoft.Json.Linq;

namespace Oci.BdsService.Models
{
    /// <summary>
    /// Details of an autoscale policy.
    /// <br/>
    /// You can create following types of autoscaling policies:
    /// <br/>
    /// - **MetricBasedVerticalScalingPolicy:** Vertical autoscaling action is triggered when a performance metric exceeds a threshold
    /// - **MetricBasedHorizontalScalingPolicy:** Horizontal autoscaling action is triggered when a performance metric exceeds a threshold
    /// - **ScheduleBasedVerticalScalingPolicy:** Vertical autoscaling action is triggered at the specific times that you schedule.
    /// - **ScheduleBasedHorizontalScalingPolicy:** Horizontal autoscaling action is triggered at the specific times that you schedule.
    /// 
    /// </summary>
    [JsonConverter(typeof(AutoScalePolicyDetailsModelConverter))]
    public class AutoScalePolicyDetails 
    {
                ///
        /// <value>
        /// Type of autoscaling policy.
        /// </value>
        ///
        public enum PolicyTypeEnum {
            [EnumMember(Value = "METRIC_BASED_VERTICAL_SCALING_POLICY")]
            MetricBasedVerticalScalingPolicy,
            [EnumMember(Value = "METRIC_BASED_HORIZONTAL_SCALING_POLICY")]
            MetricBasedHorizontalScalingPolicy,
            [EnumMember(Value = "SCHEDULE_BASED_VERTICAL_SCALING_POLICY")]
            ScheduleBasedVerticalScalingPolicy,
            [EnumMember(Value = "SCHEDULE_BASED_HORIZONTAL_SCALING_POLICY")]
            ScheduleBasedHorizontalScalingPolicy
        };

                ///
        /// <value>
        /// The type of autoscaling trigger.
        /// </value>
        ///
        public enum TriggerTypeEnum {
            [EnumMember(Value = "METRIC_BASED")]
            MetricBased,
            [EnumMember(Value = "SCHEDULE_BASED")]
            ScheduleBased
        };

        /// <value>
        /// The type of autoscaling trigger.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TriggerType is required.")]
        [JsonProperty(PropertyName = "triggerType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TriggerTypeEnum> TriggerType { get; set; }
                ///
        /// <value>
        /// The type of autoscaling action to take.
        /// </value>
        ///
        public enum ActionTypeEnum {
            [EnumMember(Value = "VERTICAL_SCALING")]
            VerticalScaling,
            [EnumMember(Value = "HORIZONTAL_SCALING")]
            HorizontalScaling
        };

        /// <value>
        /// The type of autoscaling action to take.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActionType is required.")]
        [JsonProperty(PropertyName = "actionType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ActionTypeEnum> ActionType { get; set; }
        
    }

    public class AutoScalePolicyDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(AutoScalePolicyDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(AutoScalePolicyDetails);
            var discriminator = jsonObject["policyType"].Value<string>();
            switch (discriminator)
            {
                case "METRIC_BASED_VERTICAL_SCALING_POLICY":
                    obj = new MetricBasedVerticalScalingPolicyDetails();
                    break;
                case "SCHEDULE_BASED_VERTICAL_SCALING_POLICY":
                    obj = new ScheduleBasedVerticalScalingPolicyDetails();
                    break;
                case "SCHEDULE_BASED_HORIZONTAL_SCALING_POLICY":
                    obj = new ScheduleBasedHorizontalScalingPolicyDetails();
                    break;
                case "METRIC_BASED_HORIZONTAL_SCALING_POLICY":
                    obj = new MetricBasedHorizontalScalingPolicyDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
