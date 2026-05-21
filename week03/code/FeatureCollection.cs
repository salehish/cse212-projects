using System.Text.Json.Serialization;

public class FeatureCollection
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("metadata")]
    public MetadataInfo Metadata { get; set; }
    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; }

    public class MetadataInfo
    {
        [JsonPropertyName("generated")]
        public long Generated { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("api")]
        public string Api { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    public class Feature
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("properties")]
        public Properties Properties { get; set; }
    }

    public class Properties
    {
        [JsonPropertyName("mag")]
        public double? Mag { get; set; }

        [JsonPropertyName("place")]
        public string Place { get; set; }

        [JsonPropertyName("time")]
        public long Time { get; set; }

        [JsonPropertyName("updated")]
        public long Updated { get; set; }

        [JsonPropertyName("tz")]
        public int? Tz { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("detail")]
        public string Detail { get; set; }
    }
}