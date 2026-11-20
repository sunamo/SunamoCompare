
namespace SunamoCompare._public.SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the IT with dt t type.
/// </summary>
public interface ITWithDt<T>
{
    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    T? Value { get; set; }

    /// <summary>
    /// Gets or sets the dt.
    /// </summary>
    DateTime Dt { get; set; }
}
