#pragma warning disable S4004 // Collection properties should be readonly
#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class Attributes
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public string Output { get; set; }

        [JsonProperty("silent", NullValueHandling = NullValueHandling.Ignore)]
        public bool Silent { get; set; }

        [JsonProperty("channel", NullValueHandling = NullValueHandling.Ignore)]
        public string Channel { get; set; }
    }

    public class TaskData
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("modified")]
        public DateTime Modified { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty("result")]
        public dynamic Result { get; set; }
    }

    public class TaskDataDevice
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("modified")]
        public DateTime Modified { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty("result")]
        public object Result { get; set; }
    }

    public class McsTasks
    {
        [JsonProperty("data")]
        public List<TaskData> Data { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }

    public class McsMonitoringTasks
    {
        [JsonProperty("data")]
        public List<TaskDataDevice> Data { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }

    public class McsTask
    {
        [JsonProperty("data")]
        public TaskData Data { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }

    public class McsDeviceTask
    {
        [JsonProperty("data")]
        public TaskDataDevice Data { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }

    public class DeleteTallyProxyRequestDto
    {
        [JsonProperty("data")]
        public List<DeleteTallyProxyEntryDto> Data { get; set; }
    }

    /// <summary>
    /// Identifies a Tally Proxy label on exactly one device or output.
    /// </summary>
    public class DeleteTallyProxyEntryDto
    {
        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public string Output { get; set; }

        [JsonProperty("labels")]
        public List<string> Labels { get; set; }
    }

    /// <summary>
    /// Response body for a Tally Proxy delete operation.
    /// </summary>
    public class DeleteTallyProxyResponseDto
    {
        [JsonProperty("data")]
        public DeleteTallyProxyResponseDataDto Data { get; set; }
    }

    /// <summary>
    /// Result data returned by the Tally Proxy delete endpoint.
    /// </summary>
    public class DeleteTallyProxyResponseDataDto
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
