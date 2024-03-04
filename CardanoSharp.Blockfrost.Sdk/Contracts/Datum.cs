using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
    public class Datum
    {
        [JsonPropertyName("cbor")]
        public string cbor { get; set; } = default!;
    }
}
