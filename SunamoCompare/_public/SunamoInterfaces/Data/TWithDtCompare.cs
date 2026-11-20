namespace SunamoCompare._public.SunamoInterfaces.Data;

/// <summary>
/// Represents the t with dt compare t type.
/// </summary>
public class TWithDtCompare<T> : ITWithDt<T>
{
    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public T? Value { get; set; } = default;

    /// <summary>
    /// Gets or sets the dt.
    /// </summary>
    public DateTime Dt { get; set; }
}
