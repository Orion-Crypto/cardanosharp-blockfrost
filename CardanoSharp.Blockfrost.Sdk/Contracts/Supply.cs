using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class Supply
{
	[JsonPropertyName("max")] public string Max { get; set; } = default!;

	[JsonPropertyName("total")] public string Total { get; set; } = default!;

	[JsonPropertyName("circulating")] public string Circulating { get; set; } = default!;

	[JsonPropertyName("locked")] public string Locked { get; set; } = default!;

	[JsonPropertyName("treasury")] public string Treasury { get; set; } = default!;

	[JsonPropertyName("reserves")] public string Reserves { get; set; } = default!;
}