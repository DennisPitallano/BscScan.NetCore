﻿namespace BscScan.NetCore.Models.Response.Proxy;

/// <summary>
/// EthStorageAt
/// </summary>
public class EthStorageAt
{
    /// <summary>
    /// JsonRpc
    /// </summary>
    [JsonPropertyName("jsonrpc")]
    public string? JsonRpc { get; set; }

    /// <summary>
    /// Id
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// result
    /// </summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}