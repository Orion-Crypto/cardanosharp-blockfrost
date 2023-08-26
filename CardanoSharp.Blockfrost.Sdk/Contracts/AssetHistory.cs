using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AssetHistory
{
	[JsonPropertyName("tx_hash")] public string TxHash { get; set; } = default!;

	[JsonPropertyName("amount")] public string Amount { get; set; } = default!;

	[JsonPropertyName("action")] public string Action { get; set; } = default!;
}