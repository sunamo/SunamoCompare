// variables names: ok
namespace SunamoCompare._public.SunamoInterfaces.Data;

/// <summary>
/// Represents a value of type T with an associated DateTime.
/// </summary>
/// <typeparam name="T">The type of the value.</typeparam>
public class TWithDtCompare<T> : ITWithDt<T>
{
    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public T? Value { get; set; } = default;

    /// <summary>
    /// Gets or sets the DateTime associated with the value.
    /// </summary>
    public DateTime Dt { get; set; }
}