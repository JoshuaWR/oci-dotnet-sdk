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
  /// The lifecycle state of the target database.
    /// - CREATING - Represents that the target database is creating.
    /// - UPDATING - Represents that the target database is updating.
    /// - ACTIVE - Represents that the target database is active.
    /// - INACTIVE - Represents that the target database is inactive.
    /// - DELETING - Represents that the target database is deleting.
    /// - DELETED - Represents that the target database is deleted.
    /// - NEEDS_ATTENTION - Represents that the target database needs user attention.
    /// - FAILED - Represents that the target database is failed.
    /// 
  /// </summary>
  public enum TargetDatabaseLifecycleState {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATING")]
      Creating,
      [EnumMember(Value = "UPDATING")]
      Updating,
      [EnumMember(Value = "ACTIVE")]
      Active,
      [EnumMember(Value = "INACTIVE")]
      Inactive,
      [EnumMember(Value = "DELETING")]
      Deleting,
      [EnumMember(Value = "DELETED")]
      Deleted,
      [EnumMember(Value = "NEEDS_ATTENTION")]
      NeedsAttention,
      [EnumMember(Value = "FAILED")]
      Failed
  }
}
