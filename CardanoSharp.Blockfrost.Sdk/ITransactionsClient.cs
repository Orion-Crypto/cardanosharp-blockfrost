﻿using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface ITransactionsClient
{
    [Get("/txs/{hash}")]
    Task<ApiResponse<Transaction>> GetTransactionAsync(string hash);

    [Get("/txs/{hash}/metadata")]
    Task<ApiResponse<TransactionMetadata[]>> GetTransactionMetadataAsync(string hash);

    [Headers("Content-Type: application/cbor")]
    [Post("/tx/submit")]
    Task<ApiResponse<string>> PostSubmitTransactionAsync([Body] Stream content);

    [Get("/txs/{hash}/utxos")]
    Task<ApiResponse<TransactionUtxo>> GetUtxosAsync(string hash);
}
