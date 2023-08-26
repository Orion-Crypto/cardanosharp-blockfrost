using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class Redeemer
{
    [JsonPropertyName("tx_index")] public long TxIndex { get; set; }
    [JsonPropertyName("purpose")] public string Purpose { get; set; } = default!;
    [JsonPropertyName("unit_mem")] public string? UnitMem { get; set; } = null;
    [JsonPropertyName("unit_steps")] public string? UnitSteps { get; set; } = null;

    public Redeemer() { }
}