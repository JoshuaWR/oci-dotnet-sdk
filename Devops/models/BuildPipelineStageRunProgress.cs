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

namespace Oci.DevopsService.Models
{
    /// <summary>
    /// The details about the run progress of a stage in a build run.
    /// </summary>
    [JsonConverter(typeof(BuildPipelineStageRunProgressModelConverter))]
    public class BuildPipelineStageRunProgress 
    {
        
        /// <value>
        /// Build Run display name, which can be renamed and is not necessarily unique. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "stageDisplayName")]
        public string StageDisplayName { get; set; }
        
        
        /// <value>
        /// The stage OCID.
        /// </value>
        [JsonProperty(PropertyName = "buildPipelineStageId")]
        public string BuildPipelineStageId { get; set; }
        
        /// <value>
        /// The time the stage started executing. Format defined by [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The time the stage finished executing. Format defined by [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
                ///
        /// <value>
        /// The current status of the stage.
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "CANCELING")]
            Canceling,
            [EnumMember(Value = "CANCELED")]
            Canceled
        };

        /// <value>
        /// The current status of the stage.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        [JsonProperty(PropertyName = "buildPipelineStagePredecessors")]
        public BuildPipelineStagePredecessorCollection BuildPipelineStagePredecessors { get; set; }
        
    }

    public class BuildPipelineStageRunProgressModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(BuildPipelineStageRunProgress);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(BuildPipelineStageRunProgress);
            var discriminator = jsonObject["buildPipelineStageType"].Value<string>();
            switch (discriminator)
            {
                case "DELIVER_ARTIFACT":
                    obj = new DeliverArtifactStageRunProgress();
                    break;
                case "WAIT":
                    obj = new WaitStageRunProgress();
                    break;
                case "TRIGGER_DEPLOYMENT_PIPELINE":
                    obj = new TriggerDeploymentPipelineStageRunProgress();
                    break;
                case "BUILD":
                    obj = new BuildStageRunProgress();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under BuildPipelineStageRunProgress! Returning null value.");
            }
            return obj;
        }
    }
}
