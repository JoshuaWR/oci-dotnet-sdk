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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// An object that represents one or multiple Oracle services that you can enable for a
    /// {@link ServiceGateway}. In the User Guide topic
    /// [Access to Oracle Services: Service Gateway](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/servicegateway.htm), the
    /// term *service CIDR label* is used to refer to the string that represents the regional public
    /// IP address ranges of the Oracle service or services covered by a given `Service` object. That
    /// unique string is the value of the `Service` object's `cidrBlock` attribute.
    /// 
    /// </summary>
    public class Service 
    {
        
        /// <value>
        /// A string that represents the regional public IP address ranges for the Oracle service or
        /// services covered by this `Service` object. Also known as the `Service` object's *service
        /// CIDR label*.
        /// <br/>
        /// When you set up a route rule to route traffic to the service gateway, use this value as the
        /// rule's destination. See {@link RouteTable}. Also, when you set up
        /// a security list rule to cover traffic with the service gateway, use the `cidrBlock` value
        /// as the rule's destination (for an egress rule) or the source (for an ingress rule).
        /// See {@link SecurityList}.
        /// <br/>
        /// Example: oci-phx-objectstorage
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CidrBlock is required.")]
        [JsonProperty(PropertyName = "cidrBlock")]
        public string CidrBlock { get; set; }
        
        /// <value>
        /// Description of the Oracle service or services covered by this `Service` object.
        /// <br/>
        /// Example: OCI PHX Object Storage
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The `Service` object's [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Name of the `Service` object. This name can change and is not guaranteed to be unique.
        /// <br/>
        /// Example: OCI PHX Object Storage
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
    }
}
