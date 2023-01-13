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

namespace Oci.CertificatesmanagementService.Models
{
    /// <summary>
    /// A rule that you can apply to a certificate authority (CA) to enforce certain conditions on its usage and management.
    /// </summary>
    [JsonConverter(typeof(CertificateAuthorityRuleModelConverter))]
    public class CertificateAuthorityRule 
    {
                ///
        /// <value>
        /// The type of rule, whether a renewal rule regarding when to renew the CA or an issuance expiry rule that governs how long the certificates and CAs issued by the CA are valid. (For internal use only) An internal issuance rule defines the number and type of certificates that the CA can issue.
        /// 
        /// </value>
        ///
        public enum RuleTypeEnum {
            [EnumMember(Value = "CERTIFICATE_AUTHORITY_ISSUANCE_EXPIRY_RULE")]
            CertificateAuthorityIssuanceExpiryRule
        };

        
    }

    public class CertificateAuthorityRuleModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CertificateAuthorityRule);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CertificateAuthorityRule);
            var discriminator = jsonObject["ruleType"].Value<string>();
            switch (discriminator)
            {
                case "CERTIFICATE_AUTHORITY_ISSUANCE_EXPIRY_RULE":
                    obj = new CertificateAuthorityIssuanceExpiryRule();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under CertificateAuthorityRule! Returning null value.");
            }
            return obj;
        }
    }
}
