using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AddressInfo
{
	[JsonPropertyName("address")] public string Address { get; set; } = default!;

	[JsonPropertyName("amount")] public Amount[] Amount { get; set; } = default!;

	[JsonPropertyName("stake_address")] public string StakeAddress { get; set; } = default!;

	[JsonPropertyName("type")] public string Type { get; set; } = default!;

	[JsonPropertyName("script")] public bool Script { get; set; }
}