namespace SunamoCompare;


public interface ITWithDt<T>
{
    T t { get; set; }
    DateTime Dt { get; set; }
}