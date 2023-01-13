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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Connect Descriptor details. Required for Manual and UserManagerOci connection types.
    /// If a Private Endpoint was specified for the Connection, the host should contain a valid IP address.
    /// 
    /// </summary>
    public class CreateConnectDescriptor 
    {
        
        /// <value>
        /// Host or IP address of the connect descriptor. Required if no connectString was specified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <value>
        /// Port of the connect descriptor. Required if no connectString was specified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// Database service name. Required if no connectString was specified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseServiceName")]
        public string DatabaseServiceName { get; set; }
        
        /// <value>
        /// Connect String. Required if no host, port nor databaseServiceName were specified.
        /// If a Private Endpoint was specified in the Connection, the host entry should be a valid IP address.
        /// Supported formats:
        /// Easy connect: <host>:<port>/<db_service_name>
        /// Long format: (description= (address=(port=<port>)(host=<host>))(connect_data=(service_name=<db_service_name>)))
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectString")]
        public string ConnectString { get; set; }
        
    }
}
