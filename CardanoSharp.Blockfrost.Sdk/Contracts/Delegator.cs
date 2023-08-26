using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class Delegator
{
    /// <summary>
    /// Bech32 encoded stake addresses
    /// </summary>
    [JsonPropertyName("address")] public string Address { get; set; } = default!;

    /// <summary>
    /// Currently delegated amount
    /// </summary>
    [JsonPropertyName("live_stake")] public string LiveStake { get; set; } = default!;

}
