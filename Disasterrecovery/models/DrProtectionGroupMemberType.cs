/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DisasterrecoveryService.Models
{
  /// <summary>
  /// Enumeration of different type of members in a DR Protection Group.
    /// - COMPUTE_INSTANCE - An Oracle Cloud compute instance.
    /// - VOLUME_GROUP - An Oracle Cloud volume group.
    /// - DATABASE - An Oracle Database Cloud Service database.
    /// - AUTONOMOUS_DATABASE - An Oracle Autonomous Database.
    /// 
  /// </summary>
  public enum DrProtectionGroupMemberType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "COMPUTE_INSTANCE")]
      ComputeInstance,
      [EnumMember(Value = "VOLUME_GROUP")]
      VolumeGroup,
      [EnumMember(Value = "DATABASE")]
      Database,
      [EnumMember(Value = "AUTONOMOUS_DATABASE")]
      AutonomousDatabase
  }
}
