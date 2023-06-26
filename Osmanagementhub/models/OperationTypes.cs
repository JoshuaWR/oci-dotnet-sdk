/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.OsmanagementhubService.Models
{
  /// <summary>
  /// Possible scheduled job operation types.
  /// </summary>
  public enum OperationTypes {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "INSTALL_PACKAGES")]
      InstallPackages,
      [EnumMember(Value = "UPDATE_PACKAGES")]
      UpdatePackages,
      [EnumMember(Value = "REMOVE_PACKAGES")]
      RemovePackages,
      [EnumMember(Value = "UPDATE_ALL")]
      UpdateAll,
      [EnumMember(Value = "UPDATE_SECURITY")]
      UpdateSecurity,
      [EnumMember(Value = "UPDATE_BUGFIX")]
      UpdateBugfix,
      [EnumMember(Value = "UPDATE_ENHANCEMENT")]
      UpdateEnhancement,
      [EnumMember(Value = "UPDATE_OTHER")]
      UpdateOther,
      [EnumMember(Value = "UPDATE_KSPLICE_USERSPACE")]
      UpdateKspliceUserspace,
      [EnumMember(Value = "UPDATE_KSPLICE_KERNEL")]
      UpdateKspliceKernel,
      [EnumMember(Value = "MANAGE_MODULE_STREAMS")]
      ManageModuleStreams,
      [EnumMember(Value = "SWITCH_MODULE_STREAM")]
      SwitchModuleStream,
      [EnumMember(Value = "ATTACH_SOFTWARE_SOURCES")]
      AttachSoftwareSources,
      [EnumMember(Value = "DETACH_SOFTWARE_SOURCES")]
      DetachSoftwareSources,
      [EnumMember(Value = "SYNC_MANAGEMENT_STATION_MIRROR")]
      SyncManagementStationMirror,
      [EnumMember(Value = "PROMOTE_LIFECYCLE")]
      PromoteLifecycle
  }
}
