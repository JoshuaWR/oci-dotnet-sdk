/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatasafeService.Models
{
  /// <summary>
  /// The current state of the audit trail.
  /// </summary>
  public enum AuditTrailLifecycleState {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "INACTIVE")]
      Inactive,
      [EnumMember(Value = "UPDATING")]
      Updating,
      [EnumMember(Value = "ACTIVE")]
      Active,
      [EnumMember(Value = "DELETING")]
      Deleting,
      [EnumMember(Value = "FAILED")]
      Failed,
      [EnumMember(Value = "NEEDS_ATTENTION")]
      NeedsAttention
  }
}
