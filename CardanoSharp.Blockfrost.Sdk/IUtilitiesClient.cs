using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface IUtiliesClient
{
    [Headers("Content-Type: application/cbor")]
    [Post("/utils/tx/evalute")]
    Task<ApiResponse<TransactionEvaluation>> GetTransactionEvaluationAsync([Body] Stream content);
}
