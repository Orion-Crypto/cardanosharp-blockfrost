using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class TransactionUtxoInput
{
    [JsonPropertyName("address")] public string Address { get; set; } = default!;

    [JsonPropertyName("amount")] public List<Amount> Amount { get; set; } = default!;

    [JsonPropertyName("tx_hash")] public string TxHash { get; set; } = default!;

    [JsonPropertyName("output_index")] public uint OutputIndex { get; set; }

    [JsonPropertyName("data_hash")] public string DataHash { get; set; } = default!;

    [JsonPropertyName("inline_datum")] public string InlineDatum { get; set; } = default!;

    [JsonPropertyName("reference_script_hash")] public string ReferenceScriptHash { get; set; } = default!;

    [JsonPropertyName("collateral")] public bool Collateral { get; set; }

    [JsonPropertyName("reference")] public bool Reference { get; set; }
}