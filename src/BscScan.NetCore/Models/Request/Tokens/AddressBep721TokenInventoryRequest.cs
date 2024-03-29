﻿namespace BscScan.NetCore.Models.Request.Tokens;

/// <summary>
/// AddressBep721TokenInventoryRequest
/// </summary>
public class AddressBep721TokenInventoryRequest
{
    /// <summary>
    /// the string representing the address to check for balance
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// the contract address of the BEP-20 token
    /// </summary>
    [JsonPropertyName("contractaddress")]
    public string? ContractAddress { get; set; }

    /// <summary>
    /// the integer page number, if pagination is enabled (default is 1)
    /// </summary>
    [JsonPropertyName("page")]
    public int Page { get; set; } = 1;

    /// <summary>
    /// the number of transactions displayed per page (default is 10)
    /// </summary>
    [JsonPropertyName("offset")]
    public int OffSet { get; set; } = 10;
}