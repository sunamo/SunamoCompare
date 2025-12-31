// variables names: ok
// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy

namespace SunamoCompare._public.SunamoInterfaces.Interfaces;


public interface ITWithDt<T>
{
    T Value { get; set; }
    DateTime Dt { get; set; }
}