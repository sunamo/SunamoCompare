// variables names: ok
// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy

namespace SunamoCompare._public.SunamoInterfaces.Interfaces;

/// <summary>
/// Defines a value of type T with an associated DateTime.
/// </summary>
/// <typeparam name="T">The type of the value.</typeparam>
public interface ITWithDt<T>
{
    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    T? Value { get; set; }

    /// <summary>
    /// Gets or sets the DateTime associated with the value.
    /// </summary>
    DateTime Dt { get; set; }
}