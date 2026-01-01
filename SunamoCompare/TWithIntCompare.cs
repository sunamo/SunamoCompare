namespace SunamoCompare;

/// <summary>
/// Represents a value of type T with an associated integer count.
/// </summary>
/// <typeparam name="T">The type of the value.</typeparam>
public class TWithIntCompare<T>
{
    /// <summary>
    /// Gets or sets the count associated with the value.
    /// </summary>
    public int Count { get; set; } = 0;

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public T? Value { get; set; } = default;
}
