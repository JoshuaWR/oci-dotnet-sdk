/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatabasemigrationService.Models
{
  /// <summary>
  /// Size of Oracle database blocks in KB.
  /// </summary>
  public enum DataPumpTablespaceBlockSizesInKb {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "SIZE_2K")]
      Size2K,
      [EnumMember(Value = "SIZE_8K")]
      Size8K,
      [EnumMember(Value = "SIZE_16K")]
      Size16K,
      [EnumMember(Value = "SIZE_32K")]
      Size32K
  }
}
