using System.Text.Json;
using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts
{
    public class DatumJson
    {
        [JsonPropertyName("json_value")]
        public JsonElement? Json { get; set; }
    }
}
