/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// The Pluggable Database creation type.
    /// Use `LOCAL_CLONE_PDB` for creating a new PDB using Local Clone on Source Pluggable Database. This will Clone and starts a
    /// pluggable database (PDB) in the same database (CDB) as the source PDB. The source PDB must be in the `READ_WRITE` openMode to
    /// perform the clone operation.
    /// isThinClone options are supported only for Exadata VM cluster on Exascale Infrastructure.
    /// Use `REMOTE_CLONE_PDB` for creating a new PDB using Remote Clone on Source Pluggable Database. This will Clone a pluggable
    /// database (PDB) to a different database from the source PDB. The cloned PDB will be started upon completion of the clone
    /// operation. The source PDB must be in the `READ_WRITE` openMode when performing the clone.
    /// For Exadata Cloud@Customer instances, the source pluggable database (PDB) must be on the same Exadata Infrastructure as the
    /// target container database (CDB) to create a remote clone.
    /// isThinClone options are supported only for Exadata VM cluster on Exascale Infrastructure.
    /// Use `RELOCATE_PDB` for relocating the Pluggable Database from Source CDB and creating it in target CDB. This will relocate a
    /// pluggable database (PDB) to a different database from the source PDB. The source PDB must be in the `READ_WRITE` openMode when
    /// performing the relocate.
    /// 
    /// </summary>
    [JsonConverter(typeof(CreatePluggableDatabaseCreationTypeDetailsModelConverter))]
    public class CreatePluggableDatabaseCreationTypeDetails 
    {
                ///
        /// <value>
        /// The Pluggable Database creation type.
        /// </value>
        ///
        public enum CreationTypeEnum {
            [EnumMember(Value = "LOCAL_CLONE_PDB")]
            LocalClonePdb,
            [EnumMember(Value = "REMOTE_CLONE_PDB")]
            RemoteClonePdb,
            [EnumMember(Value = "RELOCATE_PDB")]
            RelocatePdb
        };

        
    }

    public class CreatePluggableDatabaseCreationTypeDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreatePluggableDatabaseCreationTypeDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreatePluggableDatabaseCreationTypeDetails);
            var discriminator = jsonObject["creationType"].Value<string>();
            switch (discriminator)
            {
                case "RELOCATE_PDB":
                    obj = new CreatePluggableDatabaseFromRelocateDetails();
                    break;
                case "REMOTE_CLONE_PDB":
                    obj = new CreatePluggableDatabaseFromRemoteCloneDetails();
                    break;
                case "LOCAL_CLONE_PDB":
                    obj = new CreatePluggableDatabaseFromLocalCloneDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
