﻿using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AddressTotals
{
	/// <summary>
	/// Bech32 encoded address
	/// </summary>
	[JsonPropertyName("address")] public string Address { get; set; } = default!;

	/// <summary>
	/// Sum of received assets
	/// </summary>
	[JsonPropertyName("received_sum")] public Amount[] ReceivedSum { get; set; } = default!;

	/// <summary>
	/// Sum of sent assets
	/// </summary>
	[JsonPropertyName("sent_sum")] public Amount[] SentSum { get; set; } = default!;

	/// <summary>
	/// Count of all transactions for this address
	/// </summary>
	[JsonPropertyName("tx_count")] public uint TxCount { get; set; }
}