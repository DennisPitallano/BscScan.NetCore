namespace BscScan.NetCore.Configuration;

/// <summary>
/// BscScan Options 
/// </summary>
public class BscScanOptions
{
    /// <summary>
    /// Api-Key Token from BscScan Account
    /// </summary>
    public string? Token { get; set; }
    /// <summary>
    /// BscScan API domain
    ///  Ex: https://api.bscscan.com/api for main network
    ///      https://api-testnet.bscscan.com/  for test network
    /// </summary>
    public string? Uri { get; set; }
}