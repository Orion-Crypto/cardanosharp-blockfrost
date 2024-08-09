using System.Text.Json;
using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class AssetDetails
{
    [JsonPropertyName("asset")]
    public string Asset { get; set; } = default!;

    [JsonPropertyName("policy_id")]
    public string PolicyId { get; set; } = default!;

    [JsonPropertyName("asset_name")]
    public string? AssetName { get; set; } = default!;

    [JsonPropertyName("fingerprint")]
    public string Fingerprint { get; set; } = default!;

    [JsonPropertyName("quantity")]
    public string Quantity { get; set; } = default!;

    [JsonPropertyName("initial_mint_tx_hash")]
    public string InitialMintTxHash { get; set; } = default!;

    [JsonPropertyName("mint_or_burn_count")]
    public uint MintOrBurnCount { get; set; }

    [JsonPropertyName("onchain_metadata")]
    public OnchainMetadata? OnchainMetadata { get; set; }

    [JsonPropertyName("onchain_metadata_standard")]
    public string? OnchainMetadataStandard { get; set; }

    [JsonPropertyName("onchain_metadata_extra")]
    public string? OnchainMetadataExtra { get; set; }

    [JsonPropertyName("metadata")]
    public OffchainMetadata? Metadata { get; set; }
}
