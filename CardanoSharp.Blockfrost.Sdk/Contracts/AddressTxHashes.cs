using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AddressTxHashes
{
	[JsonPropertyName("address")] public string Address { get; set; } = default!;

	[JsonPropertyName("transactions")] public TransactionHash[] Transactions { get; set; } = default!;
}