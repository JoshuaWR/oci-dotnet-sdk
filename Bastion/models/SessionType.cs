/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.BastionService.Models
{
  /// <summary>
  /// Possible session types.
  /// </summary>
  public enum SessionType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "MANAGED_SSH")]
      ManagedSsh,
      [EnumMember(Value = "PORT_FORWARDING")]
      PortForwarding,
      [EnumMember(Value = "DYNAMIC_PORT_FORWARDING")]
      DynamicPortForwarding
  }
}
