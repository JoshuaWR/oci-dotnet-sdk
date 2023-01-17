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
using Newtonsoft.Json.Linq;

namespace Oci.MarketplaceService.Models
{
    /// <summary>
    /// A base object for creating a publication package.
    /// </summary>
    [JsonConverter(typeof(CreatePublicationPackageModelConverter))]
    public class CreatePublicationPackage 
    {
        
        /// <value>
        /// The package version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PackageVersion is required.")]
        [JsonProperty(PropertyName = "packageVersion")]
        public string PackageVersion { get; set; }
        
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperatingSystem is required.")]
        [JsonProperty(PropertyName = "operatingSystem")]
        public OperatingSystem OperatingSystem { get; set; }
        
        /// <value>
        /// The end user license agreeement (EULA) that consumers of this listing must accept.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Eula is required.")]
        [JsonProperty(PropertyName = "eula")]
        public System.Collections.Generic.List<Eula> Eula { get; set; }
        
    }

    public class CreatePublicationPackageModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreatePublicationPackage);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreatePublicationPackage);
            var discriminator = jsonObject["packageType"].Value<string>();
            switch (discriminator)
            {
                case "IMAGE":
                    obj = new CreateImagePublicationPackage();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
