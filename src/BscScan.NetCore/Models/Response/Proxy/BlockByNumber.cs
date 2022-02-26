using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Proxy;

/// <summary>
/// BlockByNumber Model
/// </summary>
public class BlockByNumber
{
    /// <summary>
    /// JsonPrc
    /// </summary>
    [JsonPropertyName("jsonrpc")]
    public string? JsonPrc { get; set; }

    /// <summary>
    /// Id
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// BlockByNumberData
    /// </summary>
    [JsonPropertyName("result")]
    public BlockByNumberData? Result { get; set; }

}

/// <summary>
/// BlockByNumberData
/// </summary>
public class BlockByNumberData
{
    /// <summary>
    /// BaseFeePerGas
    /// </summary>
    [JsonPropertyName("baseFeePerGas")]
    public string? BaseFeePerGas { get; set; }

    /// <summary>
    /// Difficulty
    /// </summary>
    [JsonPropertyName("difficulty")]
    public string? Difficulty { get; set; }

    /// <summary>
    /// extraData
    /// </summary>
    [JsonPropertyName("extraData")]
    public string? ExtraData { get; set; }

    /// <summary>
    /// gasLimit
    /// </summary>
    [JsonPropertyName("gasLimit")]
    public string? GasLimit { get; set; }

    /// <summary>
    /// gasUsed
    /// </summary>
    [JsonPropertyName("gasUsed")]
    public string? GasUsed { get; set; }

    /// <summary>
    /// hash
    /// </summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary>
    /// logsBloom
    /// </summary>
    [JsonPropertyName("logsBloom")]
    public string? LogsBloom { get; set; }

    /// <summary>
    /// miner
    /// </summary>
    [JsonPropertyName("miner")]
    public string? Miner { get; set; }

    /// <summary>
    /// mixHash
    /// </summary>
    [JsonPropertyName("mixHash")]
    public string? MixHash { get; set; }

    /// <summary>
    /// nonce
    /// </summary>
    [JsonPropertyName("nonce")]
    public string? Nonce { get; set; }

    /// <summary>
    /// number
    /// </summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>
    /// parentHash
    /// </summary>
    [JsonPropertyName("parentHash")]
    public string? ParentHash { get; set; }

    /// <summary>
    /// receiptsRoot
    /// </summary>
    [JsonPropertyName("receiptsRoot")]
    public string? ReceiptsRoot { get; set; }

    /// <summary>
    /// sha3Uncles
    /// </summary>
    [JsonPropertyName("sha3Uncles")]
    public string? Sha3Uncles { get; set; }

    /// <summary>
    /// size
    /// </summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>
    /// stateRoot
    /// </summary>
    [JsonPropertyName("stateRoot")]
    public string? StateRoot { get; set; }

    /// <summary>
    /// timestamp
    /// </summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    /// <summary>
    /// totalDifficulty
    /// </summary>
    [JsonPropertyName("totalDifficulty")]
    public string? TotalDifficulty { get; set; }

    /// <summary>
    /// List of Full Transaction Objects 
    /// </summary>
    [JsonPropertyName("transactions")]
    public IEnumerable<BlockByNumberDataTransaction>? Transactions { get; set; }

    /// <summary>
    /// List of  Transactions Hash
    /// </summary>
    public IEnumerable<string?> TransactionsHash
    {
        get
        {
            return Transactions!.Select(t => t.Hash);
        }
    }

    /// <summary>
    /// transactionsRoot
    /// </summary>
    [JsonPropertyName("transactionsRoot")]
    public string? TransactionsRoot { get; set; }


    /// <summary>
    /// uncles
    /// </summary>
    [JsonPropertyName("uncles")]
    public List<string>? Uncles { get; set; }
}

/// <summary>
/// BlockByNumberDataTransaction
/// </summary>
public class BlockByNumberDataTransaction
{
    /// <summary>
    /// blockHash
    /// </summary>
    [JsonPropertyName("blockHash")]
    public string? BlockHash { get; set; }
    /// <summary>
    /// blockNumber
    /// </summary>
    [JsonPropertyName("blockNumber")]
    public string? BlockNumber { get; set; }
    /// <summary>
    /// from
    /// </summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }
    /// <summary>
    /// gas
    /// </summary>
    [JsonPropertyName("gas")]
    public string? Gas { get; set; }
    /// <summary>
    /// gasPrice
    /// </summary>
    [JsonPropertyName("gasPrice")]
    public string? GasPrice { get; set; }
    /// <summary>
    /// hash
    /// </summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }
    /// <summary>
    /// input
    /// </summary>
    [JsonPropertyName("input")]
    public string? Input { get; set; }
    /// <summary>
    /// nonce
    /// </summary>
    [JsonPropertyName("nonce")]
    public string? Nonce { get; set; }
    /// <summary>
    /// to
    /// </summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
    /// <summary>
    /// transactionIndex
    /// </summary>
    [JsonPropertyName("transactionIndex")]
    public string? TransactionIndex { get; set; }
    /// <summary>
    /// value
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// type
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    /// <summary>
    /// v
    /// </summary>
    [JsonPropertyName("v")]
    public string? V { get; set; }
    /// <summary>
    /// r
    /// </summary>
    [JsonPropertyName("r")]
    public string? R { get; set; }
    /// <summary>
    /// s
    /// </summary>
    [JsonPropertyName("s")]
    public string? S { get; set; }
}