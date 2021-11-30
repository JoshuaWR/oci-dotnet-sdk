/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The credential to be used to connect to the database.
    /// </summary>
    [JsonConverter(typeof(SqlTuningTaskCredentialDetailsModelConverter))]
    public class SqlTuningTaskCredentialDetails 
    {
        
        
        /// <value>
        /// The user to connect to the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Username is required.")]
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
                ///
        /// <value>
        /// The role of the database user.
        /// </value>
        ///
        public enum RoleEnum {
            [EnumMember(Value = "NORMAL")]
            Normal,
            [EnumMember(Value = "SYSDBA")]
            Sysdba
        };

        /// <value>
        /// The role of the database user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Role is required.")]
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RoleEnum> Role { get; set; }
        
    }

    public class SqlTuningTaskCredentialDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(SqlTuningTaskCredentialDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(SqlTuningTaskCredentialDetails);
            var discriminator = jsonObject["sqlTuningTaskCredentialType"].Value<string>();
            switch (discriminator)
            {
                case "SECRET":
                    obj = new SqlTuningTaskSecretCredentialDetails();
                    break;
                case "PASSWORD":
                    obj = new SqlTuningTaskPasswordCredentialDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
