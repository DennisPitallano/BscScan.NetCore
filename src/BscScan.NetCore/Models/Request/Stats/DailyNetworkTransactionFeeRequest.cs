namespace BscScan.NetCore.Models.Request.Stats;

/// <summary>
/// DailyNetworkTransactionFeeRequest
/// </summary>
public class DailyNetworkTransactionFeeRequest
{
    /// <summary>
    /// the starting date in yyyy-MM-dd format, eg. 2020-10-01
    /// </summary>
    [JsonIgnore]
    public DateOnly StartDate { get; set; }

    /// <summary>
    /// the ending date in yyyy-MM-dd format, eg. 2020-10-31
    /// </summary>
    [JsonIgnore]
    public DateOnly EndDate { get; set; }

    /// <summary>
    /// the sorting preference, use asc to sort by ascending and desc to sort by descending (default is asc)
    /// </summary>
    [JsonIgnore]
    public Sort Sort { get; set; } = Sort.Asc;

    /// <summary>
    /// the starting date in yyyy-MM-dd format, eg. 2020-10-01
    /// </summary>
    [JsonPropertyName("startdate")]
    public string StartDateParam => StartDate.ToString("yyyy-MM-dd");

    /// <summary>
    /// the ending date in yyyy-MM-dd format, eg. 2020-10-31
    /// </summary>
    [JsonPropertyName("enddate")]
    public string EndDateParam => EndDate.ToString("yyyy-MM-dd");

    /// <summary>
    /// the sorting preference, use asc to sort by ascending and desc to sort by descending (default is asc)
    /// </summary>

    [JsonPropertyName("sort")]
    public string SortParam => Sort.ToString().ToLower();
}