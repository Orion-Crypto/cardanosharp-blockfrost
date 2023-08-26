using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class TransactionUtxo
{
    [JsonPropertyName("hash")] public string Hash { get; set; } = default!;

    [JsonPropertyName("inputs")] public List<TransactionUtxoInput> Inputs { get; set; } = default!;

    [JsonPropertyName("outputs")] public List<TransactionUtxoOutput> Outputs { get; set; } = default!;
}