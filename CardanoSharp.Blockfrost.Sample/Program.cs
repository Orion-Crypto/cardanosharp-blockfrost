using CardanoSharp.Blockfrost.Sdk;
using CardanoSharp.Blockfrost.Sdk.Common;
using CardanoSharp.Wallet.Extensions;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(
        (hostContext, services) =>
        {
            var apiKey = hostContext.Configuration["Blockfrost:ApiKey"]; // "mainneteaq9vgjtJnHHxEb4ALstGolvoU3JXpb9";
            var baseUrl = hostContext.Configuration["Blockfrost:BaseUrl"]; // "https://cardano-mainnet.blockfrost.io/api/v0";
            var authConfig = new AuthHeaderConfiguration(apiKey, baseUrl);
            services.AddBlockfrost(authConfig);

            services.AddHostedService<Worker>();
        }
    )
    .Build();
await host.RunAsync();

public class Worker : BackgroundService
{
    private readonly IAccountClient _accountClient;
    private readonly IAddressesClient _addressesClient;
    private readonly IAssetsClient _assetsClient;
    private readonly IBlocksClient _blocksClient;
    private readonly IEpochsClient _epochsClient;
    private readonly IMempoolClient _mempoolClient;
    private readonly INetworkClient _networkClient;
    private readonly IPoolsClient _poolsClient;
    private readonly IScriptsClient _scriptsClient;
    private readonly ITransactionsClient _transactionsClient;
    private readonly IUtiliesClient _utiliesClient;

