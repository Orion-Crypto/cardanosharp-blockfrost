using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class EpochPoolDelegation
{
	[JsonPropertyName("active_epoch")] public ulong ActiveEpoch { get; set; }

	[JsonPropertyName("amount")] public string Amount { get; set; } = default!;

	[JsonPropertyName("pool_id")] public string PoolId { get; set; } = default!;
}