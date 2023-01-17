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
    /// A base request type that contains common criteria for Marketplace Search Listings details.
    /// 
    /// </summary>
    [JsonConverter(typeof(SearchListingsDetailsModelConverter))]
    public class SearchListingsDetails 
    {
        
        
        /// <value>
        /// The type of matching context returned in the response. If you specify HIGHLIGHTS, then the service will highlight fragments in its response. The default value is NONE.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "matchingContextType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MatchingContextTypeEnum> MatchingContextType { get; set; }
        
    }

    public class SearchListingsDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(SearchListingsDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(SearchListingsDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "Structured":
                    obj = new StructuredSearchDetails();
                    break;
                case "FreeText":
                    obj = new FreeTextSearchDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
