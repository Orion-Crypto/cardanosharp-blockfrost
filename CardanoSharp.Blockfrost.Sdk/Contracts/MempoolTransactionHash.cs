using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class MempoolTransactionHash
{
	[JsonPropertyName("tx_hash")] public string TxHash { get; set; } = default!;
}