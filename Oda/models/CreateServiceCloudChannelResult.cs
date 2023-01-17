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


namespace Oci.OdaService.Models
{
    /// <summary>
    /// The configuration for a Service Cloud agent channel.
    /// </summary>
    public class CreateServiceCloudChannelResult : CreateChannelResult
    {
        
        /// <value>
        /// The domain name.
        ///   
        /// If you have access to Oracle B2C Service, you can derive this value from the URL that you use to launch the 
        /// Agent Browser User Interface. For example, if the URL is sitename.exampledomain.com, then the host name prefix 
        /// is sitename and the domain name is exampledomain.com.
        ///   
        /// If the channel is connecting to Oracle B2C Service version 19A or later, and you have multiple interfaces, 
        /// then you must include the interface ID in the host (site) name . For example, for the interface that has an ID of 2, you would use something like sitename-2.exampledomain.com.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DomainName is required.")]
        [JsonProperty(PropertyName = "domainName")]
        public string DomainName { get; set; }
        
        /// <value>
        /// The host prefix.
        ///   
        /// If you have access to Oracle B2C Service, you can derive this value from the URL that you use to launch the 
        /// Agent Browser User Interface. For example, if the URL is sitename.exampledomain.com, then the host name prefix 
        /// is sitename and the domain name is exampledomain.com.
        ///   
        /// If the channel is connecting to Oracle B2C Service version 19A or later, and you have multiple interfaces, 
        /// then you must include the interface ID in the host (site) name . For example, for the interface that has an ID of 2, you would use something like sitename-2.exampledomain.com.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HostNamePrefix is required.")]
        [JsonProperty(PropertyName = "hostNamePrefix")]
        public string HostNamePrefix { get; set; }
        
        /// <value>
        /// The user name for an Oracle B2C Service staff member who has the necessary profile permissions.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UserName is required.")]
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }
        
        /// <value>
        /// The type of Service Cloud client.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClientType is required.")]
        [JsonProperty(PropertyName = "clientType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ServiceCloudClientType> ClientType { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "SERVICECLOUD";
    }
}
