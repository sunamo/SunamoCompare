namespace SunamoCompare;


public class TWithDt<T> : ITWithDt<T>
{
    public T t { get; set; } = default;
    public DateTime Dt { get; set; }
}