    public Worker(
        IAccountClient accountClient,
        IAddressesClient addressesClient,
        IAssetsClient assetsClient,
        IBlocksClient blocksClient,
        IEpochsClient epochsClient,
        IMempoolClient mempoolClient,
        INetworkClient networkClient,
        IPoolsClient poolsClient,
        IScriptsClient scriptsClient,
        ITransactionsClient transactionsClient,
        IUtiliesClient utiliesClient
    )
    {
        _accountClient = accountClient;
        _addressesClient = addressesClient;
        _assetsClient = assetsClient;
        _blocksClient = blocksClient;
        _epochsClient = epochsClient;
        _mempoolClient = mempoolClient;
        _networkClient = networkClient;
        _poolsClient = poolsClient;
        _scriptsClient = scriptsClient;
        _transactionsClient = transactionsClient;
        _utiliesClient = utiliesClient;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // Test Calls
        //var network = await _networkClient.GetNetworkInformationAsync();
        //var tx = await _transactionsClient.GetTransactionAsync("ad768ec1f3326aaf0b7a2b8284b268258bfbb8b60ff54321956bb2c4cf08eeae");
        //await TestTxSubmitAsync();
        //var firstPage = await _assetsClient.GetAssetsAsync();
        //var secondHalfPage = await _assetsClient.GetAssetsAsync(50, 2);
        //var nftAsset = await _assetsClient.GetAssetAsync("d865f9a1aff32c21d9471f328879bcdb070aa31e2189e0d997c675f254455354424f583030323139");
        //var ftAsset = await _assetsClient.GetAssetAsync("698a6ea0ca99f315034072af31eaac6ec11fe8558d3f48e9775aab9d7444524950");
        //var ftAssetAddrs = await _assetsClient.GetAssetAddressesAsync("698a6ea0ca99f315034072af31eaac6ec11fe8558d3f48e9775aab9d7444524950");
        //var ftAssetTxs = await _assetsClient.GetAssetTransactionsAsync("698a6ea0ca99f315034072af31eaac6ec11fe8558d3f48e9775aab9d7444524950");
        //var policyAssets = await _assetsClient.GetPolicyAssetsAsync("f65bde2d672f42dfcfae6ed93f360fcd60518dcb91ea96c1d7567b55");
        //var scriptJson = await _scriptsClient.GetScriptJsonAsync("7ab6b893e3e9b1b8d6bb5f93ecf99694a6611d13f64678e2c5c7986c");
        //var scriptDetails = await _scriptsClient.GetScriptAsync("33b6150f4f5df62bfc638f206f3a37254d4a82f15f0c6635a20eb83f");
        //var latest = await _blocksClient.GetLatestBlockAsync();
        //var block = await _blocksClient.GetBlockAsync(latest!.Content!.PreviousBlock!);
        //var epochParams = await _epochsClient.GetLatestParamtersAsync();
        //var addressUtxos = await _addressesClient.GetAddressUtxosAsync("addr_test1qqhr9p4hvahjg8pm777vefc054fm8dda8x4chu9rygc5wjpwkmgn3ldrlyrm4wjd8cgdmsx0rrjzslyysavcgxgfeuqsrtq89r");
        //var latestEpoch = await _epochsClient.GetLatestAsync();
        //var specificEpoch = await _epochsClient.GetAsync(200);
        //var stakeDistribution = await _epochsClient.GetStakeDistributionAsync(200);
        //var stakeDistributionByPool = await _epochsClient.GetStakeDistributionByPoolAsync(200, "pool1qqfnw2fwajdnam7xsqhhrje5cgd8jcltzfrx655rd23eqlxjfef");
        //var delegators = await _poolsClient.GetDelegatorsAsync("2a748e3885f6f73320ad16a8331247b81fe01b8d39f57eec9caa5091", 50, 1);
        //var pools = await _poolsClient.GetStakepoolsAsync(23, 1);
        //var poolsExtended = await _poolsClient.GetStakepoolsExtendedAsync(10, 1);
        //var txhistory = await _accountClient.GetAccountDelegationHistory("stake_test1uqyt95qs2qyhr0xc0gg4vmzt24yyw27kta682a4duhd3eaql492l0", 100, 1, "desc");
        //var history = await _accountClient.GetAccountHistory("stake_test1uqyt95qs2qyhr0xc0gg4vmzt24yyw27kta682a4duhd3eaql492l0", 100, 1, "desc");
        //var addresses = await _accountClient.GetAccountAssociatedAddresses("stake_test1uqyt95qs2qyhr0xc0gg4vmzt24yyw27kta682a4duhd3eaql492l0", 100, 1, "asc");
        //var assets = await _accountClient.GetAccountAssociatedAddressesAssets("stake_test1uqhtd5fclk3ljpa6hfxnuyxacr833epg0jzgwkvyryyu7qg0vxxhc", 100, 1, "asc");
        //var details = await _accountClient.GetAccountDetails("stake_test1uqhtd5fclk3ljpa6hfxnuyxacr833epg0jzgwkvyryyu7qg0vxxhc");
        //var pool = await _poolsClient.GetStakepoolAsync("pool144pedg8hc3lr660w30te9jqv5zllaesegh8vt3ptft5s7qu45re");
        //var metadata = await _poolsClient.GetStakepoolAsync("pool144pedg8hc3lr660w30te9jqv5zllaesegh8vt3ptft5s7qu45re");
        //var rewards = await _accountClient.GetAccountRewards("stake_test1uqyt95qs2qyhr0xc0gg4vmzt24yyw27kta682a4duhd3eaql492l0");
        //var registrations = await _accountClient.GetAccountRegistrationHistory("stake_test1uqyt95qs2qyhr0xc0gg4vmzt24yyw27kta682a4duhd3eaql492l0");
        //var withdrawals = await _accountClient.GetAccountWithdrawals("stake_test1uqyt95qs2qyhr0xc0gg4vmzt24yyw27kta682a4duhd3eaql492l0");
        //var mirs = await _accountClient.GetAccountMirHistory("stake_test1uqyt95qs2qyhr0xc0gg4vmzt24yyw27kta682a4duhd3eaql492l0");
        //var detailedInfo = await _accountClient.GetAccountAddressesDetailedInfo("stake_test1uqyt95qs2qyhr0xc0gg4vmzt24yyw27kta682a4duhd3eaql492l0");
        //var addressInfo = await _addressesClient.GetAddressInfoAsync("addr_test1qqhr9p4hvahjg8pm777vefc054fm8dda8x4chu9rygc5wjpwkmgn3ldrlyrm4wjd8cgdmsx0rrjzslyysavcgxgfeuqsrtq89r");
        //var addressInfoExtended = await _addressesClient.GetAddressInfoExtendedAsync("addr_test1qqhr9p4hvahjg8pm777vefc054fm8dda8x4chu9rygc5wjpwkmgn3ldrlyrm4wjd8cgdmsx0rrjzslyysavcgxgfeuqsrtq89r");
        //var addressTotals = await _addressesClient.GetAddressTotalsAsync("addr_test1qqhr9p4hvahjg8pm777vefc054fm8dda8x4chu9rygc5wjpwkmgn3ldrlyrm4wjd8cgdmsx0rrjzslyysavcgxgfeuqsrtq89r");
        //var addressUtxosAsset = await _addressesClient.GetAddressUtxosOfAssetAsync("addr_test1qqhr9p4hvahjg8pm777vefc054fm8dda8x4chu9rygc5wjpwkmgn3ldrlyrm4wjd8cgdmsx0rrjzslyysavcgxgfeuqsrtq89r", "ba5de04f94409bb7e4028aa706b3527aaa25c29255e9c34c97867b81744d6f6e6574");
        //var assetHistory = await _assetsClient.GetAssetHistoryAsync("698a6ea0ca99f315034072af31eaac6ec11fe8558d3f48e9775aab9d7444524950");
        //var txs = await _blocksClient.GetLatestBlockTransactionsAsync();
        var latest = await _blocksClient.GetLatestBlockAsync();
        //var blocks = await _blocksClient.GetPreviousBlocksAsync(latest!.Content!.PreviousBlock!);
        //var blocks = await _blocksClient.GetNextBlocksAsync("edb1ab8200c5f79793414d5f597d007e5bb07749a88d574582d12f1c4918aec8");
        //var block = await _blocksClient.GetBlockInSlotAsync(23998644);
        //var block = await _blocksClient.GetBlockInEpochSlotAsync(59, 152244);
        //var txs = await _blocksClient.GetBlockTransactionsAsync("edb1ab8200c5f79793414d5f597d007e5bb07749a88d574582d12f1c4918aec8");
        //var txs = await _blocksClient.GetBlockAddressesAsync("edb1ab8200c5f79793414d5f597d007e5bb07749a88d574582d12f1c4918aec8");
        //var addrTxs = await _blocksClient.GetBlockAddressesAsync("edb1ab8200c5f79793414d5f597d007e5bb07749a88d574582d12f1c4918aec8");
        //var nextEpochs = await _epochsClient.GetNextAsync(20);
        //var prevEpochs = await _epochsClient.GetPreviousAsync(20);
        //var blocks = await _epochsClient.GetBlockDistributionAsync(20);
        //var blocks = await _epochsClient.GetBlockDistributionByPoolAsync(30, "pool144pedg8hc3lr660w30te9jqv5zllaesegh8vt3ptft5s7qu45re");
        // var paramters = await _epochsClient.GetProtocolParamtersAsync(30);

        string hex =
            "84ab0084825820be0eea644b77ac092d5966709b706ea804fcd635de2901a7982712f17c2f614a028258202c9ab2af9c2aab304fbcfd377d03950950bb14bd30ff55d82aee18d06955eb7f018258202c9ab2af9c2aab304fbcfd377d03950950bb14bd30ff55d82aee18d06955eb7f02825820451d9fbbf15ae3341a8400b75bfe5484e72ed0b4c516e3737f82395e6cfad36f01018382583901e04b9498615b471518637c2ee4ee9e8033fc15a203c616e1f32f5a7978666fa61bdf159721ef70838cba73ecf18b27fb0206048cc7d709ea821a0011e360a1581c279f842c33eed9054b9e3c70cd6a3b32298259c24b78b895cb41d91aa14454554e411b000000012a05f200a300581d71279f842c33eed9054b9e3c70cd6a3b32298259c24b78b895cb41d91a01821a00383abaa1581c279f842c33eed9054b9e3c70cd6a3b32298259c24b78b895cb41d91aa1496c6f72642074756e6101028201d81859025cd8798819300e582000000000741226880276fc783589c49336e1d4c93f52bbad168d70e0a6f900af0819fffc1a0057d4601b0000018a4efc6f280090582000000000741226880276fc783589c49336e1d4c93f52bbad168d70e0a6f900af582000000000240c2cc4e179ff6a5021bd80eca0f15fecbec02bd9cb9ac9ef7c60c65820000000001c7a9bac9fce8cb1f1aa43df0ae29c50b90409284c461cbc71d310c8582000000000022ab2a2bfead4074065b3077ecd979d28e9fa24b0fcc37dea1be049582000000000022ab2a2bfead4074065b3077ecd979d28e9fa24b0fcc37dea1be049582000000000022ab2a2bfead4074065b3077ecd979d28e9fa24b0fcc37dea1be04958200000000000e717315a3ed8ff9ec909fc77a8065cc2d7de352e8f3bab4b56664458200000000000e717315a3ed8ff9ec909fc77a8065cc2d7de352e8f3bab4b566644582000000000004280430ea94947d97ce380ceb891db7e7f8fa9f21f025dbca1e175582000000000004280430ea94947d97ce380ceb891db7e7f8fa9f21f025dbca1e175582000000000004280430ea94947d97ce380ceb891db7e7f8fa9f21f025dbca1e175582000000000000b13a68b46eeedc051cd97b4d38bfc3785296b087bfd6e91f448f5582000000000000b13a68b46eeedc051cd97b4d38bfc3785296b087bfd6e91f448f5582000000000000b13a68b46eeedc051cd97b4d38bfc3785296b087bfd6e91f448f558200000000003431f6266e3fe2748de96e04b93cbe076668a12f84253518362fd6258200000000003431f6266e3fe2748de96e04b93cbe076668a12f84253518362fd6282583901e04b9498615b471518637c2ee4ee9e8033fc15a203c616e1f32f5a7978666fa61bdf159721ef70838cba73ecf18b27fb0206048cc7d709ea821a16d1fda1a1581c279f842c33eed9054b9e3c70cd6a3b32298259c24b78b895cb41d91aa14454554e411b000000425b52e200021a00036829031a4efdceb8081a4efb0f9809a1581c279f842c33eed9054b9e3c70cd6a3b32298259c24b78b895cb41d91aa14454554e411b000000012a05f2000b5820a88fe2947b8d45d1f8b798e52174202579ecf847b8f17038c7398103df2d27b00d828258202c9ab2af9c2aab304fbcfd377d03950950bb14bd30ff55d82aee18d06955eb7f028258202c9ab2af9c2aab304fbcfd377d03950950bb14bd30ff55d82aee18d06955eb7f011082583901e04b9498615b471518637c2ee4ee9e8033fc15a203c616e1f32f5a7978666fa61bdf159721ef70838cba73ecf18b27fb0206048cc7d709ea821a1694d2f5a1581c279f842c33eed9054b9e3c70cd6a3b32298259c24b78b895cb41d91aa14454554e411b000000012a05f200111a003d0900128182582001751095ea408a3ebe6083b4de4de8a24b635085183ab8a2ac76273ef8fff5dd00a20081825820ccaabfb6d524c82712cb96a3b4f51477ce3e753355790b66def9707c8354d64f5840211b40f99e53f823cd1c9e45845b25225105b325f6084e3baaf01732aa301db5edc498d235e4dc642406b757dbf2cd43c9552d9ff6fdb0752eb5e3268619510b0582840003d87a81505ec2c3d4de5b29877f1bf0b5a8dc0227820000840100d87980820000f5f6";
        byte[] signedTx = hex.HexToByteArray();
        using MemoryStream stream = new(signedTx);
        var evaluation = _utiliesClient.GetTransactionEvaluationAsync(stream);
        Console.WriteLine(evaluation);
    }

