using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class MempoolTransaction
{
    public class Transaction
    {
        [JsonPropertyName("hash")] public string Hash { get; set; } = default!;
        [JsonPropertyName("output_amount")] public Amount[] OutputAmount { get; set; } = default!;
        [JsonPropertyName("fees")] public string Fees { get; set; } = default!;
        [JsonPropertyName("deposit")] public string? Deposit { get; set; }
        [JsonPropertyName("size")] public ushort Size { get; set; }
        [JsonPropertyName("invalid_before")] public string? InvalidBefore { get; set; }
        [JsonPropertyName("invalid_hereafter")] public string? InvalidHereafter { get; set; }
        [JsonPropertyName("utxo_count")] public ushort UtxoCount { get; set; }
        [JsonPropertyName("withdrawal_count")] public ushort WithdrawalCount { get; set; }
        [JsonPropertyName("mir_cert_count")] public ushort MirCertCount { get; set; }
        [JsonPropertyName("delegation_count")] public ushort DelegationCount { get; set; }
        [JsonPropertyName("stake_cert_count")] public ushort StakeCertCount { get; set; }
        [JsonPropertyName("pool_update_count")] public ushort PoolUpdateCount { get; set; }
        [JsonPropertyName("pool_retire_count")] public ushort PoolRetireCount { get; set; }
        [JsonPropertyName("asset_mint_or_burn_count")] public uint AssetMintOrBurnCount { get; set; }
        [JsonPropertyName("redeemer_count")] public ushort RedeemerCount { get; set; }
        [JsonPropertyName("valid_contract")] public bool ValidContract { get; set; }

        public Transaction() { }
    }

    public class Input
    {
        [JsonPropertyName("address")] public string Address { get; set; } = default!;
        [JsonPropertyName("tx_hash")] public string TxHash { get; set; } = default!;
        [JsonPropertyName("output_index")] public ushort OutputIndex { get; set; } = 0;
        [JsonPropertyName("collateral")] public bool Collateral { get; set; } = false;
        [JsonPropertyName("reference")] public bool Reference { get; set; } = false;

        public Input() { }
    }

    public class Output
    {
        [JsonPropertyName("address")] public string Address { get; set; } = default!;
        [JsonPropertyName("amount")] public Amount[] Amount { get; set; } = default!;
        [JsonPropertyName("output_index")] public ushort OutputIndex { get; set; } = 0;
        [JsonPropertyName("data_hash")] public string? DataHash { get; set; }
        [JsonPropertyName("inline_datum")] public string? InlineDatum { get; set; }
        [JsonPropertyName("reference_script_hash")] public string? ReferenceScriptHash { get; set; }
        [JsonPropertyName("collateral")] public bool Collateral { get; set; } = false;

        public Output() { }
    }

    [JsonPropertyName("tx")] public Transaction Tx { get; set; } = default!;
    [JsonPropertyName("inputs")] public Input[] Inputs { get; set; } = default!;
    [JsonPropertyName("outputs")] public Output[] Outputs { get; set; } = default!;
    [JsonPropertyName("redeemers")] public Redeemer[] Redeemers { get; set; } = default!;

    public MempoolTransaction() { }
}