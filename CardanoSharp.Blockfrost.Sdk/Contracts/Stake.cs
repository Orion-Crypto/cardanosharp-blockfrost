using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class Stake
{
	[JsonPropertyName("live")] public string Live { get; set; } = default!;

	[JsonPropertyName("Active")] public string Active { get; set; } = default!;
}