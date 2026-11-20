
namespace SunamoCompare._public.SunamoInterfaces.Interfaces;

public interface ITWithDt<T>
{
    T? Value { get; set; }

    DateTime Dt { get; set; }
}
