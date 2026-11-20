// variables names: ok
// Variable names have been checked and replaced with self-descriptive names

namespace SunamoCompare._public.SunamoInterfaces.Interfaces;

public interface ITWithDt<T>
{
    T? Value { get; set; }

    DateTime Dt { get; set; }
}
