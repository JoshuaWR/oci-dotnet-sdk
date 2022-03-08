/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.CloudguardService.Models
{
  /// <summary>
  /// Indicates the classification status of the Sighitng
  /// </summary>
  public enum ClassificationStatus {
      [EnumMember(Value = "FALSE_POSITIVE")]
      FalsePositive,
      [EnumMember(Value = "FALSE_NEGATIVE")]
      FalseNegative,
      [EnumMember(Value = "TRUE_POSITIVE")]
      TruePositive,
      [EnumMember(Value = "TRUE_NEGATIVE")]
      TrueNegative,
      [EnumMember(Value = "NOT_CLASSIFIED")]
      NotClassified
  }
}