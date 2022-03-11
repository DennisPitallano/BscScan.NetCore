namespace BscScan.NetCore.Models.Response.Stats;

/// <summary>
/// ValidatorsList
/// </summary>
public class ValidatorsList : BaseResponse
{
    /// <summary>
    /// List of ValidatorsListData
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<ValidatorsListData>? Result { get; set; }
}

/// <summary>
/// ValidatorsListData
/// </summary>
public class ValidatorsListData
{
    /// <summary>
    /// validatorAddress
    /// </summary>
    [JsonPropertyName("validatorAddress")]
    public string? ValidatorAddress { get; set; }

    /// <summary>
    /// validatorName
    /// </summary>
    [JsonPropertyName("validatorName")]
    public string? ValidatorName { get; set; }

    /// <summary>
    /// validatorStatus
    /// </summary>
    [JsonPropertyName("validatorStatus")]
    public string? ValidatorStatus { get; set; }


    /// <summary>
    /// validatorVotingPower
    /// </summary>
    [JsonPropertyName("validatorVotingPower")]
    public string? ValidatorVotingPower { get; set; }

    /// <summary>
    /// validatorVotingPowerProportion
    /// </summary>
    [JsonPropertyName("validatorVotingPowerProportion")]
    public string? ValidatorVotingPowerProportion { get; set; }
}