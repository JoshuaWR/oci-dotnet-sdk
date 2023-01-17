/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.WaasService.Models
{
  /// <summary>
  /// An enum value indicating the operation being performed by the work request.
  /// </summary>
  public enum WorkRequestOperationTypes {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_WAAS_POLICY")]
      CreateWaasPolicy,
      [EnumMember(Value = "UPDATE_WAAS_POLICY")]
      UpdateWaasPolicy,
      [EnumMember(Value = "DELETE_WAAS_POLICY")]
      DeleteWaasPolicy,
      [EnumMember(Value = "CREATE_HTTP_REDIRECT")]
      CreateHttpRedirect,
      [EnumMember(Value = "UPDATE_HTTP_REDIRECT")]
      UpdateHttpRedirect,
      [EnumMember(Value = "DELETE_HTTP_REDIRECT")]
      DeleteHttpRedirect,
      [EnumMember(Value = "PURGE_WAAS_POLICY_CACHE")]
      PurgeWaasPolicyCache,
      [EnumMember(Value = "CREATE_CUSTOM_PROTECTION_RULE")]
      CreateCustomProtectionRule,
      [EnumMember(Value = "UPDATE_CUSTOM_PROTECTION_RULE")]
      UpdateCustomProtectionRule,
      [EnumMember(Value = "DELETE_CUSTOM_PROTECTION_RULE")]
      DeleteCustomProtectionRule
  }
}
