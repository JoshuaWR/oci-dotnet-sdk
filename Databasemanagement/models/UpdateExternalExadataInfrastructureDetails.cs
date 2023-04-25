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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details of updating external Exadata infrastructure.
    /// </summary>
    public class UpdateExternalExadataInfrastructureDetails 
    {
        
        /// <value>
        /// The unique key of the discovery request.
        /// </value>
        [JsonProperty(PropertyName = "discoveryKey")]
        public string DiscoveryKey { get; set; }
                ///
        /// <value>
        /// The Oracle license model that applies to the database management resources.
        /// 
        /// </value>
        ///
        public enum LicenseModelEnum {
            [EnumMember(Value = "LICENSE_INCLUDED")]
            LicenseIncluded,
            [EnumMember(Value = "BRING_YOUR_OWN_LICENSE")]
            BringYourOwnLicense
        };

        /// <value>
        /// The Oracle license model that applies to the database management resources.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseModelEnum> LicenseModel { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The name of the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The list of all the rac database system OCIDs. If not specified, it keeps the existing database systems
        /// </value>
        [JsonProperty(PropertyName = "dbSystemIds")]
        public System.Collections.Generic.List<string> DbSystemIds { get; set; }
        
        /// <value>
        /// The list of the names of the storage servers to be monitored. If not specified, it includes all the storage servers associated with the monitored database systems.
        /// </value>
        [JsonProperty(PropertyName = "storageServerNames")]
        public System.Collections.Generic.List<string> StorageServerNames { get; set; }
        
    }
}
