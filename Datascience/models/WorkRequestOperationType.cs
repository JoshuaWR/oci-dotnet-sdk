/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatascienceService.Models
{
  /// <summary>
  /// The types of work request operations.
  /// </summary>
  public enum WorkRequestOperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "NOTEBOOK_SESSION_CREATE")]
      NotebookSessionCreate,
      [EnumMember(Value = "NOTEBOOK_SESSION_DELETE")]
      NotebookSessionDelete,
      [EnumMember(Value = "NOTEBOOK_SESSION_ACTIVATE")]
      NotebookSessionActivate,
      [EnumMember(Value = "NOTEBOOK_SESSION_DEACTIVATE")]
      NotebookSessionDeactivate,
      [EnumMember(Value = "MODELVERSIONSET_DELETE")]
      ModelversionsetDelete,
      [EnumMember(Value = "EXPORT_MODEL_ARTIFACT")]
      ExportModelArtifact,
      [EnumMember(Value = "IMPORT_MODEL_ARTIFACT")]
      ImportModelArtifact,
      [EnumMember(Value = "MODEL_DEPLOYMENT_CREATE")]
      ModelDeploymentCreate,
      [EnumMember(Value = "MODEL_DEPLOYMENT_DELETE")]
      ModelDeploymentDelete,
      [EnumMember(Value = "MODEL_DEPLOYMENT_ACTIVATE")]
      ModelDeploymentActivate,
      [EnumMember(Value = "MODEL_DEPLOYMENT_DEACTIVATE")]
      ModelDeploymentDeactivate,
      [EnumMember(Value = "MODEL_DEPLOYMENT_UPDATE")]
      ModelDeploymentUpdate,
      [EnumMember(Value = "PROJECT_DELETE")]
      ProjectDelete,
      [EnumMember(Value = "WORKREQUEST_CANCEL")]
      WorkrequestCancel,
      [EnumMember(Value = "JOB_DELETE")]
      JobDelete,
      [EnumMember(Value = "PIPELINE_CREATE")]
      PipelineCreate,
      [EnumMember(Value = "PIPELINE_DELETE")]
      PipelineDelete,
      [EnumMember(Value = "PIPELINE_RUN_CREATE")]
      PipelineRunCreate,
      [EnumMember(Value = "PIPELINE_RUN_CANCEL")]
      PipelineRunCancel,
      [EnumMember(Value = "PIPELINE_RUN_DELETE")]
      PipelineRunDelete,
      [EnumMember(Value = "PRIVATE_ENDPOINT_CREATE")]
      PrivateEndpointCreate,
      [EnumMember(Value = "PRIVATE_ENDPOINT_DELETE")]
      PrivateEndpointDelete,
      [EnumMember(Value = "PRIVATE_ENDPOINT_MOVE")]
      PrivateEndpointMove,
      [EnumMember(Value = "PRIVATE_ENDPOINT_UPDATE")]
      PrivateEndpointUpdate,
      [EnumMember(Value = "RESTORE_ARCHIVED_MODEL")]
      RestoreArchivedModel
  }
}
