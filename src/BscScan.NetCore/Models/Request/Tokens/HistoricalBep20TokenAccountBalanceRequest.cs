using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Request.Tokens;

/// <summary>
/// HistoricalBep20TokenAccountBalanceRequest
/// </summary>
public class HistoricalBep20TokenAccountBalanceRequest
{
    /// <summary>
    /// the contract address of the BEP-20 token
    /// </summary>
    [JsonPropertyName("contractaddress")]
    public string? ContractAddress { get; set; }
    /// <summary>
    /// the string representing the address to check for balance
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// the integer block number to check total supply for eg. 400000
    /// </summary>
    [JsonPropertyName("blockno")]
    public int BlockNo { get; set; }
}