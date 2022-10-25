/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DisasterrecoveryService.Models
{
  /// <summary>
  /// Possible lifecycle states of a DR Plan Execution.
    /// - ACCEPTED - DR Plan Execution has been accepted.
    /// - IN_PROGRESS - DR Plan Execution is in progress.
    /// - WAITING - DR Plan Execution is waiting for user action.
    /// - CANCELING - DR Plan Execution is being canceled.
    /// - CANCELED - DR Plan Execution has been canceled.
    /// - SUCCEEDED - DR Plan Execution has succeeded.
    /// - FAILED - DR Plan Execution has failed.
    /// - DELETING - DR Plan Execution is being deleted.
    /// - DELETED - DR Plan Execution has been deleted.
    /// - PAUSING - DR Plan Execution is being paused.
    /// - PAUSED - DR Plan Execution has been paused.
    /// - RESUMING - DR Plan Execution is resuming.
    /// 
  /// </summary>
  public enum DrPlanExecutionLifecycleState {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "ACCEPTED")]
      Accepted,
      [EnumMember(Value = "IN_PROGRESS")]
      InProgress,
      [EnumMember(Value = "WAITING")]
      Waiting,
      [EnumMember(Value = "CANCELING")]
      Canceling,
      [EnumMember(Value = "CANCELED")]
      Canceled,
      [EnumMember(Value = "SUCCEEDED")]
      Succeeded,
      [EnumMember(Value = "FAILED")]
      Failed,
      [EnumMember(Value = "DELETING")]
      Deleting,
      [EnumMember(Value = "DELETED")]
      Deleted,
      [EnumMember(Value = "PAUSING")]
      Pausing,
      [EnumMember(Value = "PAUSED")]
      Paused,
      [EnumMember(Value = "RESUMING")]
      Resuming
  }
}