    private async Task TestTxSubmitAsync()
    {
        var txCbor =
            "84a400838258200dbfc4ecdea2b4df9ae55dbc3ec581c5080be50ea7487f207631c39505d8af8a018258201837efed9f36335bdbfdad59944ed9278c5e0e6a3ddc43b82cbea479e1c54203028258201837efed9f36335bdbfdad59944ed9278c5e0e6a3ddc43b82cbea479e1c54203030184825839008ac3e682a6745dcca62099c8022da724bfa02b8743beab318c9708c97d43e4690624bf0c576ba2a3d070202998740e77cb5d7ffa985b9465821a0017ad4aa2581c635da8872ab583e67993c69e67f50f12cc34ef8e1e1d93da9a9fe0cda144544d4f4e18c8581c698a6ea0ca99f315034072af31eaac6ec11fe8558d3f48e9775aab9da14574445249500182583900e1deba87bcfca7bdc70217b3a8d5a126e73c938f3a1b288a71a2a54fe7236cb13ff18de175aafa3896acceb361ad7340ead54a694f99187d821a0017ad4aa1581ceb94702168e55e2fb79823efa3ab362866b9d2d97cb563b825e7b2dba14a474c4f4245303030313101825839008ac3e682a6745dcca62099c8022da724bfa02b8743beab318c9708c97d43e4690624bf0c576ba2a3d070202998740e77cb5d7ffa985b9465821a00656c1ba2581c635da8872ab583e67993c69e67f50f12cc34ef8e1e1d93da9a9fe0cda144544d4f4e1a00d9e1c7581c698a6ea0ca99f315034072af31eaac6ec11fe8558d3f48e9775aab9da14574445249501a5526450082583900e1deba87bcfca7bdc70217b3a8d5a126e73c938f3a1b288a71a2a54fe7236cb13ff18de175aafa3896acceb361ad7340ead54a694f99187d821a003e63f2a2581c635da8872ab583e67993c69e67f50f12cc34ef8e1e1d93da9a9fe0cda144544d4f4e1a09c0ae2f581c698a6ea0ca99f315034072af31eaac6ec11fe8558d3f48e9775aab9da14574445249501aa2696cd0021a00038e25031a040f32a9a10082825820b84056d4943b44d6804a65fbdf346cd47b3321c18497df5913a5bbe39fbc10b85840d565558868aad70d43c3aa1bfe18e69db45764a7454f1fd72ffa18e2f22060e575121b1393d48e3061146694cb3da77b2f6fdd7d72b13de7b1ad01c990272b0982582081fcd280a35e4d91c4044be1833f337b880b6f3dfacfe2d9bb07dd43c6a96d7a5840084083ca21a3f5a7a460220701a875fc2907215b1ee2d0b7eb5be9b18a16140144ab29fb724e76f2f28383d45f0fef7985a3581c758cd5297a414721fb305c0af5f6";
        byte[] txBytes = txCbor.HexToByteArray();

        try
        {
            using (MemoryStream stream = new MemoryStream(txBytes))
            {
                var result = await _transactionsClient.PostSubmitTransactionAsync(stream);
            }
        }
        catch (Exception ex)
        {
            ex.GetType();
            throw;
        }

        //produced - ad768ec1f3326aaf0b7a2b8284b268258bfbb8b60ff54321956bb2c4cf08eeae
    }
}
