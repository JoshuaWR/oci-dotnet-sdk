/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatacatalogService.Models;

namespace Oci.DatacatalogService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datacatalog/GetJobExecution.cs.html">here</a> to see an example of how to use GetJobExecution request.
    /// </example>
    public class GetJobExecutionRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique catalog identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CatalogId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "catalogId")]
        public string CatalogId { get; set; }
        
        /// <value>
        /// Unique job key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JobKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "jobKey")]
        public string JobKey { get; set; }
        
        /// <value>
        /// The key of the job execution.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JobExecutionKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "jobExecutionKey")]
        public string JobExecutionKey { get; set; }
        
        ///
        /// <value>
        /// Specifies the fields to return in a job execution response.
        /// 
        /// </value>
        ///
        public enum FieldsEnum {
            [EnumMember(Value = "key")]
            Key,
            [EnumMember(Value = "jobKey")]
            JobKey,
            [EnumMember(Value = "jobType")]
            JobType,
            [EnumMember(Value = "subType")]
            SubType,
            [EnumMember(Value = "parentKey")]
            ParentKey,
            [EnumMember(Value = "scheduleInstanceKey")]
            ScheduleInstanceKey,
            [EnumMember(Value = "lifecycleState")]
            LifecycleState,
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "timeStarted")]
            TimeStarted,
            [EnumMember(Value = "timeEnded")]
            TimeEnded,
            [EnumMember(Value = "errorCode")]
            ErrorCode,
            [EnumMember(Value = "errorMessage")]
            ErrorMessage,
            [EnumMember(Value = "processKey")]
            ProcessKey,
            [EnumMember(Value = "externalUrl")]
            ExternalUrl,
            [EnumMember(Value = "eventKey")]
            EventKey,
            [EnumMember(Value = "dataEntityKey")]
            DataEntityKey,
            [EnumMember(Value = "createdById")]
            CreatedById,
            [EnumMember(Value = "updatedById")]
            UpdatedById,
            [EnumMember(Value = "properties")]
            Properties,
            [EnumMember(Value = "uri")]
            Uri
        };

        /// <value>
        /// Specifies the fields to return in a job execution response.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "fields", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<FieldsEnum> Fields { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
