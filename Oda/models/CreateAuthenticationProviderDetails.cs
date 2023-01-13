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
    /// Properties required to create a new Authentication Provider.
    /// </summary>
    public class CreateAuthenticationProviderDetails 
    {
        
        /// <value>
        /// The grant type for the Authentication Provider.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GrantType is required.")]
        [JsonProperty(PropertyName = "grantType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AuthenticationGrantType> GrantType { get; set; }
        
        /// <value>
        /// Which type of Identity Provider (IDP) you are using.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IdentityProvider is required.")]
        [JsonProperty(PropertyName = "identityProvider")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AuthenticationIdentityProvider> IdentityProvider { get; set; }
        
        /// <value>
        /// A name to identify the Authentication Provider.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The IDPs URL for requesting access tokens.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TokenEndpointUrl is required.")]
        [JsonProperty(PropertyName = "tokenEndpointUrl")]
        public string TokenEndpointUrl { get; set; }
        
        /// <value>
        /// The IDPs URL for the page that users authenticate with by entering the user name and password.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AuthorizationEndpointUrl is required.")]
        [JsonProperty(PropertyName = "authorizationEndpointUrl")]
        public string AuthorizationEndpointUrl { get; set; }
        
        /// <value>
        /// A shortened version of the authorization URL, which you can get from a URL shortener service (one that allows
        /// you to send query parameters).  You might need this because the generated authorization-code-request URL
        /// could be too long for SMS and older smart phones.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shortAuthorizationCodeRequestUrl")]
        public string ShortAuthorizationCodeRequestUrl { get; set; }
        
        /// <value>
        /// If you want to revoke all the refresh tokens and access tokens of the logged-in user from a dialog flow, then 
        /// you need the IDP's revoke refresh token URL. If you provide this URL, then you can use the System.OAuth2ResetTokens 
        /// component to revoke the user's tokens for this service.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "revokeTokenEndpointUrl")]
        public string RevokeTokenEndpointUrl { get; set; }
        
        /// <value>
        /// The client ID for the IDP application (OAuth Client) that was registered as described in Identity Provider Registration. 
        /// With Microsoft identity platform, use the application ID.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClientId is required.")]
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }
        
        /// <value>
        /// The client secret for the IDP application (OAuth Client) that was registered as described in Identity Provider 
        /// Registration. With Microsoft identity platform, use the application secret.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClientSecret is required.")]
        [JsonProperty(PropertyName = "clientSecret")]
        public string ClientSecret { get; set; }
        
        /// <value>
        /// A space-separated list of the scopes that must be included when Digital Assistant requests an access token from 
        /// the provider. Include all the scopes that are required to access the resources. If refresh tokens are enabled, 
        /// include the scope that\u2019s necessary to get the refresh token (typically offline_access).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Scopes is required.")]
        [JsonProperty(PropertyName = "scopes")]
        public string Scopes { get; set; }
        
        /// <value>
        /// The access-token profile claim to use to identify the user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubjectClaim is required.")]
        [JsonProperty(PropertyName = "subjectClaim")]
        public string SubjectClaim { get; set; }
        
        /// <value>
        /// The number of days to keep the refresh token in the Digital Assistant cache.
        /// </value>
        [JsonProperty(PropertyName = "refreshTokenRetentionPeriodInDays")]
        public System.Nullable<int> RefreshTokenRetentionPeriodInDays { get; set; }
        
        /// <value>
        /// The OAuth Redirect URL.
        /// </value>
        [JsonProperty(PropertyName = "redirectUrl")]
        public string RedirectUrl { get; set; }
        
        /// <value>
        /// Whether this Authentication Provider is visible in the ODA UI.
        /// </value>
        [JsonProperty(PropertyName = "isVisible")]
        public System.Nullable<bool> IsVisible { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type, or scope.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
