namespace SunamoCompare._public.SunamoInterfaces.Data;

public class TWithDtCompare<T> : ITWithDt<T>
{
    public T Value { get; set; } = default;
    public DateTime Dt { get; set; }
}