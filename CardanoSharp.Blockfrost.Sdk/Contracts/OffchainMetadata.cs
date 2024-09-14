using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
    public class OffchainMetadata
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public object? Description { get; set; }

        [JsonPropertyName("ticker")]
        public string? Ticker { get; set; }

        [JsonPropertyName("url")]
        public object? Url { get; set; }

        [JsonPropertyName("image")]
        public object? Image { get; set; }

        [JsonPropertyName("logo")]
        public object? Logo { get; set; }

        [JsonPropertyName("decimals")]
        public object? Decimals { get; set; } // This can be a string or int
    }
}
