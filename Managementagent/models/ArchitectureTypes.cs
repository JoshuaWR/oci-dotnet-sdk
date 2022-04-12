/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.ManagementagentService.Models
{
  /// <summary>
  /// Supported architecture types.
    /// X86_64 - Package architecture is x86-64
    /// SPARC - Package architecture is SPARC
    /// 
  /// </summary>
  public enum ArchitectureTypes {
      [EnumMember(Value = "X86_64")]
      X8664,
      [EnumMember(Value = "SPARC")]
      Sparc
  }
}