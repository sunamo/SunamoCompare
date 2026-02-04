namespace SunamoCompare;

/// <summary>
/// Defines comparison operations for sorting elements in ascending or descending order.
/// </summary>
/// <typeparam name="T">The type of objects to compare.</typeparam>
public interface ISunamoComparer<T>
{
    /// <summary>
    /// Compares two values for descending order sorting.
    /// </summary>
    /// <param name="firstValue">The first value to compare.</param>
    /// <param name="secondValue">The second value to compare.</param>
    /// <returns>A negative number if firstValue should come after secondValue in descending order, zero if they are equal, or a positive number if firstValue should come before secondValue.</returns>
    int Desc(T firstValue, T secondValue);

    /// <summary>
    /// Compares two values for ascending order sorting.
    /// </summary>
    /// <param name="firstValue">The first value to compare.</param>
    /// <param name="secondValue">The second value to compare.</param>
    /// <returns>A negative number if firstValue should come before secondValue in ascending order, zero if they are equal, or a positive number if firstValue should come after secondValue.</returns>
    int Asc(T firstValue, T secondValue);
}