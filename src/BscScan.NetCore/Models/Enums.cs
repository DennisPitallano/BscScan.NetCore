namespace BscScan.NetCore.Models;

/// <summary>
/// Tag Options
/// </summary>
public enum Tag
{
    /// <summary>
    /// Earliest
    /// </summary>
    Earliest,

    /// <summary>
    /// Pending
    /// </summary>
    Pending,

    /// <summary>
    /// Latest
    /// </summary>
    Latest
}

/// <summary>
/// Sort Options
/// </summary>
public enum Sort
{
    /// <summary>
    /// Ascending
    /// </summary>
    Asc,

    /// <summary>
    /// Descending
    /// </summary>
    Desc
}

/// <summary>
/// Closest options
/// </summary>
public enum Closest
{
    /// <summary>
    /// Before
    /// </summary>
    Before,

    /// <summary>
    /// After
    /// </summary>
    After,
}