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


namespace Oci.ObjectstorageService.Models
{
    /// <summary>
    /// The details to create or update a retention rule.
    /// </summary>
    public class RetentionRuleDetails 
    {
        
        /// <value>
        /// A user-specified name for the retention rule. Names can be helpful in identifying retention rules.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        [JsonProperty(PropertyName = "duration")]
        public Duration Duration { get; set; }
        
        /// <value>
        /// The date and time as per [RFC 3339](https://tools.ietf.org/html/rfc3339) after which this rule is locked
        /// and can only be deleted by deleting the bucket. Once a rule is locked, only increases in the duration are
        /// allowed and no other properties can be changed. This property cannot be updated for rules that are in a
        /// locked state. Specifying it when a duration is not specified is considered an error.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeRuleLocked")]
        public System.Nullable<System.DateTime> TimeRuleLocked { get; set; }
        
    }
}
