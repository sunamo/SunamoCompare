namespace SunamoCompare._public.SunamoInterfaces.Data;

public class TWithDtCompare<T> : ITWithDt<T>
{
    public T t { get; set; } = default;
    public DateTime Dt { get; set; }
}