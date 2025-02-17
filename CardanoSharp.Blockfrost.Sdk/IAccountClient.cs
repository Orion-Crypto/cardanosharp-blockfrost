﻿using CardanoSharp.Blockfrost.Sdk.Contracts;
using Refit;

namespace CardanoSharp.Blockfrost.Sdk;

public interface IAccountClient
{
	[Get("/accounts/{stake_address}/delegations?count={count}&page={page}&order={order}")]
	Task<ApiResponse<EpochPoolTxDelegation[]>> GetAccountDelegationHistory(string stake_address, int count = 100, int page = 1, string order = "asc");

	[Get("/accounts/{stake_address}/history?count={count}&page={page}&order={order}")]
	Task<ApiResponse<EpochPoolDelegation[]>> GetAccountHistory(string stake_address, int count = 100, int page = 1, string order = "asc");

	[Get("/accounts/{stake_address}/addresses?count={count}&page={page}&order={order}")]
	Task<ApiResponse<AddressBasic[]>> GetAccountAssociatedAddresses(string stake_address, int count = 100, int page = 1, string order = "asc");

	[Get("/accounts/{stake_address}/addresses/assets?count={count}&page={page}&order={order}")]
	Task<ApiResponse<Amount[]>> GetAccountAssociatedAddressesAssets(string stake_address, int count = 100, int page = 1, string order = "asc");

	[Get("/accounts/{stake_address}")]
	Task<ApiResponse<AccountDetails>> GetAccountDetails(string stake_address);

	[Get("/accounts/{stake_address}/rewards?count={count}&page={page}&order={order}")]
	Task<ApiResponse<AccountReward[]>> GetAccountRewards(string stake_address, int count = 100, int page = 1, string order = "asc");

	[Get("/accounts/{stake_address}/registrations?count={count}&page={page}&order={order}")]
	Task<ApiResponse<AccountRegistration[]>> GetAccountRegistrationHistory(string stake_address, int count = 100, int page = 1, string order = "asc");

	[Get("/accounts/{stake_address}/withdrawals?count={count}&page={page}&order={order}")]
	Task<ApiResponse<AccountWithdrawal[]>> GetAccountWithdrawals(string stake_address, int count = 100, int page = 1, string order = "asc");

	[Get("/accounts/{stake_address}/mirs?count={count}&page={page}&order={order}")]
	Task<ApiResponse<AccountMirs[]>> GetAccountMirHistory(string stake_address, int count = 100, int page = 1, string order = "asc");

	[Get("/accounts/{stake_address}/addresses/total")]
	Task<ApiResponse<AccountAddressesDetailedInfo>> GetAccountAddressesDetailedInfo(string stake_address);
}