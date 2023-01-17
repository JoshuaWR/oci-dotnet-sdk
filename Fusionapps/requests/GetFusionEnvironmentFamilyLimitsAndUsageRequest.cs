/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.FusionappsService.Models;

namespace Oci.FusionappsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/fusionapps/GetFusionEnvironmentFamilyLimitsAndUsage.cs.html">here</a> to see an example of how to use GetFusionEnvironmentFamilyLimitsAndUsage request.
    /// </example>
    public class GetFusionEnvironmentFamilyLimitsAndUsageRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The unique identifier (OCID) of the FusionEnvironmentFamily.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FusionEnvironmentFamilyId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "fusionEnvironmentFamilyId")]
        public string FusionEnvironmentFamilyId { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
