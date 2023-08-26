using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AssetQuantity
{
	[JsonPropertyName("asset")] public string Asset { get; set; } = default!;

	[JsonPropertyName("quantity")] public string Quantity { get; set; } = default!;
}