using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class TransactionMetadata
{
    [JsonPropertyName("label")]
    public string Label { get; set; } = default!;

    [JsonPropertyName("json_metadata")]
    public object? JsonMetadata { get; set; } = default!;
}
