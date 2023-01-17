/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// The configuration details for a load balancer backend set.
    /// For more information on backend set configuration, see
    /// [Managing Backend Sets](https://docs.cloud.oracle.com/Content/Balance/Tasks/managingbackendsets.htm).
    /// <br/>
    /// **Note:** The `sessionPersistenceConfiguration` (application cookie stickiness) and `lbCookieSessionPersistenceConfiguration`
    /// (LB cookie stickiness) attributes are mutually exclusive. To avoid returning an error, configure only one of these two
    /// attributes per backend set.
    /// 
    /// </summary>
    public class BackendSetDetails 
    {
        
        /// <value>
        /// The load balancer policy for the backend set. To get a list of available policies, use the
        /// {@link #listPolicies(ListPoliciesRequest) listPolicies} operation.
        /// <br/>
        /// Example: LEAST_CONNECTIONS
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Policy is required.")]
        [JsonProperty(PropertyName = "policy")]
        public string Policy { get; set; }
        
        [JsonProperty(PropertyName = "backends")]
        public System.Collections.Generic.List<BackendDetails> Backends { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HealthChecker is required.")]
        [JsonProperty(PropertyName = "healthChecker")]
        public HealthCheckerDetails HealthChecker { get; set; }
        
        [JsonProperty(PropertyName = "sslConfiguration")]
        public SSLConfigurationDetails SslConfiguration { get; set; }
        
        [JsonProperty(PropertyName = "sessionPersistenceConfiguration")]
        public SessionPersistenceConfigurationDetails SessionPersistenceConfiguration { get; set; }
        
        [JsonProperty(PropertyName = "lbCookieSessionPersistenceConfiguration")]
        public LBCookieSessionPersistenceConfigurationDetails LbCookieSessionPersistenceConfiguration { get; set; }
        
    }
}
