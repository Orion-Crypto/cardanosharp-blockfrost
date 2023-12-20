using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface IScriptsClient
{
    [Get("/scripts/{script_hash}/json")]
    Task<ApiResponse<ScriptJson>> GetScriptJsonAsync(string script_hash);

    [Get("/scripts/{script_hash}")]
    Task<ApiResponse<Script>> GetScriptAsync(string script_hash);

    [Get("/scripts/datum/{datum_hash}")]
    Task<ApiResponse<DatumJson>> GetDatumJsonAsync(string datum_hash);

    [Get("/scripts/datum/{datum_hash}/cbor")]
    Task<ApiResponse<Datum>> GetDatumCborAsync(string datum_hash);
}
