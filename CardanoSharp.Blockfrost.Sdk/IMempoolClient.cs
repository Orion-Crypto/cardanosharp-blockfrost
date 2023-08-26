using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface IMempoolClient
{
	[Get("/mempool?count={count}&page={page}&order={order}")]
	Task<ApiResponse<MempoolTransactionHash[]>> GetMempoolAsync(int count = 100, int page = 1, string order = "asc");

	[Get("/mempool/{hash}")]
	Task<ApiResponse<MempoolTransaction[]>> GetMempoolTransactionAsync(string hash);

	[Get("/mempool/addresses/{address}?count={count}&page={page}&order={order}")]
	Task<ApiResponse<MempoolTransactionHash[]>> GetTransactionsAsync(string address, int count = 100, int page = 1, string order = "asc");
}