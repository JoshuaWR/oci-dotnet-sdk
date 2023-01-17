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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Parameters for cloning a pluggable database (PDB) within the same database (CDB).
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class LocalClonePluggableDatabaseDetails 
    {
        
        /// <value>
        /// The name for the pluggable database (PDB). The name is unique in the context of a {@link Database}. The name must begin with an alphabetic character and can contain a maximum of thirty alphanumeric characters. Special characters are not permitted. The pluggable database name should not be same as the container database name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClonedPdbName is required.")]
        [JsonProperty(PropertyName = "clonedPdbName")]
        public string ClonedPdbName { get; set; }
        
        /// <value>
        /// A strong password for PDB Admin of the newly cloned PDB. The password must be at least nine characters and contain at least two uppercase, two lowercase, two numbers, and two special characters. The special characters must be _, \\#, or -.
        /// </value>
        [JsonProperty(PropertyName = "pdbAdminPassword")]
        public string PdbAdminPassword { get; set; }
        
        /// <value>
        /// The existing TDE wallet password of the target CDB.
        /// </value>
        [JsonProperty(PropertyName = "targetTdeWalletPassword")]
        public string TargetTdeWalletPassword { get; set; }
        
        /// <value>
        /// The locked mode of the pluggable database admin account. If false, the user needs to provide the PDB Admin Password to connect to it.
        /// If true, the pluggable database will be locked and user cannot login to it.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shouldPdbAdminAccountBeLocked")]
        public System.Nullable<bool> ShouldPdbAdminAccountBeLocked { get; set; }
        
    }
}
