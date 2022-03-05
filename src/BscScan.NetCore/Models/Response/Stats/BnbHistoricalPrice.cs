using System.Text.Json.Serialization;

namespace BscScan.NetCore.Models.Response.Stats;

/// <summary>
/// Bnb Historical Price
/// </summary>
public class BnbHistoricalPrice : BaseResponse
{
    /// <summary>
    /// List of BnbHistoricalPriceData
    /// </summary>
    [JsonPropertyName("result")]
    public IEnumerable<BnbHistoricalPriceData>? Result { get; set; }
}

/// <summary>
/// BnbHistoricalPriceData
/// </summary>
public class BnbHistoricalPriceData
{
    /// <summary>
    /// UTCDate
    /// </summary>
    [JsonPropertyName("UTCDate")]
    public string? UtcDate { get; set; }

    /// <summary>
    /// unixTimeStamp
    /// </summary>
    [JsonPropertyName("unixTimeStamp")]
    public string? UnixTimeStamp { get; set; }

    /// <summary>
    /// value
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}