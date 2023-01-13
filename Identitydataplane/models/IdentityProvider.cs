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


namespace Oci.IdentitydataplaneService.Models
{
    
    public class IdentityProvider 
    {
        
        /// <value>
        /// The id of the provider.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name of the provider.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The name of the tenant.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenantName is required.")]
        [JsonProperty(PropertyName = "tenantName")]
        public string TenantName { get; set; }
        
        /// <value>
        /// The id of the tenant.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenantId is required.")]
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }
        
        /// <value>
        /// The SAML endpoint where user will be redirected.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RedirectUri is required.")]
        [JsonProperty(PropertyName = "redirectUri")]
        public string RedirectUri { get; set; }
        
        /// <value>
        /// The signing certificate of the provider.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SigningCertificate is required.")]
        [JsonProperty(PropertyName = "signingCertificate")]
        public string SigningCertificate { get; set; }
                ///
        /// <value>
        /// The type of the provider.
        /// </value>
        ///
        public enum ProtocolEnum {
            [EnumMember(Value = "SAML2")]
            Saml2
        };

        /// <value>
        /// The type of the provider.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Protocol is required.")]
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProtocolEnum> Protocol { get; set; }
        
        /// <value>
        /// The id of the service provider entity.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceProviderEntityId is required.")]
        [JsonProperty(PropertyName = "serviceProviderEntityId")]
        public string ServiceProviderEntityId { get; set; }
        
        /// <value>
        /// Whether to force authentication.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ForceAuthentication is required.")]
        [JsonProperty(PropertyName = "forceAuthentication")]
        public System.Nullable<bool> ForceAuthentication { get; set; }
        
        /// <value>
        /// Authentication context class refs.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AuthnContextClassRefs is required.")]
        [JsonProperty(PropertyName = "authnContextClassRefs")]
        public System.Collections.Generic.List<string> AuthnContextClassRefs { get; set; }
        
    }
}
