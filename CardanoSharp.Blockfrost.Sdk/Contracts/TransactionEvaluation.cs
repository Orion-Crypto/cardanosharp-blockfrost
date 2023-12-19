using System.Text.Json.Serialization;

namespace CardanoSharp.Blockfrost.Sdk.Contracts;

public class TransactionEvaluation
{
    [JsonPropertyName("type")]
    public string? Type { get; set; } = default!;

    [JsonPropertyName("version")]
    public string? Version { get; set; } = default!;

    [JsonPropertyName("servicename")]
    public string? Servicename { get; set; } = default!;

    [JsonPropertyName("methodname")]
    public string? Methodname { get; set; } = default!;

    [JsonPropertyName("result")]
    public EvaluationObjectResult? Result { get; set; } = default!;

    // public Dictionary<string, ExUnits> GetExUnits()
    // {
    //     Dictionary<string, ExUnits> exUnits = new Dictionary<string, ExUnits>();
    //     if (result == null || result.EvaluationResult == null)
    //         return null!;

    //     foreach (var evaluationResult in result.EvaluationResult!)
    //     {
    //         ExUnits exUnit = new ExUnits { Mem = (ulong)evaluationResult.Value.memory!, Steps = (ulong)evaluationResult.Value.steps! };
    //         exUnits.Add(evaluationResult.Key, exUnit);
    //     }
    //     return exUnits;
    // }

    // public override string ToString()
    // {
    //     return JsonSerializer.Serialize(this);
    // }
}

public class EvaluationObjectResult
{
    [JsonPropertyName("EvaluationResult")]
    public Dictionary<string, EvaluationExUnits>? EvaluationResult { get; set; } = new Dictionary<string, EvaluationExUnits>()!;

    [JsonPropertyName("EvaluationFailure")]
    public EvaluationFailure EvaluationFailure { get; set; } = default!;
}

public class EvaluationFailure
{
    [JsonPropertyName("ScriptFailures")]
    public Dictionary<string, List<ScriptFailure>> ScriptFailures { get; set; } = default!;
}

public class ScriptFailure
{
    [JsonPropertyName("validatorFailed")]
    public ValidatorFailure ValidatorFailed { get; set; } = default!;
}

public class ValidatorFailure
{
    [JsonPropertyName("error")]
    public string? Error { get; set; } = "";

    [JsonPropertyName("traces")]
    public List<string>? Traces { get; set; } = new List<string>();
}

public class EvaluationExUnits
{
    [JsonPropertyName("memory")]
    public ulong? Memory { get; set; } = default!;

    [JsonPropertyName("steps")]
    public ulong? Steps { get; set; } = default!;
}
