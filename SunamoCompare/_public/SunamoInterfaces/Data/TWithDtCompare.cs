// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoCompare._public.SunamoInterfaces.Data;


public class TWithDtCompare<T> : ITWithDt<T>
{
    public T t { get; set; } = default;
    public DateTime Dt { get; set; }
}