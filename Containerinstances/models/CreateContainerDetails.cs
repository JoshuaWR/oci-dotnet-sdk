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


namespace Oci.ContainerinstancesService.Models
{
    /// <summary>
    /// Information to create a new Container within a ContainerInstance.
    /// <br/>
    /// The Container created by this call will contain both the tags specified
    /// in this object as well as any tags specified in the parent ContainerInstance object.
    /// <br/>
    /// The Container will be created with the same `compartmentId`, `availabilityDomain`,
    /// and `faultDomain` as the parent ContainerInstance object.
    /// 
    /// </summary>
    public class CreateContainerDetails 
    {
        
        /// <value>
        /// Display name for the Container. There are no guarantees of uniqueness
        /// for this name. If none is provided, it will be calculated automatically.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The container image information. Currently only support public docker registry. Can be either image name,
        /// e.g `containerImage`, image name with version, e.g `containerImage:v1` or complete docker image Url e.g
        /// `docker.io/library/containerImage:latest`.
        /// If no registry is provided, will default the registry to public docker hub `docker.io/library`.
        /// The registry used for container image must be reachable over the Container Instance's VNIC.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImageUrl is required.")]
        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageUrl { get; set; }
        
        /// <value>
        /// This command will override the container's entrypoint process. 
        /// If not specified, the existing entrypoint process defined in the image will be used.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "command")]
        public System.Collections.Generic.List<string> Command { get; set; }
        
        /// <value>
        /// A list of string arguments for a container's entrypoint process.
        /// <br/>
        /// Many containers use an entrypoint process pointing to a shell,
        /// for example /bin/bash. For such containers, this argument list
        /// can also be used to specify the main command in the container process.
        /// <br/>
        /// All arguments together must be 64KB or smaller.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "arguments")]
        public System.Collections.Generic.List<string> Arguments { get; set; }
        
        /// <value>
        /// A list of additional capabilities for the container.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "additionalCapabilities", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<ContainerCapability> AdditionalCapabilities { get; set; }
        
        /// <value>
        /// The working directory within the Container's filesystem for
        /// the Container process. If none is set, the Container will run in the
        /// working directory set by the container image.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "workingDirectory")]
        public string WorkingDirectory { get; set; }
        
        /// <value>
        /// A map of additional environment variables to set in the environment of the container's
        /// entrypoint process. These variables are in addition to any variables already defined
        /// in the container's image.
        /// <br/>
        /// All environment variables together, name and values, must be 64KB or smaller.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "environmentVariables")]
        public System.Collections.Generic.Dictionary<string, string> EnvironmentVariables { get; set; }
        
        /// <value>
        /// List of the volume mounts.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "volumeMounts")]
        public System.Collections.Generic.List<CreateVolumeMountDetails> VolumeMounts { get; set; }
        
        /// <value>
        /// Determines if the Container will have access to the Container Instance Resource Principal. 
        /// This method utilizes resource principal version 2.2. Please refer to 
        /// https://docs.oracle.com/en-us/iaas/Content/API/Concepts/sdk_authentication_methods.htm#sdk_authentication_methods_resource_principal 
        /// for detailed explanation of how to leverage the exposed resource principal elements.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isResourcePrincipalDisabled")]
        public System.Nullable<bool> IsResourcePrincipalDisabled { get; set; }
        
        [JsonProperty(PropertyName = "resourceConfig")]
        public CreateContainerResourceConfigDetails ResourceConfig { get; set; }
        
        /// <value>
        /// list of container health checks to check container status and take appropriate action if container status is failed.
        /// There are three types of health checks that we currently support HTTP, TCP, and Command.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "healthChecks")]
        public System.Collections.Generic.List<CreateContainerHealthCheckDetails> HealthChecks { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
