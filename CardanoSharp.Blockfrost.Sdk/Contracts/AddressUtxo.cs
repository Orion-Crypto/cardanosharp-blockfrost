using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AddressUtxo
{
	[JsonPropertyName("address")] public string Address { get; set; } = default!;

	[JsonPropertyName("tx_hash")] public string TxHash { get; set; } = default!;

	[JsonPropertyName("output_index")] public ushort OutputIndex { get; set; }

	[JsonPropertyName("amount")] public Amount[] Amount { get; set; } = default!;

	[JsonPropertyName("block")] public string Block { get; set; } = default!;

	[JsonPropertyName("data_hash")] public string? DataHash { get; set; }

	[JsonPropertyName("inline_datum")] public string? InlineDatum { get; set; }

	[JsonPropertyName("reference_script_hash")] public string? ReferenceScriptHash { get; set; }
}