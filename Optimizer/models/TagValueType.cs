/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.OptimizerService.Models
{
  /// <summary>
  /// Specifies which tag value types in the `tagValues` field result in overrides of the recommendation criteria. Allowed values are `ANY` and `VALUE`.
    /// <br/>
    /// When the `tagValueType` field value is `ANY`, the `tagValues` field should be empty, which enforces overrides to the recommendation for resources with any tag values attached to them.
    /// When the `tagValueType` field value is `VALUE`, the `tagValues` field must include a specific value or list of values. Overrides to the recommendation criteria only occur for resources that match the values in the `tagKey` and the `tagValues` fields.
    /// <br/>
    /// For example, if the `tagKey` value is `B`, the `tagValueType` value is `ANY`, and the `tagValues` field is empty, overrides to the recommendation criteria occur for any resources that have the tag key B.
    /// If the `tagKey` value is `B`, the `tagValueType` value is `VALUE`, and the `tagValues` value is `s1`, overrides to the recommendation criteria only occur for resources that have the tag key B with the associated tag value s1.
    /// 
  /// </summary>
  public enum TagValueType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "VALUE")]
      Value,
      [EnumMember(Value = "ANY")]
      Any
  }
}
