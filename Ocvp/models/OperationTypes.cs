/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.OcvpService.Models
{
  /// <summary>
  /// Possible asynchronous operation types.
  /// </summary>
  public enum OperationTypes {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_SDDC")]
      CreateSddc,
      [EnumMember(Value = "DELETE_SDDC")]
      DeleteSddc,
      [EnumMember(Value = "CREATE_CLUSTER")]
      CreateCluster,
      [EnumMember(Value = "DELETE_CLUSTER")]
      DeleteCluster,
      [EnumMember(Value = "CREATE_ESXI_HOST")]
      CreateEsxiHost,
      [EnumMember(Value = "DELETE_ESXI_HOST")]
      DeleteEsxiHost,
      [EnumMember(Value = "UPGRADE_HCX")]
      UpgradeHcx,
      [EnumMember(Value = "DOWNGRADE_HCX")]
      DowngradeHcx,
      [EnumMember(Value = "CANCEL_DOWNGRADE_HCX")]
      CancelDowngradeHcx,
      [EnumMember(Value = "REFRESH_HCX_LICENSE_STATUS")]
      RefreshHcxLicenseStatus,
      [EnumMember(Value = "SWAP_BILLING")]
      SwapBilling,
      [EnumMember(Value = "REPLACE_HOST")]
      ReplaceHost,
      [EnumMember(Value = "IN_PLACE_UPGRADE")]
      InPlaceUpgrade,
      [EnumMember(Value = "CREATE_DATASTORE")]
      CreateDatastore,
      [EnumMember(Value = "UPDATE_DATASTORE")]
      UpdateDatastore,
      [EnumMember(Value = "ADD_BLOCK_VOLUME_TO_DATASTORE")]
      AddBlockVolumeToDatastore,
      [EnumMember(Value = "DELETE_DATASTORE")]
      DeleteDatastore,
      [EnumMember(Value = "CREATE_DATASTORE_CLUSTER")]
      CreateDatastoreCluster,
      [EnumMember(Value = "UPDATE_DATASTORE_CLUSTER")]
      UpdateDatastoreCluster,
      [EnumMember(Value = "ATTACH_DATASTORE_CLUSTER_TO_ESXI_HOST")]
      AttachDatastoreClusterToEsxiHost,
      [EnumMember(Value = "ATTACH_DATASTORE_CLUSTER_TO_CLUSTER")]
      AttachDatastoreClusterToCluster,
      [EnumMember(Value = "DETACH_DATASTORE_CLUSTER_FROM_ESXI_HOST")]
      DetachDatastoreClusterFromEsxiHost,
      [EnumMember(Value = "DETACH_DATASTORE_CLUSTER_FROM_CLUSTER")]
      DetachDatastoreClusterFromCluster,
      [EnumMember(Value = "DELETE_DATASTORE_CLUSTER")]
      DeleteDatastoreCluster,
      [EnumMember(Value = "ADD_DATASTORE_TO_DATASTORE_CLUSTER")]
      AddDatastoreToDatastoreCluster,
      [EnumMember(Value = "REMOVE_DATASTORE_FROM_DATASTORE_CLUSTER")]
      RemoveDatastoreFromDatastoreCluster
  }
}
