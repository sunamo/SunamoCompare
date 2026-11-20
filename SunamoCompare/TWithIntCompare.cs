namespace SunamoCompare;

/// <summary>
/// Represents the t with int compare t type.
/// </summary>
public class TWithIntCompare<T>
{
    /// <summary>
    /// Gets or sets the count.
    /// </summary>
    public int Count { get; set; } = 0;

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public T? Value { get; set; } = default;
}
