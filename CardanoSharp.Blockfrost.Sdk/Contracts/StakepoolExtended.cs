using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class StakepoolExtended
{
    /// <summary>
    /// Bech32 encoded pool ID
    /// </summary>
    [JsonPropertyName("pool_id")] public string PoolId { get; set; } = default!;

    /// <summary>
    /// Hexadecimal pool ID.
    /// </summary>
    [JsonPropertyName("hex")] public string Hex { get; set; } = default!;

    /// <summary>
    /// Active delegated amount
    /// </summary>
    [JsonPropertyName("active_stake")] public string ActiveStake { get; set; } = default!;

    /// <summary>
    /// Currently delegated amount
    /// </summary>
    [JsonPropertyName("live_stake")] public string LiveStake { get; set; } = default!;
}