namespace SunamoCompare;

/// <summary>
/// Represents the i sunamo comparer t type.
/// </summary>
public interface ISunamoComparer<T>
{
    /// <summary>
    /// Desc.
    /// </summary>
    /// <param name="firstValue">The first value.</param>
    /// <param name="secondValue">The second value.</param>
    /// <returns>The desc result.</returns>
    int Desc(T firstValue, T secondValue);
    /// <summary>
    /// Asc.
    /// </summary>
    /// <param name="firstValue">The first value.</param>
    /// <param name="secondValue">The second value.</param>
    /// <returns>The asc result.</returns>
    int Asc(T firstValue, T secondValue);
}
