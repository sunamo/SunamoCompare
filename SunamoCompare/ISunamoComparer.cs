namespace SunamoCompare;

public interface ISunamoComparer<T>
{
    int Desc(T firstValue, T secondValue);
    int Asc(T firstValue, T secondValue);
}