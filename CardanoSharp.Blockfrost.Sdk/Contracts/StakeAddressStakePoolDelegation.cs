using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class StakeAddressStakePoolDelegation
{
	[JsonPropertyName("stake_address")] public string StakeAddress { get; set; } = default!;

	[JsonPropertyName("pool_id")] public string PoolId { get; set; } = default!;

	[JsonPropertyName("amount")] public string Amount { get; set; } = default!;
}