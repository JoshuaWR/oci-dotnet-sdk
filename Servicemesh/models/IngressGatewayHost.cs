/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ServicemeshService.Models
{
    /// <summary>
    /// Host for the ingress listener.
    /// </summary>
    public class IngressGatewayHost 
    {
        
        /// <value>
        /// A user-friendly name for the host. The name must be unique within the same ingress gateway.
        /// This name can be used in the ingress gateway route table resource to attach a route to this host.
        /// <br/>
        /// Example: MyExampleHost
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Hostnames of the host. Applicable only for HTTP and TLS_PASSTHROUGH listeners.
        /// Wildcard hostnames are supported in the prefix form.
        /// Examples of valid hostnames are \"www.example.com\", \"*.example.com\", \"*.com\".
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hostnames")]
        public System.Collections.Generic.List<string> Hostnames { get; set; }
        
        /// <value>
        /// The listeners for the ingress gateway.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Listeners is required.")]
        [JsonProperty(PropertyName = "listeners")]
        public System.Collections.Generic.List<IngressGatewayListener> Listeners { get; set; }
        
    }
}
