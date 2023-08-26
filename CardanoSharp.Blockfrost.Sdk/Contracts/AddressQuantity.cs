using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AddressQuantity
{
	[JsonPropertyName("address")] public string Address { get; set; } = default!;

	[JsonPropertyName("quantity")] public string Quantity { get; set; } = default!;
}