using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AccountAddressesDetailedInfo
{
	/// <summary>
	/// Bech32 encoded stake address
	/// </summary>
	[JsonPropertyName("stake_address")] public string StakeAddress { get; set; } = default!;

	/// <summary>
	/// Sum of received assets
	/// </summary>
	[JsonPropertyName("received_sum")] public Amount[] ReceivedSum { get; set; } = default!;

	/// <summary>
	/// Sum of sent assets
	/// </summary>
	[JsonPropertyName("sent_sum")] public Amount[] SentSum { get; set; } = default!;

	/// <summary>
	/// Count of all transactions for all addresses associated with the account
	/// </summary>
	[JsonPropertyName("tx_count")] public uint TxCount { get; set; }
}