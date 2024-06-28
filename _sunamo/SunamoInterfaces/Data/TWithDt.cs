namespace SunamoCompare;


internal class TWithDt<T> : ITWithDt<T>
{
    internal T t { get; set; } = default;
    internal DateTime Dt { get; set; }
}