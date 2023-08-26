using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
	public class Script
	{
		[JsonPropertyName("script_hash")] public string ScriptHash { get; set; } = default!;

		[JsonPropertyName("type")] public string Type { get; set; } = default!;

		[JsonPropertyName("serialised_size")] public uint? SerialisedSize { get; set; }
	}
}