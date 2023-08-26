using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AccountReward
{
	/// <summary>
	/// Epoch of the associated reward
	/// </summary>
	[JsonPropertyName("epoch")] public uint Epoch { get; set; } = default!;

	/// <summary>
	/// Rewards for given epoch in Lovelaces
	/// </summary>
	[JsonPropertyName("amount")] public string Amount { get; set; } = default!;

	/// <summary>
	/// Bech32 pool ID being delegated to
	/// </summary>
	[JsonPropertyName("pool_id")] public string PoolId { get; set; } = default!;

	/// <summary>
	/// Type of the reward ["leader"/"member"/"pool_deposit_refund"]
	/// </summary>
	[JsonPropertyName("type")] public string Type { get; set; } = default!;
}